﻿namespace Farsica.Framework.DataAccess.Specification.Queryable
{
    using System;
    using System.Linq.Expressions;
    using Farsica.Framework.Core.Extensions.Linq;

    public class OrQueryableSpecification<T> : QueryableSpecification<T>
    {
        private readonly ISpecification<T> left;
        private readonly ISpecification<T> right;

        public OrQueryableSpecification(ISpecification<T> left, ISpecification<T> right)
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