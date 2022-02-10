using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    public class FormattedTestsForUsers
    {
        public string TestName { get; private set; }
        public string Subject { get; private set; }
        public DateTime ExpireDate { get; private set; }

        public string Score { get; private set; }
        public FormattedTestsForUsers(Tests t)
        {
            using (SQL sql = SQL.MySql())
            {
                TestName = t.Name;
                Subject = sql.subjects.Single(x => x.ID == t.SubjectID).Name;
                ExpireDate = t.FinishDate;
                Score = "100/";
            }
        }
    }
}
