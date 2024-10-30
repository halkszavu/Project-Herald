using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
	public interface ILocationService
	{
		/// <summary>
		/// Inserts a location into the database
		/// </summary>
		/// <param name="location">The location to be inserted</param>
		/// <returns>The inserted (finalized) location record</returns>
		Task<Location> CreateLocationAsync(Location location);
		 										
		Task<Location> GetLocationAsync(string locationId);

		Task<IEnumerable<Location>> GetLocationsByName(string name);
	}
}
