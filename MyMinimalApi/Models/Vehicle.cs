namespace MyMinimalApi.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public DateTime StartProduction { get; set; }
        public string FuelType { get; set; }
    }
}
