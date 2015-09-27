using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using KebabManager.Common.Enums;
using Pizza.Contracts.Default.Presentation;

namespace KebabManager.Contracts.ViewModels.Customers
{
    public sealed class CustomerCreateModel : CreateModelBase
    {
        [Display(Name = "Login"), Required(ErrorMessage = Resources.RequiredMessage)]
        public string Login { get; set; }

        [Display(Name = "Password"), Required(ErrorMessage = Resources.RequiredMessage)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name"), Required(ErrorMessage = Resources.RequiredMessage)]
        public string LastName { get; set; }

        [Display(Name = "Fingers count"), Required(ErrorMessage = Resources.RequiredMessage)]
        public int FingersCount { get; set; }

        [Display(Name = "Is mature"), Required(ErrorMessage = Resources.RequiredMessage)]
        public bool IsMature { get; set; }

        [Display(Name = "Previous surgery date"), Required(ErrorMessage = Resources.RequiredMessage)]
        public DateTime PreviousSurgeryDate { get; set; }

        [Display(Name = "Some other date"), Required(ErrorMessage = Resources.RequiredMessage)]
        public DateTime SomeDateInFuture { get; set; }

        [Display(Name = "Customer type"), Required(ErrorMessage = Resources.RequiredMessage)]
        public CustomerType Type { get; set; }

        [Display(Name = "Favorite animal")]
        public AnimalSpecies? Animal { get; set; }

        [Display(Name = "Long description")]
        [AllowHtml, DataType(DataType.Html)]
        public string Description { get; set; }

        [Display(Name = "My notes")]
        [AllowHtml, DataType(DataType.Html)]
        public string Notes { get; set; }
    }
}