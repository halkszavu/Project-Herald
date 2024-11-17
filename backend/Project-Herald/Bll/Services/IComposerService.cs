using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
	public interface IComposerService
	{
		public Task<Composer> CreatePeriodAsync(Composer period);
		public Task<Composer> UpdatePeriodAsync(Composer period);
	}
}
