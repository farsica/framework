﻿namespace Farsica.Framework.DataAccess.Specification.Enumerable
{
    using System;
    using System.Linq.Expressions;
    using Farsica.Framework.Core.Extensions.Linq;

    public class OrEnumerableSpecification<T> : EnumerableSpecification<T>
    {
        private readonly ISpecification<T> left;
        private readonly ISpecification<T> right;

        public OrEnumerableSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this.left = left;
            this.right = right;
        }

        public override Expression<Func<T, bool>> Expression()
        {
            return left.Expression().Or(right.Expression());
        }
    }
}
