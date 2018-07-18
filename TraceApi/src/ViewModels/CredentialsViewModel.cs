
using TraceApi.ViewModels.Validations;
using FluentValidation.Attributes;

namespace TraceApi.ViewModels
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
