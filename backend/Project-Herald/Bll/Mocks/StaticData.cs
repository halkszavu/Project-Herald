using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Mocks
{
	/// <summary>
	/// A container for the data to be returned by the mock services
	/// </summary>
	public class StaticData
	{
		public static StaticData Instance { get; } = new StaticData();

		private List<Concert> concerts;
		private StaticData()
		{
			ICollection<Piece> fonyodi = new List<Piece>()
			{
				new Piece { ID="Rossini_BarberOvet", Title="The Barber of Seville Overture", Composer="Gioachino Rossini" },
				new Piece { ID="Strauss_BlueDanube", Title="The Blue Danube", Composer="Johann Strauss II" },
				new Piece { ID="Brahms_HungarianDance5", Title="Hungarian Dance No. 5", Composer="Johannes Brahms" },
				new Piece { ID="Liszt_RakocziMarch", Title="Rákóczi March", Composer="Franz Liszt" },
				new Piece { ID="Massenet_Meditation", Title="Meditation from Thaïs", Composer="Jules Massenet" },
				new Piece { ID="Williams_RaidersMarch", Title="Raiders March from Indiana Jones", Composer="John Williams" },
				new Piece { ID="Bartok_RomanianFolk", Title="Romanian Folk Dances", Composer="Béla Bartók" },
				new Piece { ID="Strauss_RadetzkyMarch", Title="Radetzky March", Composer="Johann Strauss I" },
				new Piece { ID="Tchaikovsky_1812Overture", Title="1812 Overture (Closing Section)", Composer="Pyotr Ilyich Tchaikovsky" }
			};

			concerts = new()
			{
				new Concert()
				{
					ID = "karacsonyi", Name = "Karácsonyi koncert", Date = new DateTime(2024, 12, 16),
					Programme = new List<Piece>
					{
						new Piece { ID = "brahms_academic", Title = "Academic ouverture", Composer = "Johannes Brahms" },
						new Piece { ID = "nagy_polka", Title = "Auf einem Ball-polka", Composer = "Nagy Zsombor" },
						new Piece { ID = "elgar_nimrod", Title = "Enigma Variations: Nimrod", Composer = "Edward Elgar" },
						new Piece { ID = "elgar_poms&circumstance", Title = "Pomp and Circumstance March No. 1", Composer = "Edward Elgar" },
						new Piece { ID = "toth_kantata", Title = "Karácsonyi kantáta", Composer = "Tóth Péter" },
						new Piece { ID = "tschaikowsky_sleeping_waltz", Title = "Sleeping Beauty Waltz", Composer = "Pjotr Iljics Tchaikovsky" },
						new Piece { ID = "tschaikowsky_swanlake_suite", Title = "Swan Lake Suite", Composer = "Pjotr Iljics Tchaikovsky" },
						new Piece { ID = "tschaikowsky_nutcracker_suite", Title = "The Nutcracker Suite", Composer = "Pjotr Iljics Tchaikovsky" },
					}
				},
				new Concert()
				{
					ID = "tavaszi", Name = "Tavaszi koncert", Date = new DateTime(2025, 4, 2),
					Programme = new List<Piece>()
					{
						new Piece { ID = "ouverture_don_giovanni", Title = "Don Giovanni Overture", Composer = "Wolfgang Amadeus Mozart" },
						new Piece { ID = "shostakovich_concerto", Title = "Piano Concerto No. 2", Composer = "Dmitri Shostakovich" },
					}
				},
				new Concert() { ID = "fonyod1", Name = "Fonyódi koncert 1", Date = new DateTime(2025, 7, 27), Programme = fonyodi },
				new Concert() { ID = "fonyod2", Name = "Fonyódi koncert 2", Date = new DateTime(2025, 7, 28), Programme = fonyodi },
				new Concert() { ID = "fonyod3", Name = "Fonyódi koncert 3", Date = new DateTime(2025, 7, 29), Programme = fonyodi },
				new Concert() { ID = "fonyod4", Name = "Fonyódi koncert 4", Date = new DateTime(2025, 7, 30), Programme = fonyodi },
				new Concert() { ID = "fonyod5", Name = "Fonyódi koncert 5", Date = new DateTime(2025, 7, 31), Programme = fonyodi },
				new Concert() { ID = "fonyod6", Name = "Fonyódi koncert 6", Date = new DateTime(2025, 8, 1), Programme = fonyodi },
				new Concert() { ID = "fonyod7", Name = "Fonyódi koncert 7", Date = new DateTime(2025, 8, 2), Programme = fonyodi },
				new Concert() { ID = "fonyod8", Name = "Fonyódi koncert 8", Date = new DateTime(2025, 8, 3), Programme = fonyodi },
				new Concert() { ID = "fonyod9", Name = "Fonyódi koncert 9", Date = new DateTime(2025, 8, 4), Programme = fonyodi },
				new Concert() {
					ID = "filmzene", Name = "Filmzene koncert", Date = new DateTime(2024, 12, 29),
					Programme = new List<Piece>()
					{
						new Piece { ID="Bradley_TomAndJerry", Title="Tom and Jerry", Composer="Bradley" },
						new Piece { ID="Menken_Aladdin", Title="Aladdin", Composer="Alan Menken" },
						new Piece { ID="LopezKrogstadt_Frozen", Title="Music from Frozen", Composer="Lopez-Krogstadt" },
						new Piece { ID="MenkenMortimer_Pocahontas", Title="Pocahontas", Composer="Menken-Mortimer" },
						new Piece { ID="RadoRagniMacDermotNaulais_Hair", Title="Hair", Composer="RadoRagniMacDermot-Naulais" },
						new Piece { ID="EbbKanderParson_Cabaret", Title="Cabaret", Composer="Fred Ebb/John Kander-Ted Parson" },
						new Piece { ID="KanderEbbRicketts_Chicago", Title="Chicago", Composer="Kander-Ebb-Ricketts" },
						new Piece { ID="RozsaMortimer_QuoVadis", Title="Quo Vadis", Composer="Rózsa Miklós-Mortimer" },
						new Piece { ID="Zimmer_Gladiator", Title="Gladiátor", Composer="Hans Zimmer" },
						new Piece { ID="Kamen_RobinHood", Title="Robin Hood – tolvajok fejedelme", Composer="M. Kamen" },
						new Piece { ID="SilvestriMortimer_ForrestGump", Title="Forrest Gump", Composer="Silvestri-Mortimer" },
						new Piece { ID="SchifrinCuster_MissionImpossible", Title="Mission Impossible Theme", Composer="Schifrin-Custer" },
						new Piece { ID="Williams_EastwickWitches", Title="Eastwicki boszorkányok – Devil’s Dance", Composer="J. Williams" },
						new Piece { ID="Williams_Hook", Title="Hook - The Flight to Neverland", Composer="J. Williams" }
					}
				}
			};
		}



		public IEnumerable<Concert> GetConcerts()
		{
			return concerts;
		}

		public Concert GetConcert(string concertId)
		{
			return concerts.FirstOrDefault(c => c.ID == concertId);
		}

		public Concert CreateConcert(Concert concert)
		{
			if(concerts.Any(c => c.ID == concert.ID))
			{
				concert.ID = $"{concert.ID}_1";
			}
			concerts.Add(concert);
			return concert;
		}

		public Concert UpdateConcert(Concert concert)
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
