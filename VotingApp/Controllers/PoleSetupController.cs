using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using VotingApp.Models;
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

        public ActionResult AddToList(AddToListModel ObjAddToListModel)
        {
            string saveImage = "";
            try
            {
                if (ObjAddToListModel.ImageFile != null)
                {
                    WebImage img = new WebImage(ObjAddToListModel.ImageFile.InputStream);
                    string fileName = Path.GetFileNameWithoutExtension(ObjAddToListModel.ImageFile.FileName);
                    string extension = Path.GetExtension(ObjAddToListModel.ImageFile.FileName);
                    fileName = fileName + DateTime.Now.ToString("yyyyMMddHHmmssfff") + extension;
                    ObjAddToListModel.ImagePath = "~/Images/" + fileName;
                    fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);
                    img.Save(fileName);
                    saveImage = "SUCCESS";
                }
                return Json(saveImage, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                saveImage = e.Message;
                return Json(saveImage, JsonRequestBehavior.AllowGet);
            }
           
        }
    }
}