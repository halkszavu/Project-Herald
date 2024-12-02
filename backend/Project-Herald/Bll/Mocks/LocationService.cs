using Bll.Services;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Mocks
{
	public class LocationService : ILocationService
	{
		public Task<Location> CreateLocationAsync(Location location)
		{
			return Task.FromResult(location);
		}

		public Task<Location> GetLocationAsync(string locationId)
		{
			return Task.FromResult(new Location()
			{
				ID = locationId,
				Name = "Location 1"
			});
		}

		public Task<IEnumerable<Location>> GetLocationsByNameAsync(string name)
		{
			return Task.FromResult(new List<Location>()
			{
				new Location()
				{
					ID = "1",
					Name = name
				}
			}.AsEnumerable());
		}
	}
}
