using Bll.Services;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Mocks
{
	public class ComposerService : IComposerService
	{
		public Task<Composer> CreateComposerAsync(Composer period)
		{
			return Task.FromResult(new Composer()
			{
				ID = "mockComposer",
				Name = "Composer 1",
				DateOfBirth = new DateTime(1900, 1, 1),
				Period = new Period()
				{
					ID = "mockPeriod",
					Name = "Period 1" 
				},
				Description = "Description 1"
			});
		}

		public Task<Composer> UpdateComposerAsync(Composer period)
		{
			return Task.FromResult(period);
		}
	}
}
