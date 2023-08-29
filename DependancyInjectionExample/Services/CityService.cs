namespace Services;
using ServiceContracts;

public class CityService : ICitiesService
{

	public List<string> _cities
	{
		get;
		private set;
	}

	public CityService()
	{
		_cities = new List<string>()
		{
			"Jabalpur",
			"Mumbai",
			"Pune",
			"Banagalor"
		};
	}

	public List<string> GetCities()
	{
		return _cities;
	}

    public List<string> GetCountries()
    {
        throw new NotImplementedException();
    }
}

