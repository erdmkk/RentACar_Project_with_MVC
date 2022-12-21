using FluentValidation;
using RentACarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarBusiness.Validations
{
    public class CategoriesValidationRules : AbstractValidator<Categories>
    {
        public CategoriesValidationRules()
        {
            RuleFor(x => x.categoryName)
                .NotEmpty().WithMessage("Kategori adı boş geçilemez!")
                .MinimumLength(3).WithMessage("Minimum 3 haneli olmalıdır")
                .MaximumLength(20).WithMessage("Maximum 20 haneli olmalıdır!");
        }
    }
}
