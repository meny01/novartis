using MSContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace novartis2.Models.modelViews
{
    public class OrderModel
    {
        public List<ScHmo> hmo { get; set; }
        public List<ScAgent> Agent { get; set; }
        public List<Account> acount { get; set; }
        public List<ScPharmacy> scPharmacies { get; set; }
        public List<ScProduct> ScProducts { get; set; }
        public int clalit { get; set; }

    }
}
