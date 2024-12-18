﻿using Bll.Services;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Mocks
{
	public class ConcertService : IConcertService
	{
		public Task<Concert> CreateConcertAsync(Concert concert)
		{
			return Task.FromResult(concert);
		}

		public Task<IEnumerable<Concert>> GetAllAsync()
		{
			return Task.FromResult(new List<Concert>()
			{
				new Concert()
				{
					ID = "1",
					Location = new Location()
					{
						ID = "1",
						Name = "Location 1"
					},
					Orchestras = [
						new Orchestra()
						{
							ID = "1",
							Name = "Orchestra 1"
						}],
					Time = DateTime.Now,
				}
			}.AsEnumerable());
		}

		public Task<Concert> GetConcertAsync(string concertId)
		{
			return Task.FromResult(new Concert()
			{
				ID = concertId,
				Location = new Location()
				{
					ID = "1",
					Name = "Location 1"
				},
				Orchestras = [
					new Orchestra()
					{
						ID = "1",
						Name = "Orchestra 1"
					}],
				Time = DateTime.Now,
			});
		}

		public Task<IEnumerable<Concert>> GetConcertsBetweenDatesAsync(DateTime startDate, DateTime endDate)
		{
			return Task.FromResult(new List<Concert>()
			{
				new Concert()
				{
					ID = "1",
					Location = new Location()
					{
						ID = "1",
						Name = "Location 1"
					},
					Orchestras = [
						new Orchestra()
						{
							ID = "1",
							Name = "Orchestra 1"
						}],
					Time = DateTime.Now,
				}
			}.AsEnumerable());
		}

		public Task<IEnumerable<Concert>> GetConcertsByGenreAsync(Genre genre)
		{
			return Task.FromResult(new List<Concert>()
			{
				new Concert()
				{
					ID = "1",
					Location = new Location()
					{
						ID = "1",
						Name = "Location 1"
					},
					Orchestras = [
						new Orchestra()
						{
							ID = "1",
							Name = "Orchestra 1"
						}],
					Time = DateTime.Now,
				}
			}.AsEnumerable());
		}

		public Task<IEnumerable<Concert>> GetConcertsByLocationAsync(Location location)
		{
			return Task.FromResult(new List<Concert>()
			{
				new Concert()
				{
					ID = "1",
					Location = location,
					Orchestras = [
						new Orchestra()
						{
							ID = "1",
							Name = "Orchestra 1"
						}],
					Time = DateTime.Now,
				}
			}.AsEnumerable()) ;
		}

		public Task<IEnumerable<Concert>> GetConcertsByOrchestraAsync(Orchestra orchestra)
		{
			return Task.FromResult(new List<Concert>()
			{
				new Concert()
				{
					ID = "1",
					Location = new Location()
					{
						ID = "1",
						Name = "Location 1"
					},
					Orchestras = [
						orchestra],
					Time = DateTime.Now,
				}
			}.AsEnumerable());
		}

		public Task<IEnumerable<Concert>> GetConcertsByPeriodAsync(Period period)
		{
			return Task.FromResult(new List<Concert>()
			{
				new Concert()
				{
					ID = "1",
					Location = new Location()
					{
						ID = "1",
						Name = "Location 1"
					},
					Orchestras = [
						new Orchestra()
						{
							ID = "1",
							Name = "Orchestra 1"
						}],
					Time = DateTime.Now,
				}
			}.AsEnumerable());
		}
	}
}
