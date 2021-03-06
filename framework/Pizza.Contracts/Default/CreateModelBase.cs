using System.Web.Mvc;

namespace Pizza.Contracts.Default
{
    public abstract class CreateModelBase : ICreateModelBase
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
    }
}