using System.Web.Mvc;
using WorldNomads.BusinessLogic;
using WorldNomads.ViewModels;

namespace WorldNomads.Controllers
{
    public class HomeController : Controller
    {
        ICalcualteSequence _calculate = null;
        CalculateViewModel _calculateViewModel = null;
        public HomeController()
        {
            _calculate = CalcualteSequence.Instance;
            _calculateViewModel = new CalculateViewModel();
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetSequence(long number)
        {
            _calculateViewModel.Sequence = _calculate.Sequence(number);
            _calculateViewModel.EvenSequence = _calculate.EvenSequence(number);
            _calculateViewModel.OddSequence = _calculate.OddSequence(number);
            _calculateViewModel.FibonacciSequence = _calculate.FibonacciSequence(number);

            if (string.IsNullOrEmpty(_calculate.SequenceWithCondition(number)))
            {
                _calculateViewModel.GetSequenceWithCondition = _calculateViewModel.Sequence;
            }
            else
            {
                _calculateViewModel.GetSequenceWithCondition = _calculate.SequenceWithCondition(number);
            }

            return Json(_calculateViewModel, JsonRequestBehavior.AllowGet);
        }
    }
}
