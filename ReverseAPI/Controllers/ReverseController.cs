using Microsoft.AspNetCore.Mvc;
using ReverseAPI.Models;
using ReverseAPI.Services;

namespace ReverseAPI.Controllers
{
    public class ReverseController : Controller
    {
        private readonly IReverseService _reverseService;
        private ReverseViewModel viewModel;
        public ReverseController(IReverseService reverseService)
        {
            _reverseService = reverseService;
            viewModel = new ReverseViewModel();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(ReverseViewModel viewModel)
        {
            if (!string.IsNullOrWhiteSpace(viewModel.StringValue))
            {
                viewModel.ReverseStringValue = _reverseService.StringReverse(viewModel.StringValue.Trim());
                return View(viewModel);
            }
            return View(viewModel);
        }
    }
}