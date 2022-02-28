using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    public class FormattedTokens
    {
        public string Token { get; set; }

        public string Class { get; set; }

        public FormattedTokens(RegistrationTokens t)
        { 
            Token = t.Token;
            Class = SQL.MySql().classes.Single(x => x.ID == t.ClassID).Name;
        }
    }
}
