using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    public class FormattedTestsForUser
    {
        public int TestID { get; private set; }
        public string TestName { get; private set; }
        public string Subject { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public string Score { get; private set; }
        public string State { get; private set; }
        public FormattedTestsForUser(Test t, User u)
        {
            using (SQL sql = SQL.MySql())
            {
                TestID = t.ID;
                TestName = t.Name;
                Subject = sql.subjects.Single(x => x.ID == t.SubjectID).Name;
                ExpireDate = t.FinishDate;
                Score = t.MaxPoints+"/";
                UserTest ut = sql.userTests.Single(x => x.UserID == u.Username && x.TestID == t.ID);
                if (ut.Completed == 1)
                {
                    if (ut.CorrectState == 1)
                    {
                        State = "Kijavítva!";
                        Score += ut.Points;
                    }
                    else
                    {
                        State = "Javítás alatt!";
                        Score += "?";
                    }
                }
                else 
                {
                    State = "Nincs leadva!";
                    Score += "-";
                }
            }
        }
    }
}
