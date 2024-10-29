using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Concert
	{
		public string ID { get; set; }
		// Location of the concert
		public Location Location { get; set; }
		// Time of the concert (a DateTime of the location)
		public DateTime Time { get; set; }
		// Programme of the concert (a list of pieces)
		public ICollection<Piece> Programme { get; set; }
		// Performer of the concert (a list of individual musicians or orchestras)
		public ICollection<Orchestra> Orchestras { get; set; }
		// The conductor of the concert
		
	}
}
