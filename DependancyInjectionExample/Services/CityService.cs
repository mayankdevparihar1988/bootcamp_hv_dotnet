namespace Services;
using ServiceContracts;

public class CityService : ICitiesService
{

	public List<string> _cities
	{
		get;
		private set;
	}

    private Guid _serviceInstanceId;

    public Guid ServiceInstanceId()
    {
       
            return _serviceInstanceId;
        
    }

    public CityService()
	{

        _serviceInstanceId = Guid.NewGuid();

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

