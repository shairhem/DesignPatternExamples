using RegisterApp.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterApp.Factories
{
    public interface ISpecificationFactory<T>
    {
        ISpecification<T> CreateSpecification();
    }
}
