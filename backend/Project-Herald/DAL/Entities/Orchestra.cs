using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Orchestra
	{
		public string ID { get; set; }
        // Name of the orchestra
        [Required]
        public string Name { get; set; }
        // Description of the orchestra
        public string Description { get; set; }
    }
}
