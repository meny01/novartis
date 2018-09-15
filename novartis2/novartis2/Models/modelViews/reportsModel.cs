using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace novartis2.Models.modelViews
{
    public class reportsModel
    {
        public int CmbReportVal { get; set; } = 0;
        public int CmbPeriodVal { get; set; }

        public List<SelectListItem> listItemsPeriod { get; set; }

        public List<SelectListItem> listItemsReports { get; set; }
        // Define the list which you have to show in Drop down List
        public List<SelectListItem> listItemsreport()
        {
            List<SelectListItem> myList = new List<SelectListItem>();
            var data = new[]{
                 new SelectListItem{ Value="1",Text="דוח כמותי"},
                 new SelectListItem{ Value="2",Text="דוח כספי"},
                 new SelectListItem{ Value="3",Text="דוח עממידה ביעדים"},
                
             };
            myList = data.ToList();
            return myList;
        }

        public List<SelectListItem> listItemsperiod()
        {
            List<SelectListItem> myList = new List<SelectListItem>();
            var data = new[]{
                 new SelectListItem{ Value="1",Text="דוח יומי"},
                 new SelectListItem{ Value="2",Text="דוח חודשי"},
                 new SelectListItem{ Value="3",Text="דוח רבעוני"},

             };
            myList = data.ToList();
            return myList;
        }
    }

    }
