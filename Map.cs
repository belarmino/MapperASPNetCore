using AutoMapper;
using BenchmarkDotNet.Attributes;
using Mapster;

namespace MapperASPNetCore
{
    [MemoryDiagnoser]
    public class Map
    {
        [Benchmark]
        public void Mapster() {
            CountryDTO country = new()
            {
                CountryId = 1,
                Name = "Cape Verde"
            };

            CityDTO city = new()
            {
                CityId = 1,
                Name = "Tarrafal",
                CountryId = 1,
                Country = country
            };
            City _city = city.Adapt<City>();
        }
        [Benchmark]
        public void AutoMapper()
        {
            IMapper mapper = new MapperConfiguration(cfg => { cfg.CreateMap<CountryDTO, Country>(); cfg.CreateMap<CityDTO, City>(); }).CreateMapper();

            CountryDTO country = new()
            {
                CountryId = 1,
                Name = "Cape Verde"
            };

            CityDTO city = new()
            {
                CityId = 1,
                Name = "Tarrafal",
                CountryId = 1,
                Country = country
            };
            City _city = mapper.Map<City>(city);
        }
    }
}
