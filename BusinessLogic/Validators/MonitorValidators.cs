using BusinessLogic.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Validators
{
    public class MonitorValidators : AbstractValidator<MonitorDto>
    {
        public MonitorValidators()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .Length(3, 100);

            RuleFor(x => x.Display)
                .NotNull()
                .NotEmpty()
                .Length(3, 100);


            RuleFor(x => x.ScreenSize).GreaterThan(0);

            RuleFor(x => x.Refresh).GreaterThan(0);

            RuleFor(x => x.Price).GreaterThanOrEqualTo(0);

            RuleFor(x => x.MatrixId).GreaterThanOrEqualTo(0);

            RuleFor(x => x.ImgLink)
                .Must(LinkMustBeAUri).WithMessage("Link '{PropertyValue}' must be a valid URI.");
        }

        private static bool LinkMustBeAUri(string link)
        {
            if (string.IsNullOrWhiteSpace(link)) return false;

            Uri outUri;
            return Uri.TryCreate(link, UriKind.Absolute, out outUri)
                   && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);
        }
    }
}
