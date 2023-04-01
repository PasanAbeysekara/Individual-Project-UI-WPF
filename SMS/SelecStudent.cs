using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
	public class SelecStudent
	{
		[Key]
		public int Idx { get; set; }
		public List<Student> Stud { get; set; }

		//public SelecStudent(Student stud)
		//{
		//	Random r = new Random();
		//	Idx = r.Next(0, 10000);
		//	Studs.Add(stud);
		//}
	}
}
