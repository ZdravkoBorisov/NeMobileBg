namespace NeMobileBg.Data.Models
{
    public class Car : Vehicle
    {
        public bool Convertible { get; set; }

        public int Seats { get; set; } = default!;

        public string Category { get; set; } = default!;

        public int Doors { get; set; }
    }
}
