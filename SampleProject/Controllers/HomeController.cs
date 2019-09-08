using System.Web.Mvc;
using SampleProject.SampleServices.Abstraction;

namespace SampleProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService1 _service1;
        private readonly IService2 _service2;
        private readonly IService3 _service3;

        public HomeController(IService1 service1,
            IService2 service2,
            IService3 service3)
        {
            _service1 = service1;
            _service2 = service2;
            _service3 = service3;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}