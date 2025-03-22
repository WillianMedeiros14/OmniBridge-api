using System.ComponentModel.DataAnnotations;

public class CreateAddressDto
{
    [Required(ErrorMessage = "O campo de CEP é obrigatório.")]
    public string ZipCode { get; set; }

    public string Street { get; set; }
    public string Complement { get; set; }
    public string Neighborhood { get; set; }
    public string City { get; set; }
    public string State { get; set; }

    [Required(ErrorMessage = "O campo de número é obrigatório.")]
    public int Number { get; set; }
}