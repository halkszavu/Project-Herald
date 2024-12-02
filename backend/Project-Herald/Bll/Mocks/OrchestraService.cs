using Bll.Services;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Mocks
{
	public class OrchestraService : IOrchestraService
	{
		public Task<Orchestra> CreateOrchestraAsync(Orchestra orchestra)
		{
			return Task.FromResult(orchestra);
		}

		public Task<Orchestra> UpdateOrchestraAsync(Orchestra orchestra)
		{
			return Task.FromResult(orchestra);
		}
	}
}
