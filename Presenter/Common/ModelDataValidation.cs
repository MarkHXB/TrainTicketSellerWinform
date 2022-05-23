using System.ComponentModel.DataAnnotations;

namespace TicketSeller.Presenter.Common
{
    internal class ModelDataValidation
    {
        public void Validate(object model)
        {
            string errorMessage = string.Empty;

            var results = new List<ValidationResult>();

            var context = new ValidationContext(model);

            bool isValid = Validator.TryValidateObject(model, context, results, true);
            if (!isValid)
            {
                foreach (var item in results)
                    errorMessage += $"- {item.ErrorMessage}\n";
                throw new Exception(errorMessage);
            }
        }
    }
}
