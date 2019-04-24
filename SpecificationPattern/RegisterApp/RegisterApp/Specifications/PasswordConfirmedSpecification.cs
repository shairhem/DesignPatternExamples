using RegisterApp.Models;
using RegisterApp.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterApp.Specifications
{
    public class PasswordConfirmedSpecification : CompositeSpecification<UserRegistrationRequest>
    {
        public override bool IsSatisfiedBy(UserRegistrationRequest candidate) =>
            candidate.Password == candidate.PasswordConfirmation;
    }
}
