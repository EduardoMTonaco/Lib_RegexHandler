using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lib_RegexHandler
{
    public class ExpressionExtrator
    {
        public string StartExpression { get; private set; }
        public string RegularExpression { get; private set; }
        public string EndExpression { get; private set; }
        public string FullExpression { get; private set; }
        private string _empty => "";

        public ExpressionExtrator(string regularExpression)
        {
            StartExpression = _empty;
            RegularExpression = regularExpression;
            EndExpression = _empty;
            FullExpression = StartExpression + regularExpression + EndExpression;
        }
        public ExpressionExtrator(string startExpression, string regularExpression)
        {
            StartExpression = startExpression;
            RegularExpression = regularExpression;
            EndExpression = _empty;
            FullExpression = StartExpression + regularExpression + EndExpression;
        }
        public ExpressionExtrator(string startExpression, string regularExpression, string endExpression)
        {
            StartExpression = startExpression;
            RegularExpression = regularExpression;
            EndExpression = endExpression;
            FullExpression = startExpression + regularExpression + endExpression;
        }
        public string RegexResult(string text)
        {
          string regexResult = new Regex(FullExpression).Match(text).ToString();

          return  regexResult.Replace(StartExpression, "").Replace(EndExpression, "");
        }
    }
}
