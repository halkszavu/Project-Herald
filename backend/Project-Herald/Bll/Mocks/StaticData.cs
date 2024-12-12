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
			new Concert { ID = "2", Name = "Tavaszi koncert", Date = new DateTime(2025, 4, 2), Programme = new List<Piece>() },
			new Concert { ID = "3", Name = "Fonyódi koncert 1", Date = new DateTime(2025, 7, 27), Programme = new List<Piece>() },
			new Concert { ID = "4", Name = "Fonyódi koncert 2", Date = new DateTime(2025, 7, 28), Programme = new List<Piece>() },
			new Concert { ID = "5", Name = "Fonyódi koncert 3", Date = new DateTime(2025, 7, 29), Programme = new List<Piece>() },
			new Concert { ID = "6", Name = "Fonyódi koncert 4", Date = new DateTime(2025, 7, 30), Programme = new List<Piece>() },
			new Concert { ID = "7", Name = "Fonyódi koncert 5", Date = new DateTime(2025, 7, 31), Programme = new List<Piece>() },
			new Concert { ID = "8", Name = "Fonyódi koncert 6", Date = new DateTime(2025, 8, 1), Programme = new List<Piece>() },
			new Concert { ID = "9", Name = "Fonyódi koncert 7", Date = new DateTime(2025, 8, 2), Programme = new List<Piece>() },
			new Concert { ID = "10", Name = "Fonyódi koncert 8", Date = new DateTime(2025, 8, 3), Programme = new List<Piece>() },
			new Concert { ID = "11", Name = "Fonyódi koncert 9", Date = new DateTime(2025, 8, 4), Programme = new List<Piece>() },
			new Concert { ID = "12", Name = "Fonyódi koncert 10", Date = new DateTime(2025, 8, 5), Programme = new List<Piece>() },
			new Concert { ID = "13", Name = "Fonyódi koncert 11", Date = new DateTime(2025, 8, 6), Programme = new List<Piece>() },
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

		public static Concert UpdateConcert(Concert concert)
		{
			var existing = concerts.FirstOrDefault(c => c.ID == concert.ID);
			if(existing != null)
			{
				existing.Name = concert.Name;
				existing.Date = concert.Date;
				existing.Programme = concert.Programme;
			}
			else
			{
				existing = CreateConcert(concert);
			}
			return existing;
		}
	}
}
