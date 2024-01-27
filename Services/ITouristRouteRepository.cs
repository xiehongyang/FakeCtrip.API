using System;
using System.Collections.Generic;
using FakeCtrip.API.Models;

namespace FakeCtrip.API.Services
{
	public interface ITouristRouteRepository
	{
		IEnumerable<TouristRoute> GetTouristRoutes();
		TouristRoute GetTouristRoute(Guid touristRouteId);
	}
}

