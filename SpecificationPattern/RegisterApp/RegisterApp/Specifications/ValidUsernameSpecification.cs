using RegisterApp.Models;
using RegisterApp.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterApp.Specifications
{
    public class ValidUsernameSpecification : CompositeSpecification<UserRegistrationRequest>
    {
        public override bool IsSatisfiedBy(UserRegistrationRequest candidate) =>
            !string.IsNullOrWhiteSpace(candidate.Username);
    }
}
