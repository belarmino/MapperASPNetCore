namespace MapperASPNetCore
{
    internal class CityDTO
    {
        public int? CityId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CountryId { get; set; }
        public CountryDTO? Country { get; set; }
    }
}
