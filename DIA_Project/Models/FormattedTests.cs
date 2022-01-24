using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    public class FormattedTests
    {
        public string TestName { get; set; }
        public string Subject { get; set; }
        public string Class { get; set; }
        public DateTime ExpireDate { get; set; }

        public FormattedTests(Tests t)
        {
            using (SQL sql = SQL.MySql())
            {
                TestName = t.Name;
                Subject = sql.subjects.Single(x => x.ID == t.SubjectID).Name;
                Class = sql.classes.Single(x => x.ID == t.ClassID).Name;
                ExpireDate = t.FinishDate;
            }
        }

    }
}
