using Bll.Services;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Mocks
{
	public class GenreService : IGenreService
	{
		public Task<Genre> CreateGenreAsync(Genre genre)
		{
			return Task.FromResult(genre);
		}

		public Task<IEnumerable<Genre>> GetAllAsync()
		{
			return Task.FromResult(new List<Genre>()
			{
				new Genre()
				{
					ID = "1",
					Name = "Genre 1"
				}
			}.AsEnumerable());
		}

		public Task<Genre> UpdateGenreAsync(Genre genre)
		{
			return Task.FromResult(genre);
		}
	}
}
