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
        public string State { get; private set; }
        public FormattedTestsForUsers(Tests t, Users u)
        {
            using (SQL sql = SQL.MySql())
            {
                TestName = t.Name;
                Subject = sql.subjects.Single(x => x.ID == t.SubjectID).Name;
                ExpireDate = t.FinishDate;
                Score = "100/";
                UserTests ut = sql.userTests.Single(x => x.UserID == u.Username && x.TestID == t.ID);
                if (ut.Completed == 1)
                {
                    if (ut.CorrectState == 1)
                    {
                        State = "Kijavítva!";
                        //Score += ;
                    }
                    else
                    {
                        State = "Javítás alatt!";
                    }
                }
                else 
                {
                    State = "Nincs leadva!";
                }
            }
        }
    }
}
