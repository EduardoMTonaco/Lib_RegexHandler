namespace Lib_RegexHandler
{
    /// <summary>
    /// Interface to Extract full expression as string with start and the end can be seted and the middle is the regular expression
    /// </summary>
    public interface IExpressionExtrator
    {
        /// <summary>
        /// Start of the expression
        /// </summary>
        string EndExpression { get; }
        /// <summary>
        /// Regular expression, middle of the sentense
        /// </summary>
        string FullExpression { get; }
        /// <summary>
        /// End of the expression
        /// </summary>
        string RegularExpression { get; }
        /// <summary>
        /// Full expression, it will be joins the expression in the constructor
        /// </summary>
        string StartExpression { get; }
        /// <summary>
        /// Function to return the first ocorrense of the full expression (with regular expression in it) in a text
        /// </summary>
        /// <param name="text">Text use to find the ocorrense of the expression</param>
        /// <returns>Return the full expression with the ocorrence</returns>
        string GetRegexResult(string text);
    }
}