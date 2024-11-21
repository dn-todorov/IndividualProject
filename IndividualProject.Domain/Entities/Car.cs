namespace IndividualProject.Domain.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        public string CarBrand { get; set; }
        public string RegistrationPlate { get; set; }
        public ICollection<Track> Tracks { get; set; } = new List<Track>();
    }
}
