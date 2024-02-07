using Entity.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation;

public class BannerAboutValidator:AbstractValidator<BannerAbout>
{
    public BannerAboutValidator()
    {
        RuleFor(ba => ba.BannerAboutDescription).MinimumLength(50).WithMessage("Lütfen 2 karakterden fazla açıklama giriniz");RuleFor(ba => ba.BannerAboutDescription).MinimumLength(50).WithMessage("Lütfen 2 karakterden fazla açıklama giriniz");
        RuleFor(ba => ba.BannerAboutDescription).MinimumLength(50).WithMessage("Lütfen 2 karakterden fazla açıklama giriniz");RuleFor(ba => ba.BannerAboutDescription).MaximumLength (1500).WithMessage("Lütfen 1500 karakterden az açıklama giriniz");
    }
}
