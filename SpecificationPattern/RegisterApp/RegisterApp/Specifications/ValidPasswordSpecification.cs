using RegisterApp.Models;
using RegisterApp.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterApp.Specifications
{
    public class ValidPasswordSpecification : CompositeSpecification<UserRegistrationRequest>
    {
        public override bool IsSatisfiedBy(UserRegistrationRequest candidate) =>
            !string.IsNullOrWhiteSpace(candidate.Password) &&
            !string.IsNullOrWhiteSpace(candidate.PasswordConfirmation);
    }
}
