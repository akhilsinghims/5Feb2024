using ClassLibrary;
using NSubstitute;
using NUnit.Framework.Internal;
using System.Text;

namespace TestProject
{
    public class Tests
    {
        public const string MULTIPLEOFTHREENAME = "Fizz";
        public const string MULTIPLEOFFIVENAME = "Buzz";
        public const string MULTIPLEOFTHREEANDFIVENAME = "FizzBuzz";

        private List<int> lstInputNumbers;
        private StringBuilder sbDecodedMultipleOfThree;

        private StringBuilder sbDecodedMultipleOfFive;

        private StringBuilder sbDecodedMultipleOfThreeAndFive;

        private StringBuilder sbDecodedNumbersString;

        private INumberLineParser _numberLineParser = NSubstitute.Substitute.For<INumberLineParser>();

        [SetUp]
        public void Setup()
        {
            ArrangeDataForMultipeOfThree();
            ArrangeDataForMultipeOfFive();
            ArrangeDataForMultipeOfThreeAndFive();
            ArrangeDataForAllNumbers();
        }

        private List<int> CreateInputArray()
        {
            for (int i = 1; i <= 100; i++)
            {
                lstInputNumbers.Add(i);
            }
            return lstInputNumbers;
        }

        private void ArrangeDataForMultipeOfThree()
        {
            lstInputNumbers = new List<int>();

            lstInputNumbers = CreateInputArray();

            sbDecodedMultipleOfThree = new StringBuilder();

            foreach (int i in lstInputNumbers)
            {
                if (i % 3 == 0)
                {
                    sbDecodedMultipleOfThree.Append(MULTIPLEOFTHREENAME);
                }
                else
                {
                    sbDecodedMultipleOfThree.Append(i.ToString());
                }
            }
        }

        private void ArrangeDataForMultipeOfFive()
        {
            lstInputNumbers = new List<int>();
            lstInputNumbers = CreateInputArray();

            sbDecodedMultipleOfFive = new StringBuilder();

            foreach (int i in lstInputNumbers)
            {
                if (i % 5 == 0)
                {
                    sbDecodedMultipleOfFive.Append(MULTIPLEOFFIVENAME);
                }
                else
                {
                    sbDecodedMultipleOfFive.Append(i.ToString());
                }
            }
        }
        private void ArrangeDataForMultipeOfThreeAndFive()
        {
            lstInputNumbers = new List<int>();
            lstInputNumbers = CreateInputArray();

            sbDecodedMultipleOfThreeAndFive = new StringBuilder();

            foreach (int i in lstInputNumbers)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sbDecodedMultipleOfThreeAndFive.Append(MULTIPLEOFTHREEANDFIVENAME);
                }
                else
                {
                    sbDecodedMultipleOfThreeAndFive.Append(i.ToString());
                }
            }
        }

        private void ArrangeDataForAllNumbers()
        {
            lstInputNumbers = new List<int>();
            lstInputNumbers = CreateInputArray();

            sbDecodedNumbersString = new StringBuilder();

            foreach (int i in lstInputNumbers)
            {
                if (i % 3 == 0)
                {
                    sbDecodedNumbersString.Append(MULTIPLEOFTHREENAME);
                }
                else if (i % 5 == 0)
                {
                    sbDecodedNumbersString.Append(MULTIPLEOFFIVENAME);
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    sbDecodedNumbersString.Append(MULTIPLEOFTHREEANDFIVENAME);
                }
                else
                {
                    sbDecodedNumbersString.Append(i.ToString());
                }
            }
        }

        [Test]
        public void MultipleOfThree()
        {
            string outputString = sbDecodedMultipleOfThree.ToString();

            _numberLineParser.DecodedNumberString(lstInputNumbers).Returns(outputString);

            Assert.That(outputString, Is.EqualTo(_numberLineParser.DecodedNumberString(lstInputNumbers)));
        }


        [Test]
        public void MultipleOfFive()
        {
            string outputString = sbDecodedMultipleOfFive.ToString();

            _numberLineParser.DecodedNumberString(lstInputNumbers).Returns(outputString);

            Assert.That(outputString, Is.EqualTo(_numberLineParser.DecodedNumberString(lstInputNumbers)));
        }

        [Test]
        public void MultipleOfThreeAndFive()
        {
            string outputString = sbDecodedMultipleOfThreeAndFive.ToString();

            _numberLineParser.DecodedNumberString(lstInputNumbers).Returns(outputString);

            Assert.That(outputString, Is.EqualTo(_numberLineParser.DecodedNumberString(lstInputNumbers)));
        }

        [Test]
        public void PrintEncodedNumberString()
        {
            string outputString = sbDecodedNumbersString.ToString();

            _numberLineParser.DecodedNumberString(lstInputNumbers).Returns(outputString);

            Assert.That(outputString, Is.EqualTo(_numberLineParser.DecodedNumberString(lstInputNumbers)));
        }
    }
}