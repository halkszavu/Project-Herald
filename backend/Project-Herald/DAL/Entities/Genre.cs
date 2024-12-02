using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	/// <summary>
	/// Represents a genre of music, such as: opera, symphony, concerto, etc.
	/// </summary>
	public class Genre
	{
		public string ID { get; set; }
		// Name of the genre
		public string Name { get; set; }
		// Description of the genre
		public string Description { get; set; }

		public ICollection<Piece> Pieces { get; set; }
	}
}
