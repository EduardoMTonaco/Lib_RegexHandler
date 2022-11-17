using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lib_RegexHandler
{
    /// <summary>
    /// Class to Extract full expression as string with start and the end can be seted and the middle is the regular expression
    /// </summary>
    public class ExpressionExtrator : IExpressionExtrator
    {
        /// <summary>
        /// Start of the expression
        /// </summary>
        public string StartExpression { get; private set; }
        /// <summary>
        /// Regular expression, middle of the sentense
        /// </summary>
        public string RegularExpression { get; private set; }
        /// <summary>
        /// End of the expression
        /// </summary>
        public string EndExpression { get; private set; }
        /// <summary>
        /// Full expression, it will be joins the expression in the constructor
        /// </summary>
        public string FullExpression { get; private set; }
        /// <summary>
        /// Empty string for complete the expression
        /// </summary>
        private string _empty => "";

        /// <summary>
        /// Constructor that the only param is the Regular Expression
        /// </summary>
        /// <param name="regularExpression"></param>
        public ExpressionExtrator(string regularExpression)
        {
            StartExpression = _empty;
            RegularExpression = regularExpression;
            EndExpression = _empty;
            FullExpression = StartExpression + regularExpression + EndExpression;
        }
        /// <summary>
        /// Constructor with the start expression and the regular expression
        /// </summary>
        /// <param name="startExpression">Start of the expression</param>
        /// <param name="regularExpression">Regular expression</param>
        public ExpressionExtrator(string startExpression, string regularExpression)
        {
            StartExpression = startExpression;
            RegularExpression = regularExpression;
            EndExpression = _empty;
            FullExpression = StartExpression + regularExpression + EndExpression;
        }
        /// <summary>
        /// Constructor with start, regular expression and end expression
        /// </summary>
        /// <param name="startExpression">Start of the expression</param>
        /// <param name="regularExpression">Regular expression</param>
        /// <param name="endExpression">End of the expression</param>
        public ExpressionExtrator(string startExpression, string regularExpression, string endExpression)
        {
            StartExpression = startExpression;
            RegularExpression = regularExpression;
            EndExpression = endExpression;
            FullExpression = startExpression + regularExpression + endExpression;
        }
        /// <summary>
        /// Function to return the first ocorrense of the full expression (with regular expression in it) in a text
        /// </summary>
        /// <param name="text">Text use to find the ocorrense of the expression</param>
        /// <returns>Return the full expression with the ocorrence</returns>
        public string RegexResult(string text)
        {
            string regexResult = new Regex(FullExpression).Match(text).ToString();
            try
            {
                return regexResult.Replace(StartExpression, "").Replace(EndExpression, "");
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }
    }
}
