using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VotingApp.Models.DbContext;

namespace VotingApp.Controllers
{
    public class PoleSetupController : Controller
    {
        CellPhoneVotingEntities db = new CellPhoneVotingEntities();
        // GET: PoleSetup
        public ActionResult Index()
        {
            List<tblPole> poles = db.tblPoles.ToList();
            return View(poles);
        }
    }
}