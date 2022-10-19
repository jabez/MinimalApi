namespace MyMinimalApi.Models
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public DateTime StartProduction { get; set; }
        public string FuelType { get; set; }
        public Brand Brand { get; set; }
    }
}
