using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class RoomValiation : AbstractValidator<Room>
    {
        public RoomValiation()
        {
            RuleFor(x => x.RoomDescription).NotEmpty().WithMessage("Boş Geçemezsiniz").MaximumLength(50).WithMessage("50 Karakter az Değer Giremezsiniz");

        }
    }
}
