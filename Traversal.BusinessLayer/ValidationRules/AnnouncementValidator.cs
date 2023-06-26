using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DTOLayer.DTOs.AnnouncementDTOs;
using Traversal.EntityLayer.Concrate;

namespace Traversal.BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x=>x.Content).NotEmpty().WithMessage("Bu alan boş geçilemez");

            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz");
            RuleFor(x=>x.Content).MinimumLength(20).WithMessage("Lütfen en az 20 karakter giriniz");

            RuleFor(x=>x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz");
            RuleFor(x=>x.Content).MaximumLength(500).WithMessage("Lütfen en fazla 500 karakter giriniz");
        }
    }
}
