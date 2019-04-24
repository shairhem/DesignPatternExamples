using RegisterApp.Models;
using RegisterApp.Specifications;
using RegisterApp.Specifications.Base;

namespace RegisterApp.Factories
{
    public class RegistrationSpecificationFactory : ISpecificationFactory<UserRegistrationRequest>
    {
        public ISpecification<UserRegistrationRequest> CreateSpecification()
        {
            var validEmail = new ValidEmailSpecification();
            var validUsername = new ValidUsernameSpecification();
            var validPassword = new ValidPasswordSpecification();
            var passwordConfirmed = new PasswordConfirmedSpecification();
            return validEmail.And(validUsername).And(validPassword).And(passwordConfirmed);
        }
    }
}
