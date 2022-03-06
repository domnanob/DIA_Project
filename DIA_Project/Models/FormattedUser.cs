using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    public class FormattedUser
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Enabled { get; set; }
        public DateTime LastLogon { get; set; }
        public int Money { get; set; }
        public string Class { get; set; }
        public string Email { get; set; }

        public FormattedUser(User u)
        {
            Username = u.Username;
            Name = u.Name;
            Enabled = (u.Enable == 1) ? "Aktív" : "Tiltott";
            LastLogon = u.LastLogon;
            Money = u.Money;
            Class = SQL.MySql().classes.Single(x => x.ID == u.ClassID).Name;
            Email = u.Email;
        }
    }
}
