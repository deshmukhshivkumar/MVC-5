using System.ComponentModel.DataAnnotations;

namespace Mvc5AppV2.Models
{
    public  class Airport
    {
        [Key]
        public string AirportCode { get; set; }
        public string AirportName { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string StateCode { get; set; }
        public string CountryCode { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public string TimeZoneCode { get; set; }
        public bool IsDomestic { get; set; }
        public int Preference { get; set; }
    }
}
