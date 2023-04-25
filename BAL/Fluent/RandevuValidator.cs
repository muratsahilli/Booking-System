using BAL.Concrete;
using DAL.EntityFramework;
using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Fluent
{
    public class RandevuValidator : AbstractValidator<Randevular>
    {
        public RandevuValidator()
        {
            RuleFor(x => x.Konu).MinimumLength(25).WithMessage("Konu minimum 25 karakter olmalıdır");
            RuleFor(x => x.EndTime).GreaterThanOrEqualTo(x => x.StartTime).WithMessage("Randevu bitiş saati başlangıç saatinden önce olamaz");
            RandevuManager randevuManager = new RandevuManager(new EFrandevuDAL());
            var values = randevuManager.GetListAll();
            foreach (var item in values)
            {
                if(item.StartTime >= DateTime.Today && item.EndTime>=DateTime.Today) {
                   
                    RuleFor(x => x.StartTime).Custom((list, context) =>
                    {
                        if (item.StartTime <= list && item.EndTime >= list)
                        {
                            context.AddFailure( item.StartTime + " ile " + item.EndTime + " arasında başka bir randevu bulunduğu için randevunuz eklenemedi. Lütfen Başlangıç tarihini değiştirin");
                        }
                    });
                    RuleFor(x => x.EndTime).Custom((list, context) =>
                    {
                        if (item.StartTime <= list && item.EndTime >= list)
                        {
                            context.AddFailure(item.StartTime+" ile "+item.EndTime+ " arasında başka bir randevu bulunduğu için randevunuz eklenemedi. Lütfen Bitiş tarihini değiştirin");
                        }
                    });

                }
            }

        }
    }
}
