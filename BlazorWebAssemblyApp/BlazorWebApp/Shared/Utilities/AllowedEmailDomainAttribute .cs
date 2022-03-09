using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebApp.Shared.Utilities
{
    public class AllowedEmailDomainAttribute:ValidationAttribute
    {
        public AllowedEmailDomainAttribute(string allowDomain)
        {
            AllowDomain = allowDomain;
        }

        public string AllowDomain { get; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value==null && value.ToString().Length==0)
            {
                return new ValidationResult("Email Field is required!!!");
            }
            else
            {
                if(value.ToString().IndexOf('@')==-1)
                {
                    return new ValidationResult("Invalid Email Address!!!");
                }

                string[] s = value.ToString().Split('@');
                if(s[1].ToUpper()==AllowDomain.ToUpper())
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(this.ErrorMessage ?? $"Domain must end with {AllowDomain}");
                }
            }
        }
    }
}
