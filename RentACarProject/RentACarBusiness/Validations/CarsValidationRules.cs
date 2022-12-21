using FluentValidation;
using RentACarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarBusiness.Validations
{
    public class CarsValidationRules : AbstractValidator<Cars>
    {
        //YAPICI SINIF TANIMLIYORUZ
        public CarsValidationRules()
        {
            RuleFor(x => x.carName)
                .NotEmpty().WithMessage("Araba adı boş geçilemez!")
                .MinimumLength(2).WithMessage("Araba adı minimum 3 haneli olmalı!")
                .MaximumLength(20).WithMessage("Araba adı maximum 20 haneli olmalı!");

            RuleFor(x => x.carPrice)
                .NotEmpty().WithMessage("Fiyat boş geçilemez");
        }
    }
}