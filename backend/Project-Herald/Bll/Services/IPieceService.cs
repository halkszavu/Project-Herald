using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
	public interface IPieceService
	{
		public Task<Piece> CreatePeriod(Piece period);
		public Task<Piece> UpdatePeriod(Piece period);
	}
}
