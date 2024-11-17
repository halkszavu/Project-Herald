﻿using DAL.Entities;
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
		public Task<Genre> CreatePeriod(Genre period);
		public Task<Genre> UpdatePeriod(Genre period);
	}
}
