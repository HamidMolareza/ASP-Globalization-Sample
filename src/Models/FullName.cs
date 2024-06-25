using System.ComponentModel.DataAnnotations;

namespace Globalization.Models;

public class FullName {
    [Display(Name = "Name")]
    [MaxLength(30, ErrorMessage = "Maximum length for {0} is {1}")]
    public string? Name { get; set; }

    [Display(Name = "Family")]
    [Required(ErrorMessage = "{0} is required.")]
    [MinLength(3, ErrorMessage = "Minimum length for {0} is {1}")]
    [MaxLength(30, ErrorMessage = "Maximum length for {0} is {1}")]
    public string Family { get; set; } = default!;

    public override string ToString() {
        return Name is null
            ? $"{Family}"
            : $"{Name} {Family}";
    }
}