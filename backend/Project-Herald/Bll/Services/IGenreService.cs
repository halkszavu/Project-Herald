using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
	public interface IGenreService
	{
		public Task<IEnumerable<Genre>> GetAllAsync();
		public Task<Genre> CreateGenreAsync(Genre genre);
		public Task<Genre> UpdateGenreAsync(Genre genre);
	}
}
