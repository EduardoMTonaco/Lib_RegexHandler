# Lib_RegexHandler
Class to extract regular expression

This class three constructors,
three strings private set and public get, 
one string private to empty values 
and one function that return a string with the result of find the regular expression.

First string is "StartExpression", this is the start of the expression, it is not a regular expression.
Second string is "RegularExpression", this is the regular expression use to find in the text.
Third string is "EndExpression", this is the end of the expression, it is not a regular expression.

The first constructor one receive a unic parameter that is a string with the regular expression
The second constructor receive two parameters that are strings, the first parameter is the start expression ,the second is the regular expression
The third constructor receive all three parameter that are strings, Start of the expression, the Regular Expression and the ende of the expression

The only function is RegexResult(string text), this function returns a string as result if finds a match for the regular expression in the text parameter.


This proeject has a Interface IExpressionExtrator with the three strings and the function.

