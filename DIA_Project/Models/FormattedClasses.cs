using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    public class FormattedClasses
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public int NumberOfStudent { get; set; }

        public FormattedClasses(Classes c)
        {
            ClassID = c.ID;
            ClassName = c.Name;
            using (SQL sql = SQL.MySql())
            {
                try
                {
                    object o = sql.users.GroupBy(x => x.ClassID).Select(x => new { classID = x.Key, userCount = x.Count() }).Single(x => x.classID == c.ID).userCount;
                    NumberOfStudent = (int)o;
                }
                catch
                {
                    NumberOfStudent = 0;
                }
                //NumberOfStudent = SQL.MySql().users.GroupBy(x => x.ClassID).Select(x => new { classID = x.Key, userCount = x.Count() }).Single(x => x.classID == c.ID).userCount;
            }
        }
    }
}
