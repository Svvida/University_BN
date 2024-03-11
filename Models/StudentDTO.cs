namespace University_BN.Models
{
    //Create DTO (Data Transfer Object) to choose which data should be returned to the API
    public record StudentDTO
    {
        public string Name { get; init; }
        public string Surname { get; init; }
        public DateOnly DateOfBirth { get; init; }
        public string Gender { get; init; }

    }
}
