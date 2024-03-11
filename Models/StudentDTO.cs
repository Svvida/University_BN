namespace University_BN.Models
{
    //Create DTO (Data Transfer Object) to choose which data should be returned to the API
    public record StudentDTO(string Name, string Surname, DateOnly DateOfBith, string Gender);
}
