using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
	public interface IConcertService
	{
		/// <summary>
		/// Inserts a concert into the database
		/// </summary>
		/// <param name="concert">The concert to be inserted</param>
		/// <returns>The inserted (finalized) concert record</returns>
		Task<Concert> CreateConcertAsync(Concert concert);

		Task<Concert> GetConcertAsync(string concertId);

		Task<IEnumerable<Concert>> GetConcertsByLocation(Location location);

		Task<IEnumerable<Concert>> GetConcertsBetweenDates(DateTime startDate, DateTime endDate);
	}
}
