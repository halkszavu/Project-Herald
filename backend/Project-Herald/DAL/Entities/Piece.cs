using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Piece
	{
		public string ID { get; set; }
		// Title of the piece
		public string Title { get; set; }
		// Composer of the piece
		public Composer Composer { get; set; }
		// Genre of the piece
		public Genre Genre { get; set; }
		// Duration of the piece ???
		// Description of the piece
		public string Description { get; set; }
	}
}
