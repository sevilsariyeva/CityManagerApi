using CityManagerApi.Models;

namespace CityManagerApi.Dtos
{
    public class CityForDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CityImage> CityImages { get; set; }
    }
}
