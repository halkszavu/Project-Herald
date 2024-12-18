﻿using Bll.Services;
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
			return Task.FromResult(period);
		}

		public Task<Piece> UpdatePieceAsync(Piece period)
		{
			return Task.FromResult(period);
		}
	}
}
