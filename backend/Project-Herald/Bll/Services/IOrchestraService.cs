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
		public Task<Orchestra> CreatePeriodAsync(Orchestra period);
		public Task<Orchestra> UpdatePeriodAsync(Orchestra period);
	}
}
