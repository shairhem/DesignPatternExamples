using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterApp.Specifications.Base
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> left;
        private readonly ISpecification<T> right;

        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this.left = left;
            this.right = right;
        }

        public override bool IsSatisfiedBy(T candidate) =>
            this.left.IsSatisfiedBy(candidate) || this.right.IsSatisfiedBy(candidate);
    }
}
