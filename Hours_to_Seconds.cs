using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Solutions
{
	public class Hours_to_Seconds // Replace with name: Program
	{
		public static int HowManySeconds(int hours)
		{
			int seconds = 60;
			int minutes = 60;
			return hours * minutes * seconds;
		}
	}
}
