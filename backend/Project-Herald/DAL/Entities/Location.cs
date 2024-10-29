using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Location
	{
		public string ID { get; set; }
		// Name of the location
		[Required]
		public string Name { get; set; }
		// Address of the location
		[Required]
		public string Address { get; set; }
		// Description of the location
		public string Description { get; set; }
	}
}
