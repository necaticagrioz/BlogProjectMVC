using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator() 
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("İçerik boş geçilemez");
            RuleFor(x => x.BlogTitle).MinimumLength(2).WithMessage("En az 2 karaktere kadar giriş yapabilirsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(2).WithMessage("En fazla 100 karaktere kadar giriş yapabilirsiniz");


        }
    }
}
