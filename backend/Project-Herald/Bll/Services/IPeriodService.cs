using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
	public interface IPeriodService
	{
		public Task<IEnumerable<Period>> GetAllAsync();
		public Task<Period> CreatePeriod(Period period);
		public Task<Period> UpdatePeriod(Period period);
	}
}
