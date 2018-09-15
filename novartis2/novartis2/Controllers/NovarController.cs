using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MSContext;
using novartis2.Data;
using novartis2.Models.modelViews;


namespace novartis2.Controllers
{
    public class NovarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NovarController(ApplicationDbContext context)
        {
            _context = context;
           // agent = (Agent)this.Master;
        }

        OrderModel Om = new OrderModel();
        reportsModel Rm = new reportsModel();

        /// <summary>
        /// orders part
        /// </summary>
        /// <returns></returns>
        public IActionResult Orders()
        {
            Om.acount = _context.accounts.ToList();
            Om.hmo = _context.ScHmos.ToList();
            Om.Agent = _context.ScAgents.ToList();
            return View(Om);
        }

        [HttpPost]
        public ActionResult GetItem(string cmbhmo)
        {
            Om.scPharmacies = _context.scPharmacies.ToList();

            if (cmbhmo == "4")      // for clalit or yarpa code
                Om.clalit = 1;
            else Om.clalit = 0;

            List<SelectListItem> drop = new List<SelectListItem>();

            foreach (ScPharmacy pharm in Om.scPharmacies)
            {
                if (cmbhmo == pharm.HmoId.ToString()) //  && agent.User.AccountId                                       
                {
                    drop.Add(new SelectListItem
                    {
                        Text = pharm.PharmacyName,
                        Value = pharm.PharmacyId.ToString()
                    }
                );

                }
            }
            return Json(drop);
        }

        [HttpPost]
        public ActionResult GetItemGrdA(string pharmId)
        {
            List<ScProduct> prd = new List<ScProduct>(); 
            //// pharmId, --->
            Om.ScProducts = _context.ScProducts.ToList();
            //get the table and fill prd by our needs from tables
           

            return Json(Om.ScProducts);
        }
        /// <summary>
        /// report part
        /// </summary>
        /// <returns></returns>
        public IActionResult Reports()
        {
            Rm.listItemsReports = Rm.listItemsreport();
            Rm.listItemsPeriod = Rm.listItemsperiod();
            return View(Rm);
        }
        [HttpPost]
        public IActionResult UpdateReportCmb(string CmbReport)
        {
            Rm.CmbReportVal = Int16.Parse(CmbReport);
            return Json(null);
        }

        [HttpPost]
        public IActionResult UpdatePeriodCmb(string CmbPeriod)
        {
            Rm.CmbPeriodVal = Int16.Parse(CmbPeriod);
            return Json(Rm.CmbPeriodVal);
        }
        [HttpPost]
        public IActionResult ClickCreateBtn(string Data)
        {
            // get the data and create the tables we need
            return Json(null);
        }

    }
}