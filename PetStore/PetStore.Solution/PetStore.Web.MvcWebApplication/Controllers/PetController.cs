using System.Web.Mvc;
using PetStore.Service.Interfaces;

namespace PetStore.Web.MvcWebApplication.Controllers
{
    public class PetController : Controller
    {
        readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        public ActionResult Index()
        {
            var pets = _petService.GetAll();

            return View(pets);
        }
    }
}