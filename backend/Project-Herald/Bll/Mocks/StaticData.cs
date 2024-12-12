using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Mocks
{
	/// <summary>
	/// A container for the data to be returned by the mock services
	/// </summary>
	public static class StaticData
	{
		static List<Concert> concerts = new()
		{
			new Concert()
			{
				ID= "karacsonyi",
				Name = "Karácsonyi koncert",
				Date = new DateTime(2024, 12, 16),
				Programme = new List<Piece>
				{
					new Piece { ID = "brahms_academic", Title = "Academic ouverture", Composer = "Johannes Brahms" },
					new Piece { ID = "nagy_polka", Title = "Auf einem Ball-polka", Composer = "Nagy Zsombor" },
					new Piece { ID = "elgar_nimrod", Title = "Enigma Variations: Nimrod", Composer = "Edward Elgar" },
					new Piece { ID = "elgar_poms&circumstance", Title = "Pomp and Circumstance March No. 1", Composer = "Edward Elgar" },
					new Piece { ID = "toth_kantata", Title = "Karácsonyi kantáta", Composer = "Tóth Péter" },
					new Piece { ID = "tschaikowsky_sleeping_waltz", Title = "Sleeping Beauty Waltz", Composer = "Pjotr Iljics Tschaikowsky" },
					new Piece { ID = "tschaikowsky_swanlake_suite", Title = "Swan Lake Suite", Composer = "Pjotr Iljics Tschaikowsky" },
					new Piece { ID = "tschaikowsky_nutcracker_suite", Title = "The Nutcracker Suite", Composer = "Pjotr Iljics Tschaikowsky" },
				}
			},
		};

		public static IEnumerable<Concert> GetConcerts()
		{
			return concerts;
		}

		public static Concert GetConcert(string concertId)
		{
			return concerts.FirstOrDefault(c => c.ID == concertId);
		}

		public static Concert CreateConcert(Concert concert)
		{
			if(concerts.Any(c => c.ID == concert.ID))
			{
				concert.ID = $"{concert.ID}_1";
			}
			concerts.Add(concert);
			return concert;
		}
	}
}
