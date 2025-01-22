using System.Diagnostics;
using LanguageInstall.Service.Service;
using LanguageInstallMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageInstallMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILocalizationService _translationService;

        public HomeController(ILogger<HomeController> logger, ILocalizationService translationService)
        {
            _logger = logger;
            _translationService = translationService;
        }


        public async Task<IActionResult> Index()
        {
            var languageCode = HttpContext.Items["Language"] as string ?? "en";

            // Fetch localized text from the translation service or database
            ViewBag.PageTitle = await _translationService.GetTranslationAsync("001","Leave Application Entry", languageCode);
            ViewBag.Home = await _translationService.GetTranslationAsync("002", "Home", languageCode);
            ViewBag.HumanResourceManagement = await _translationService.GetTranslationAsync("003", "Human Resource Management", languageCode);
            ViewBag.LeaveManagement = await _translationService.GetTranslationAsync("004", "Leave Management", languageCode);
            ViewBag.Operation = await _translationService.GetTranslationAsync("005", "Operation", languageCode);
            ViewBag.CompanyLabel = await _translationService.GetTranslationAsync("006", "Company", languageCode);
            ViewBag.EmployeeIdLabel = await _translationService.GetTranslationAsync("007", "Employee ID", languageCode);
            ViewBag.EmployeeNameLabel = await _translationService.GetTranslationAsync("008", "Employee Name", languageCode);
            ViewBag.DesignationLabel = await _translationService.GetTranslationAsync("009", "Designation", languageCode);
            ViewBag.DepartmentLabel = await _translationService.GetTranslationAsync("010", "Department", languageCode);
            ViewBag.EntryIdLabel = await _translationService.GetTranslationAsync("011", "Entry ID", languageCode);
            ViewBag.SupervisorLabel = await _translationService.GetTranslationAsync("012", "Immediate Supervisor", languageCode);
            ViewBag.LeaveFormatLabel = await _translationService.GetTranslationAsync("013", "Apply Leave Format", languageCode);
            ViewBag.LeaveTypeLabel = await _translationService.GetTranslationAsync("014", "Leave Type", languageCode);
            ViewBag.ReasonLabel = await _translationService.GetTranslationAsync("015", "Reason", languageCode);
            ViewBag.FileAttachmentLabel = await _translationService.GetTranslationAsync("016", "File Attachment", languageCode);
            ViewBag.SubmitButton = await _translationService.GetTranslationAsync("017", "Leave Apply", languageCode);
            ViewBag.CancelButton = await _translationService.GetTranslationAsync("018", "Cancel", languageCode);
            ViewBag.HalfDayLeave = await _translationService.GetTranslationAsync("019", "Half Day Leave", languageCode);
            ViewBag.FullDayLeave = await _translationService.GetTranslationAsync("020", "Full Day Leave", languageCode);
            ViewBag.SickLeave = await _translationService.GetTranslationAsync("021", "Sick Leave", languageCode);
            ViewBag.CasualLeave = await _translationService.GetTranslationAsync("022", "Casual Leave", languageCode);
            ViewBag.LeaveDuration = await _translationService.GetTranslationAsync("023", "Leave Duration", languageCode);
            ViewBag.AdditionalInfoTitle = await _translationService.GetTranslationAsync("024", "Additional Information", languageCode);
            ViewBag.SelectOption = await _translationService.GetTranslationAsync("025", "--Select--", languageCode);
            ViewBag.SelectEmployee = await _translationService.GetTranslationAsync("026", "Select Employee", languageCode);
            ViewBag.SelectLeaveFormat = await _translationService.GetTranslationAsync("027", "Select Leave Format", languageCode);
            ViewBag.SelectLeaveType = await _translationService.GetTranslationAsync("028", "Select Leave Type", languageCode);
            ViewBag.ReasonPlaceholder = await _translationService.GetTranslationAsync("029", "Enter Reason", languageCode);
            ViewBag.Test = await _translationService.GetTranslationAsync("030", "Test", languageCode);
            ViewBag.Mobile = await _translationService.GetTranslationAsync("031", "Mobile buy", languageCode);
            ViewBag.Laptop = await _translationService.GetTranslationAsync("032", "Laptop Buy", languageCode);

            return View();
        }


        public async Task<IActionResult> RazorHelper()
        {
           

            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ChangeLanguage(string languageCode)
        {
            Response.Cookies.Append("Language", languageCode, new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
