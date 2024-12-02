using Bll.Services;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ConcertController : ControllerBase
	{
		private readonly IConcertService concertService;

		public ConcertController(IConcertService concertService)
		{
			this.concertService = concertService;
		}

		[HttpGet]
		public async Task<IEnumerable<Concert>> Get() => await concertService.GetAllAsync();

		[HttpPost]
		public async Task<Concert> Post(Concert concert) => await concertService.CreateConcertAsync(concert);
	}
}
