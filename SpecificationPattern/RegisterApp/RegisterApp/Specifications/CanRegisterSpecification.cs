using RegisterApp.Models;
using RegisterApp.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterApp.Specifications
{
    public class CanRegisterSpecification : CompositeSpecification<UserRegistrationRequest>
    {
        ISpecification<UserRegistrationRequest> spec;

        public CanRegisterSpecification()
        {
            var validEmail = new ValidEmailSpecification();
            var validUsername = new ValidUsernameSpecification();
            var validPassword = new ValidPasswordSpecification();
            var passwordConfirmed = new PasswordConfirmedSpecification();
            this.spec = validEmail.And(validUsername).And(validPassword).And(passwordConfirmed);
        }

        public override bool IsSatisfiedBy(UserRegistrationRequest candidate) =>
            this.spec.IsSatisfiedBy(candidate);
    }
}
