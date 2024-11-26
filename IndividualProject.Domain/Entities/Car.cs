namespace IndividualProject.Domain.Entities
{
    public class Car : BaseEntity
    {
        public string CarBrand { get; set; }
        public string RegistrationPlate { get; set; }
        public Employee Employee { get; set; }
    }
}
