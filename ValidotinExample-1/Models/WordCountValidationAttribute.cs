using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidotinExample_1.Models
{
    public class WordCountValidationAttribute : Attribute, IModelValidator
    {
        public string ErrorMessage { get; set; }
        public int MaxWordCount { get; set; }

        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            var content = context.Model as String;

            //kısıtla
            if(String.IsNullOrEmpty(content) || content.Split(" ").Count() > MaxWordCount)
            {
                return new List<ModelValidationResult>
                { 
                    new ModelValidationResult("", ErrorMessage)
                };
            }
            //izin ver
            else
            {
                return Enumerable.Empty<ModelValidationResult>();
            }
        }
    }
}
