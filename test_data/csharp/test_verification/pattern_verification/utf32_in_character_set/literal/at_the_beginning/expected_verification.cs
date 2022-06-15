/*
 * This code has been automatically generated by aas-core-codegen.
 * Do NOT edit or append.
 */

using Regex = System.Text.RegularExpressions.Regex;
using System.Collections.Generic;  // can't alias
using System.Linq;  // can't alias

using Aas = dummyNamespace;
using Reporting = dummyNamespace.Reporting;
using Visitation = dummyNamespace.Visitation;

namespace dummyNamespace
{
    /// <summary>
    /// Verify that the instances of the meta-model satisfy the invariants.
    /// </summary>
    public static class Verification
    {
        private static Regex _constructMatchSomething()
        {
            var pattern = "^prefix([a-zA-Z]|\\ud800\\udc00)suffix$";

            return new Regex(pattern);
        }

        private static readonly Regex _regexMatchSomething = _constructMatchSomething();

        public static bool MatchSomething(string text)
        {
            return _regexMatchSomething.IsMatch(text);
        }

        /// <summary>
        /// Hash allowed enum values for efficient validation of enums.
        /// </summary>
        internal static class EnumValueSet
        {

        }  // internal static class EnumValueSet

        private static readonly Verification.Transformer _transformer = (
            new Verification.Transformer());

        private class Transformer
            : Visitation.AbstractTransformer<IEnumerable<Reporting.Error>>
        {

        }  // private class Transformer

        /// <summary>
        /// Verify the constraints of <paramref name="that" /> recursively.
        /// </summary>
        /// <param name="that">
        /// The instance of the meta-model to be verified
        /// </param>
        public static IEnumerable<Reporting.Error> Verify(Aas.IClass that)
        {
            foreach (var error in _transformer.Transform(that))
            {
                yield return error;
            }
        }
    }  // public static class Verification
}  // namespace dummyNamespace

/*
 * This code has been automatically generated by aas-core-codegen.
 * Do NOT edit or append.
 */
