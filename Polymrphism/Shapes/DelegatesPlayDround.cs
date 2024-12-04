using System.Linq.Expressions;

namespace Polymrphism.Shapes
{
    internal class DelegatesPlayDround
    {
        //public delegate double MyFunction(double x);

        //public double Diff(double x, MyFunction f)
        //{


        //    return f(x);
        //}

        //public double MyFunctionMethod(double x)
        //{
        //    // Can add more complicated logic here
        //    return x + 10;
        //}

        //public void Client()
        //{
        //    double result = Diff(1.234, x => x * 456.1234);
        //    double secondResult = Diff(2.345, MyFunctionMethod);
        //}

        //public static Expression<Func<T, S>> ParseLambda<T, S>(string expression)
        //{
        //    string paramString = expression.Substring(0, expression.IndexOf("=>")).Trim();
        //    string lambdaString = expression.Substring(expression.IndexOf("=>") + 2).Trim();
        //    ParameterExpression param = Expression.Parameter(typeof(T), paramString);
        //    return (Expression<Func<T, S>>)ParseLambda(new[] { param }, typeof(S), lambdaString, null);
        //}

        //public static LambdaExpression ParseLambda(string expression, Type returnType, params Type[] paramTypes)
        //{
        //    string paramString = expression.Substring(0, expression.IndexOf("=>")).Trim("() ".ToCharArray());
        //    string lambdaString = expression.Substring(expression.IndexOf("=>") + 2).Trim();
        //    var paramList = paramString.Split(',');
        //    if (paramList.Length != paramTypes.Length)
        //        throw new ArgumentException("Specified number of lambda parameters do not match the number of parameter types!", "expression");

        //    List<ParameterExpression> parameters = new List<ParameterExpression>();
        //    for (int i = 0; i < paramList.Length; i++)
        //        parameters.Add(Expression.Parameter(paramTypes[i], paramList[i].Trim()));

        //    return ParseLambda(parameters.ToArray(), returnType, lambdaString, null);
        //}
    }
}
