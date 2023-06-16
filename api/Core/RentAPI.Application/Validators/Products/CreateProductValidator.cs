using FluentValidation;
using RentAPI.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {

        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                 .WithMessage("Lütfen ürün adını yazınız")
                .MaximumLength(150)
                .MinimumLength(2)
                    .WithMessage("Lütfen ürün adını 2 ila 150 karakter arasında giriniz");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen stok kısmını doldurunuz")
                .Must(s => s >= 0)
                    .WithMessage("Stok bilgisi negatif olamaz!");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen fiyat kısmını doldurunuz")
                .Must(s => s >= 0)
                    .WithMessage("Fiyat bilgisi negatif olamaz!");


        }
    }
}
