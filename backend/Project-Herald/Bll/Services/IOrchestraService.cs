using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
	public interface IOrchestraService
	{
		public Task<Orchestra> CreateOrchestraAsync(Orchestra period);
		public Task<Orchestra> UpdateOrchestraAsync(Orchestra period);
	}
}
