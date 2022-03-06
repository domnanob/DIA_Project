using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    public class FormattedPurchase
    {
        public string UserID { get; private set; }
        public string userName { get; private set; }
        public string Javl { get; private set; }
        public string HaziF { get; private set; }
        public string KesesI { get; private set; }
        public string Jeles { get; private set; }
        public FormattedPurchase(Purchase p)
        {
            UserID = p.UserID;
            userName = SQL.MySql().users.Single(x => x.Username == p.UserID).Name;
            Javl = (Convert.ToBoolean(p.JavL)) ? "Van" : "Nincs";
            HaziF = (Convert.ToBoolean(p.HaziF)) ? "Van" : "Nincs";
            KesesI = (Convert.ToBoolean(p.KesesI)) ? "Van" : "Nincs";
            Jeles = (Convert.ToBoolean(p.Jeles)) ? "Van" : "Nincs";
        }
    }
}
