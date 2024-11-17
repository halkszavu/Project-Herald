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
		public Task<Period> CreatePeriodAsync(Period period);
		public Task<Period> UpdatePeriodAsync(Period period);
	}
}
