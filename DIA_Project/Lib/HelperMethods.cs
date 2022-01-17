using DIA_Project.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIA_Project.Models;

namespace DIA_Project.Lib
{
	[AttributeUsage(AttributeTargets.Property)]
	public class DGVNoDisplayAttribute : Attribute
	{
	}
	static class HelperMethods
	{
		public static DataGridViewRow GenerateDGVRow(object input)
		{
			DataGridViewRow dr = new DataGridViewRow();
			PropertyInfo[] properties = input.GetType().GetProperties();
			foreach (PropertyInfo property in properties)
			{
				if (Attribute.IsDefined(property, typeof(DGVNoDisplayAttribute)))
				{
					continue;
				}
				/*GyogyszerKiadas gyk = new GyogyszerKiadas();
				if (input.GetType() == gyk.GetType())
				{
					gyk = (GyogyszerKiadas)input;
					DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
					cell.Value = property.GetValue(input);
					if (property == gyk.GetType().GetProperties()[1])
					{
						using (SQL sql = SQL.MySql())
						{
							cell.Value = sql.paciensek.Single(a => a.ID == gyk.PaciensID).Nev;
						}
					}
					else if (property == gyk.GetType().GetProperties()[2])
					{
						using (SQL sql = SQL.MySql())
						{
							cell.Value = sql.gyogyszerek.Single(a => a.ID == gyk.GyogyszerID).Nev;
						}
					}
					dr.Cells.Add(cell);
				}
				else
				{*/
					DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
					cell.Value = property.GetValue(input);
					if (!cell.Value.ToString().Contains("$MYHASH$"))
					{
						dr.Cells.Add(cell);
					}
				//}
			}

			return dr;
		}

		public static int ToInt(this decimal input)
		{
			return Convert.ToInt32(input);
		}
	}
}
