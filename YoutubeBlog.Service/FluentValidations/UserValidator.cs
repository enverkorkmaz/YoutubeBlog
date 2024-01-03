using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Service.FluentValidations
{
    public class UserValidator :AbstractValidator<AppUser>
    {
        public UserValidator()
        {
            RuleFor(x=>x.FirstName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(50)
                .WithName("İsim");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(50)
                .WithName("Soyisim");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .MinimumLength(11)
                .WithName("Telefon Numarası");


        }
    }
}
