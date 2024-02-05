using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NumberLineParser : INumberLineParser
    {
        private readonly INumberLineParser _numberLineParser;

        public NumberLineParser(INumberLineParser numberLineParser)
        {
            _numberLineParser = numberLineParser;
        }

        public string DecodedNumberString(List<int> numberContainer)
        {

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < numberContainer.Count; i++)
            {
                if (numberContainer[i] % 3 == 0)
                {
                    stringBuilder.Append("Fizz");
                }
                else if (numberContainer[i] % 5 == 0)
                {
                    stringBuilder.Append("Buzz");
                }
                else if (numberContainer[i] % 3 == 0 && numberContainer[i] % 5 == 0)
                {
                    stringBuilder.Append("FizzBuzz");
                }
                else
                {
                    stringBuilder.Append(numberContainer[i].ToString());
                }
            }
            return stringBuilder.ToString();
        }
    }
}
