using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Fluent
{
    public class AramaValidator : AbstractValidator<Arama>
    {
        public AramaValidator()
        {
            RuleFor(x=>x.İsim).MinimumLength(3).WithMessage("İsim 3 karakterden az olamaz");
            RuleFor(x=>x.İsim).MaximumLength(25).WithMessage("İsim 25 karakterden fazla olamaz");
            RuleFor(x=>x.Konu).MinimumLength(20).WithMessage("Konu 20 karakterden az olamaz");

            RuleFor(x => x.AranmaTarihi.TimeOfDay)
                .InclusiveBetween(new TimeSpan(8,30,0), new TimeSpan(17,30,0))
                .WithMessage("Aranma saati 8:30 ile 17:30 arasında olmalıdır.");
        }
    }
}
