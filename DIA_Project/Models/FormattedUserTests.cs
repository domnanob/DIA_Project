using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    public class FormattedUserTests
    {
        public string UserName { get; set; }

        public string Completed { get; set; }

        public string FinishDate { get; set; }

        public FormattedUserTests(UserTests ut)
        {
            UserName = SQL.MySql().users.Single(x => x.Username == ut.UserID).Name;
            Completed = (ut.Completed==1) ? "Leadva" : "Folyamatban";
            FinishDate = (ut.FinishDate==null)? "-" : ut.FinishDate.ToString();
        }
    }
}
