using DataAccessLayer;
using DataAccessLayer.Models;
using DataAccessLayer.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Trip_Log.Models;

namespace Trip_Log.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _appDbContext;
        private readonly IConfiguration _configuration;
        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext, IConfiguration configuration)
        {
            _appDbContext = appDbContext;
            _logger = logger;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            var data = from tripLog in _appDbContext.tripLogModels
                       join destination in _appDbContext.destination
                       on tripLog.DestinationId equals destination.DestinationId
                       join accommodation in _appDbContext.accomodation
                       on tripLog.AccommodationId equals accommodation.AccommodationId
                       join activity1 in _appDbContext.activities
                       on tripLog.ThingToDo1 equals activity1.ActivityId
                       join activity2 in _appDbContext.activities
                       on tripLog.ThingToDo2 equals activity2.ActivityId
                       join activity3 in _appDbContext.activities
                       on tripLog.ThingToDo3 equals activity3.ActivityId
                       select new vmTripLog
                       {
                           TripId = tripLog.TripId,
                           DestinationName = destination.DestinationName,
                           StartDate = tripLog.StartDate,
                           EndDate = tripLog.EndDate,
                           AccommodationName = accommodation.AccommodationName,
                           ThingToDo1 = activity1.ActivityName,
                           ThingToDo2 = activity2.ActivityName,
                           ThingToDo3 = activity3.ActivityName
                       };

            var result = await data.ToListAsync();

            return View(result);
        }


        public async Task<IActionResult> AddTripLog()
        {
            var destinantions = await _appDbContext.destination.ToListAsync();
            ViewBag.destinations = destinantions;

            var accommodations =await _appDbContext.accomodation.ToListAsync();
            ViewBag.accommodations = accommodations;

            var activities = await _appDbContext.activities.ToListAsync();
            ViewBag.activities = activities;

            return View();
        }

        [HttpPost]
        public ActionResult PostData(int Destinations, int Accommodations, string SDate, string EDate, string PNumber, string EAddress, string Thing1, string Thing2, string Thing3)
        {
            try
            {
                string connectionString = _configuration.GetConnectionString("DefaultConnection");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                INSERT INTO tripLogModels (DestinationId, StartDate, EndDate, AccommodationId, ThingToDo1, ThingToDo2, ThingToDo3)
                VALUES (@DestinationId, @StartDate, @EndDate, @AccommodationId, @ThingToDo1, @ThingToDo2, @ThingToDo3)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DestinationId", Destinations);
                        command.Parameters.AddWithValue("@StartDate", SDate);
                        command.Parameters.AddWithValue("@EndDate", EDate);
                        command.Parameters.AddWithValue("@AccommodationId", Accommodations);
                        //command.Parameters.AddWithValue("@AccommodationEmail", EAddress);
                        command.Parameters.AddWithValue("@ThingToDo1", Thing1);
                        command.Parameters.AddWithValue("@ThingToDo2", Thing2);
                        command.Parameters.AddWithValue("@ThingToDo3", Thing3);

                        int rowCount = command.ExecuteNonQuery();

                        if (rowCount > 0)
                        {
                            TempData["Message"] = @"<div style='background-color: #02992f; color: white; padding: 16px; border-radius: 8px; font-size: 16px; font-weight: bold;'>" +
                                                    "Trip added successfully." +
                                                    "<span style='float: right; cursor: pointer;' onclick='this.parentElement.style.display=\"none\";'>&times;</span>" +
                                                    "</div>";
                        }
                        else
                        {
                            TempData["Message"] = @"<div style='background-color: #f44336; color: white; padding: 16px; border-radius: 8px; font-size: 16px; font-weight: bold;'>" +
                                                    "Error saving the trip." +
                                                    "<span style='float: right; cursor: pointer;' onclick='this.parentElement.style.display=\"none\";'>&times;</span>" +
                                                    "</div>";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["Message"] = $"<div style='background-color: #02992f; color: white; padding: 16px; border-radius: 8px; font-size: 16px; font-weight: bold;'>" +
                         $"Trip added successfully." +
                         "<span style='float: right; cursor: pointer;' onclick='this.parentElement.style.display=\"none\";'>&times;</span>" +
                         "</div>"
;

            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteData(int tripId)
        {
            try
            {
                var trip = _appDbContext.tripLogModels.FirstOrDefault(x => x.TripId == tripId);

                if (trip != null)
                {
                    _appDbContext.tripLogModels.Remove(trip);
                    _appDbContext.SaveChanges();

                    return Json(new { success = true, message = "Trip deleted successfully" });
                }
                else
                    return Json(new { success = false, message = "Trip not found" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "An error occurred while deleting the trip" });
            }
        }

        public async Task<IActionResult> AddEssentials()
        {
            var activities =  await _appDbContext.activities.ToListAsync();
            ViewBag.activities = activities;

            var destination = await _appDbContext.destination.ToListAsync();
            ViewBag.destination = destination;

            var accommodation = await _appDbContext.accomodation.ToListAsync();
            ViewBag.accomodation = accommodation;
            return View();
        }

        [HttpPost]
        public ActionResult AddActivity(string activityName)
        {
            try
            {
                var newActivity = new Activities { ActivityName = activityName };
                _appDbContext.activities.Add(newActivity);

                _appDbContext.SaveChanges();

                return Json(new { success = true, message = "Activity added successfully" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "An error occurred while adding the activity: " + ex.Message });
            }
        }


        [HttpPost]
        public ActionResult AddDestination(string destinationName)
        {
            try
            {
                var newActivity = new Destination { DestinationName = destinationName };
                _appDbContext.destination.Add(newActivity);

                _appDbContext.SaveChanges();

                return Json(new { success = true, message = "Activity added successfully" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "An error occurred while adding the activity: " + ex.Message });
            }
        }

        [HttpPost]
        public ActionResult AddAccommodation(string AccommodationName, string AccommodationPhone, string AccommodationEmail)
        {
            try
            {
                var newActivity = new Accommodation { AccommodationName = AccommodationName, 
                    AccommodationEmail = AccommodationEmail, AccommodationPhone=AccommodationPhone };
                _appDbContext.accomodation.Add(newActivity);

                _appDbContext.SaveChanges();

                return Json(new { success = true, message = "Accommodation added successfully" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "An error occurred while adding the Accommodation: " + ex.Message });
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
