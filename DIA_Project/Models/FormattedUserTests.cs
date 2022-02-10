using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    public class FormattedUserTests
    {
        public string UserName { get; private set; }

        public string Completed { get; private set; }

        public string FinishDate { get; private set; }

        public FormattedUserTests(UserTests ut)
        {
            UserName = SQL.MySql().users.Single(x => x.Username == ut.UserID).Name;
            Completed = (ut.Completed==1) ? "Leadva" : "Folyamatban";
            FinishDate = (ut.FinishDate==null)? "-" : ut.FinishDate.ToString();
        }
    }
}
