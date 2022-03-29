using System.Linq;

namespace DIA_Project.Models
{
    public class FormattedUserTest
    {
        public string UserID { get; set; }
        public string UserName { get; private set; }

        public string FinishDate { get; private set; }

        public string State { get; private set; }

        public FormattedUserTest(UserTest ut)
        {
            UserID = ut.UserID;
            UserName = SQL.MySql().users.Single(x => x.Username == ut.UserID).Name;
            FinishDate = (ut.FinishDate == null) ? "-" : ut.FinishDate.ToString();
            if (ut.FinishDate > SQL.MySql().tests.Single(x => x.ID == ut.TestID).FinishDate)
            {
                FinishDate += " (Késve)";
            }
            if (ut.CorrectState == 1)
            {
                State = "Kijavítva!";
            }
            else
            {
                if (ut.Completed == 1)
                {
                    State = "Javításra vár!";
                }
                else
                {
                    State = "Hiányzik!";
                }
            }
        }
    }
}
