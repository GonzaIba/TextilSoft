using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Extensions
{
    public static class ExpressionExtensions
    {
        public static Expression<Func<TTo, bool>> ReplaceParameter<TFrom, TTo>(this Expression<Func<TFrom, bool>> target)
        {
            return (Expression<Func<TTo, bool>>)new WhereReplacerVisitor<TFrom, TTo>().Visit(target);
        }
        public static Expression<Func<TTo, dynamic>> ReplaceParameter<TFrom, TTo>(this Expression<Func<TFrom, dynamic>> target)
        {
            return (Expression<Func<TTo, dynamic>>)new WhereReplacerVisitor<TFrom, TTo>().Visit(target);
        }

        
        private class WhereReplacerVisitor<TFrom, TTo> : ExpressionVisitor
        {
            private readonly ParameterExpression _parameter = Expression.Parameter(typeof(TTo), "c");

            protected override Expression VisitLambda<T>(Expression<T> node)
            {
                return Expression.Lambda(Visit(node.Body), _parameter);
            }

            protected override Expression VisitMember(MemberExpression node)
            {
                if (node.Member.DeclaringType == typeof(TFrom) && node.Expression is ParameterExpression)
                {
                    var propertyName = node.Member.Name;

                    if (propertyName == "Cliente")
                    {
                        var clientProperty = typeof(TTo).GetProperty("Clientes");
                        if (clientProperty == null)
                        {
                            throw new ArgumentException("Property 'Clientes' not found in target type.");
                        }

                        var clientParameter = Expression.MakeMemberAccess(_parameter, clientProperty);

                        var clientNameProperty = typeof(ClientesModel).GetProperty("Nombre");
                        if (clientNameProperty == null)
                        {
                            throw new ArgumentException("Property 'Nombre' not found in target type.");
                        }

                        return Expression.MakeMemberAccess(clientParameter, clientNameProperty);
                    }
                    else
                    {
                        return Expression.PropertyOrField(_parameter, propertyName);
                    }
                }

                return base.VisitMember(node);
            }
        }
    }
}
