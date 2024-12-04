using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace Polymrphism.Utils
{
    internal class StringToFunctionParser
    {
        internal static async Task<Func<double, double>> OneParameterAsync(string inputFunction)
        {
            return await CSharpScript.EvaluateAsync<Func<double, double>>(inputFunction);
        }
        internal static async Task<Func<double, double, double>> TwoParametersAsync(string inputFunction)
        {
            return await CSharpScript.EvaluateAsync<Func<double, double, double>>(inputFunction);
        }
        internal static async Task<Func<double, double, double, double>> ThreeParametersAsync(string inputFunction)
        {
            return await CSharpScript.EvaluateAsync<Func<double, double, double, double>>(inputFunction);
        }
    }
}
