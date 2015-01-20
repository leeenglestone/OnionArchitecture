using PetStore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace PetStore.Web.MvcWebApplication.Controllers
{
    public class PetController : Controller
    {
        IPetService _petService;

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