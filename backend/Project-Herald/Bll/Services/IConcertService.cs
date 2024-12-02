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

		/// <summary>
		/// Gets a specific concert by its ID
		/// </summary>
		/// <param name="concertId">The ID of the concert</param>
		/// <returns>The full concert with the specified ID</returns>
		Task<Concert> GetConcertAsync(string concertId);

		/// <summary>
		/// Gets all concerts in a given location
		/// </summary>
		/// <param name="location">The location</param>
		/// <returns>A collection of concerts that take space in the specified location</returns>
		Task<IEnumerable<Concert>> GetConcertsByLocationAsync(Location location);

		/// <summary>
		/// Gets all concerts that take place between two dates
		/// </summary>
		/// <param name="startDate">The earliest date the concert can start.</param>
		/// <param name="endDate">The latest date the concert can start</param>
		/// <returns>A collection of concerts</returns>
		Task<IEnumerable<Concert>> GetConcertsBetweenDatesAsync(DateTime startDate, DateTime endDate);

		/// <summary>
		/// Gets all concerts that feature a specific orchestra
		/// </summary>
		/// <param name="orchestra">The specified orchestra</param>
		/// <returns>A collection of concerts</returns>
		Task<IEnumerable<Concert>> GetConcertsByOrchestraAsync(Orchestra orchestra);

		/// <summary>
		/// Gets all concerts that feature a specific genre
		/// </summary>
		/// <param name="genre">The specified genre</param>
		/// <returns>A collection of concerts</returns>
		Task<IEnumerable<Concert>> GetConcertsByGenreAsync(Genre genre);

		/// <summary>
		/// Gets all concerts that feature a given period (era)
		/// </summary>
		/// <param name="period">The specified period</param>
		/// <returns>A collection of concerts</returns>
		Task<IEnumerable<Concert>> GetConcertsByPeriodAsync(Period period);
		Task<IEnumerable<Concert>> GetAllAsync();
	}
}
