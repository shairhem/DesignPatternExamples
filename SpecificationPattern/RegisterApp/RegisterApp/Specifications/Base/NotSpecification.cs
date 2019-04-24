using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterApp.Specifications.Base
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> specification;

        public NotSpecification(ISpecification<T> specification)
        {
            this.specification = specification;
        }

        public override bool IsSatisfiedBy(T candidate) =>
            !this.specification.IsSatisfiedBy(candidate);
    }
}
