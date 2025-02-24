using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Personal
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    public string Job { get; set; } = string.Empty;

    public string Bio { get; set; } = string.Empty; // Kısa biyografi

    public string AboutMe { get; set; } = string.Empty; // Detaylı "Hakkımda" kısmı

    public string ProfilePic { get; set; } = string.Empty; // Profil fotoğrafı URL'si

    public string Website { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public string LinkedInUrl { get; set; } = string.Empty;

    public string InstagramUrl { get; set; } = string.Empty;

    public string GithubUrl { get; set; } = string.Empty;

    public string XUrl { get; set; } = string.Empty;

}
