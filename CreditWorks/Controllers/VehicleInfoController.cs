using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CreditWorks.Models;

namespace CreditWorks.Controllers
{
    public class VehicleInfoController : Controller
    {
        public ActionResult Index()
        {
            CreditWorksEntities db = new CreditWorksEntities();
            ViewData.Model = db.VehicleInfo.ToList();

            return View();
        }

        public ActionResult Create()
        {
            CreditWorksEntities db = new CreditWorksEntities();
            ViewData["manufacturer"] = db.Vehicle_Manufacturer.ToList();
            return View();
        }

        public ActionResult SubmitForm(VehicleInfo info)
        {
            try
            {               
                CreditWorksEntities db = new CreditWorksEntities();
                List<Vehicle_Category> categoryList = db.Vehicle_Category.ToList();

                //use range to find categoryId
                foreach (var category in categoryList) {
                    if (category.RangeMin <= info.WeightOfVehicle && category.RangeMax >= info.WeightOfVehicle) {
                        info.CategoryId = category.Id;
                    }
                }
                //can not be created if can not find match Category Id
                if (info.OwnerName !=null && info.YearOfManufacture != 0 && info.WeightOfVehicle != 0 && info.CategoryId != 0)
                {
                    db.VehicleInfo.Add(new VehicleInfo()
                    {
                        ManufacturerId = info.ManufacturerId,
                        OwnerName = info.OwnerName,
                        CategoryId = info.CategoryId,
                        WeightOfVehicle = info.WeightOfVehicle,
                        YearOfManufacture = info.YearOfManufacture
                    });

                    db.SaveChanges();
                }
                return RedirectToAction("Create", "VehicleInfo");
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
