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
        RuleFor(x => x.Name.FirstName)
            .NotNull()
            .NotEmpty()
            .MinimumLength(4)
            .WithMessage("Please enter valid first name!");
        RuleFor(x => x.Name.LastName)
            .NotNull()
            .NotEmpty()
            .MinimumLength(4)
            .WithMessage("Please enter valid last name!");
    }
}