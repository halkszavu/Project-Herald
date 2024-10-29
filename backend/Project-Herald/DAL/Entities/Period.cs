using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Period
	{
		public string ID { get; set; }
		// Name of the era
		[Required]
		public string Name { get; set; }
		// Description of the era
		public string Description { get; set; }

        public ICollection<Composer> Composers { get; set; }
    }
}
