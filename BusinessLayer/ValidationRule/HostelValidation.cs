using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class HostelValidation : AbstractValidator<Hostel>
    {
        public HostelValidation()
        {
            RuleFor(x=>x.HostelName).NotEmpty().WithMessage("Otel Adını Boş Bırakamazsınız");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon Numarasını Boş Bırakmazsınız").MinimumLength(11).WithMessage("Eksik Telefon Numarasını Yazdınız");
            RuleFor(x => x.PostCode).NotEmpty().WithMessage("Posta Kodunu Boş Bırakmazsınız");

        }
    }
}
