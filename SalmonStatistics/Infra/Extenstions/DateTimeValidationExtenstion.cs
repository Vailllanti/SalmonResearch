using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Infra.Extenstions
{
	public class DateTimeAttribute : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			var date = value.ToString();
			bool isDateTime = DateTime.TryParse(date, out DateTime dateTime);
			return isDateTime;
		}
	}
}
