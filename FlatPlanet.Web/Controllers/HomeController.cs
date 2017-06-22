namespace FlatPlanet.Web.Controllers
{
    using System;
    using System.Web.Mvc;
    using System.Linq;
    using DAL;
    using DAL.Entities;

    public class HomeController : Controller
    {
        #region Fields
        private AppDbContext _context;
        #endregion

        #region Constructor
        public HomeController()
        {
            _context = new AppDbContext();
        }
        #endregion

        #region Methods
        public ActionResult Index()
        {
            var objList = _context.ButtonEventDetails.ToList();
            return View(objList);
        }
        public ActionResult Click()
        {
            ButtonEventDetails objDTO = new ButtonEventDetails()
            {
                TimeStamp = DateTime.Now
            };
            _context.ButtonEventDetails.Add(objDTO);
            _context.SaveChanges();

            var objList = _context.ButtonEventDetails.ToList();
            return View("Index", objList);
        }
        #endregion
    }
}