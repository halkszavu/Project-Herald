using Bll.Services;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Mocks
{
	public class PieceService : IPieceService
	{
		public Task<Piece> CreatePieceAsync(Piece period)
		{
			throw new NotImplementedException();
		}

		public Task<Piece> UpdatePieceAsync(Piece period)
		{
			throw new NotImplementedException();
		}
	}
}
