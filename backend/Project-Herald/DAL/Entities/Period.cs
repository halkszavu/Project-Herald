using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	/// <summary>
	/// Represents a period of music, such as: Baroque, Classical, Romantic, etc.
	/// </summary>
	public class Period
	{
		public string ID { get; set; }
		// Name of the era
		public string Name { get; set; }
		// Description of the era
		public string Description { get; set; }

		public ICollection<Composer> Composers { get; set; }
	}
}
