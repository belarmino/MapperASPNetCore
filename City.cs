namespace MapperASPNetCore
{
    internal class City
    {
        public int? CityId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CountryId { get; set; }
        public Country? Country { get; set; }
    }
}
