using System;
using System.Linq;

namespace DIA_Project.Models
{
    public class FormattedTest
    {
        public int TestID { get; private set; }
        public string TestName { get; private set; }
        public string Subject { get; private set; }
        public string Class { get; private set; }
        public DateTime ExpireDate { get; private set; }

        public FormattedTest(Test t)
        {
            using (SQL sql = SQL.MySql())
            {
                TestID = t.ID;
                TestName = t.Name;
                Subject = sql.subjects.Single(x => x.ID == t.SubjectID).Name;
                Class = sql.classes.Single(x => x.ID == t.ClassID).Name;
                ExpireDate = t.FinishDate;
            }
        }

    }
}
