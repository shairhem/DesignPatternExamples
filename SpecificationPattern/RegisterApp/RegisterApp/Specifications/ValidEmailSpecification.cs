using RegisterApp.Models;
using RegisterApp.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegisterApp.Specifications
{
    public class ValidEmailSpecification : CompositeSpecification<UserRegistrationRequest>
    {
        public override bool IsSatisfiedBy(UserRegistrationRequest candidate) =>
            !string.IsNullOrWhiteSpace(candidate.Email) &&
            Regex.IsMatch(candidate.Email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
    }
}
