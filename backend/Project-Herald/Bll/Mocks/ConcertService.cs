using Bll.Services;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Mocks
{
	public class ConcertService : IConcertService
	{
		public Task<Concert> CreateConcertAsync(Concert concert)
		{
			return Task.FromResult(concert);
		}

		public Task<IEnumerable<Concert>> GetAllAsync()
		{
			return Task.FromResult(new List<Concert>()
			{
				new Concert()
				{
					ID = "1",					
					Date = DateTime.Now,
				}
			}.AsEnumerable());
		}

		public Task<Concert> GetConcertAsync(string concertId)
		{
			return Task.FromResult(new Concert()
			{
				ID = concertId,
				Date = DateTime.Now,
			});
		}

		public Task<IEnumerable<Concert>> GetConcertsBetweenDatesAsync(DateTime startDate, DateTime endDate)
		{
			return Task.FromResult(new List<Concert>()
			{
				new Concert()
				{
					ID = "1",
					Date = DateTime.Now,
				}
			}.AsEnumerable());
		}

		public Task<IEnumerable<Concert>> GetConcertsByGenreAsync(Genre genre)
		{
			return Task.FromResult(new List<Concert>()
			{
				new Concert()
				{
					ID = "1",
					Date = DateTime.Now,
				}
			}.AsEnumerable());
		}

		public Task<IEnumerable<Concert>> GetConcertsByLocationAsync(Location location)
		{
			return Task.FromResult(new List<Concert>()
			{
				new Concert()
				{
					ID = "1",
					Date = DateTime.Now,
				}
			}.AsEnumerable()) ;
		}

		public Task<IEnumerable<Concert>> GetConcertsByOrchestraAsync(Orchestra orchestra)
		{
			return Task.FromResult(new List<Concert>()
			{
				new Concert()
				{
					ID = "1",
					Date = DateTime.Now,
				}
			}.AsEnumerable());
		}

		public Task<IEnumerable<Concert>> GetConcertsByPeriodAsync(Period period)
		{
			return Task.FromResult(new List<Concert>()
			{
				new Concert()
				{
					ID = "1",
					Date = DateTime.Now,
				}
			}.AsEnumerable());
		}
	}
}
