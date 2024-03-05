using System;
using System.ComponentModel.DataAnnotations;

namespace FakeXiecheng.API.ValidationAttributes
{
    public class TitleMustBeDifferentFromDescriptionAttribute : ValidationAttribute
    {
        public string TitlePropertyName { get; private set; }
        public string DescriptionPropertyName { get; private set; }

        public TitleMustBeDifferentFromDescriptionAttribute(string titlePropertyName, string descriptionPropertyName)
        {
            TitlePropertyName = titlePropertyName;
            DescriptionPropertyName = descriptionPropertyName;
        }

        protected override ValidationResult IsValid(
            object value,
            ValidationContext validationContext
        )
        {
            var titleProperty = validationContext.ObjectType.GetProperty(TitlePropertyName);
            if (titleProperty == null)
            {
                return new ValidationResult(String.Format("Unknown property: {0}.", TitlePropertyName));
            }

            var DescriptionProperty = validationContext.ObjectType.GetProperty(DescriptionPropertyName);
            if (DescriptionProperty == null)
            {
                return new ValidationResult(String.Format("Unknown property: {0}.", DescriptionPropertyName));
            }

            var titlePropertyValue = titleProperty.GetValue(validationContext.ObjectInstance, null);
            var DescriptionPropertyValue = DescriptionProperty.GetValue(validationContext.ObjectInstance, null);
            if (titlePropertyValue.ToString() == DescriptionPropertyValue.ToString())
            {
                return new ValidationResult(
                    "路线名称必须与路线描述不同",
                    new[] { "TouristRouteForCreationDto" }
                );
            }
            return ValidationResult.Success;
        }
    }
}
