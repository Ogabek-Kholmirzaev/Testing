using System.ComponentModel.DataAnnotations;

namespace MoqApi.Dto;

public class UserDto
{
    [Required]
    public string? Name { get; set; }
}