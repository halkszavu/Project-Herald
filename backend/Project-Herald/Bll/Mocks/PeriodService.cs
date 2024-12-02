using Bll.Services;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Mocks
{
	public class PeriodService : IPeriodService
	{
		public Task<Period> CreatePeriodAsync(Period period)
		{
			return Task.FromResult(period);
		}

		public Task<IEnumerable<Period>> GetAllAsync()
		{
			return Task.FromResult(new List<Period>()
			{
				new Period()
				{
					ID = "1",
					Name = "Period 1"
				}
			}.AsEnumerable());
		}

		public Task<Period> UpdatePeriodAsync(Period period)
		{
			return Task.FromResult(period);
		}
	}
}
