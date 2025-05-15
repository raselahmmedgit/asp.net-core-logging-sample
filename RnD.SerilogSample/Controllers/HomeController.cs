using Microsoft.AspNetCore.Mvc;
using RnD.SerilogSample.Managers;
using RnD.SerilogSample.Models;
using System.Diagnostics;

namespace RnD.SerilogSample.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IDataManager _iDataManager;


		public HomeController(ILogger<HomeController> logger, IDataManager iDataManager)
		{
			_logger = logger;
			_iDataManager = iDataManager;
		}

		public IActionResult Index()
		{
			return View();
		}

        public IActionResult DemoLog()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
