using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DTOLayer.DTOs.AppUserDTOs;

namespace Traversal.BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Bu alan boş geçilemez");

            RuleFor(x => x.Username).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("Lütfen en az 5 karakter girişi yapınız");

            RuleFor(x => x.Mail).MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter girişi yapınız");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter girişi yapınız");
            RuleFor(x => x.Username).MaximumLength(15).WithMessage("Lütfen en fazla 15 karakter girişi yapınız");
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Şifreler eşleşmiyor");
        }
    }
}
