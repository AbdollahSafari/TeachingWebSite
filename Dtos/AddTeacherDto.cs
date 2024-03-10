using FluentValidation;
using TeachingWebSite.Contracts;

namespace TeachingWebSite.Dtos;

public class AddTeacherDto
{
    public Name Name { get; set; }
    public int ClassPricePerHour { get; set; }
}

public class AddProductDtoValidator : AbstractValidator<AddTeacherDto>
{
    public AddProductDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotNull()
            .NotEmpty()
            .WithMessage("Please enter valid name!");
    }
}