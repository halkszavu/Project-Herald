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
		public Task<Piece> CreatePieceAsync(Piece piece);
		public Task<Piece> UpdatePieceAsync(Piece piece);
	}
}
