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
		public Task<Orchestra> CreatePeriod(Orchestra period);
		public Task<Orchestra> UpdatePeriod(Orchestra period);
	}
}
