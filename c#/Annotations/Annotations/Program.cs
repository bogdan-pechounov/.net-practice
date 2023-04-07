using Annotations;
using System.ComponentModel.DataAnnotations;

Author author = new Author();
author.FirstName = "";
author.LastName = "";
author.PhoneNumber = "1234567890";
author.Email = "test@mail.com";

ValidationContext context = new ValidationContext(author, null, null);
List<ValidationResult> validationResults = new List<ValidationResult>();
bool valid = Validator.TryValidateObject(author, context, validationResults, true);
if (!valid)
{
    foreach(ValidationResult validationResult in validationResults)
    {
        Console.WriteLine("{0}", validationResult.ErrorMessage);
    }
}