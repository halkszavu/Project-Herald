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
			return Task.FromResult(new Composer());
		}

		public Task<Composer> UpdateComposerAsync(Composer period)
		{
			return Task.FromResult(new Composer());
		}
	}
}
