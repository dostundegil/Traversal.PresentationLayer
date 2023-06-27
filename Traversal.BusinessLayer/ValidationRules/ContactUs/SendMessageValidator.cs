using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DTOLayer.DTOs.ContactDTOs;

namespace Traversal.BusinessLayer.ValidationRules.ContactUs
{
    public class SendMessageValidator:AbstractValidator<SendMessageDTO>
    {
        public SendMessageValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu alan boş geçilemez.");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Bu alan boş geçilemez.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Bu alan boş geçilemez.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Bu alan boş geçilemez.");
        }
    }
}
