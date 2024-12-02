using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Composer
	{
		public string ID { get; set; }
        // Name of the composer
        [Required]
        public string Name { get; set; }
        // Date of birth of the composer
        public DateTime DateOfBirth { get; set; }
        // Period of the composer (e.g. Baroque, Classical, Romantic, etc.)
        public Period Period { get; set; }
        // Description of the composer
        public string Description { get; set; }
    }
}
