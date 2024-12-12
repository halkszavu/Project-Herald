using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Piece
	{
		public string ID { get; set; }
		// Title of the piece
		[Required]
		public string Title { get; set; }
		// Composer of the piece
		[Required]
		public string Composer { get; set; }
		// Genre of the piece
		public string Genre { get; set; }
		// Duration of the piece ???
		// Description of the piece
		public string Description { get; set; }
	}
}
