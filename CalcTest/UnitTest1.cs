using Calc.Cantor;
using NUnit.Framework;



namespace Tests
{
    public class CalcTests
    {
        [SetUp]
        public void Setup()
        {
        }


        //Arrange 
        //Act
        //Assert
        [TestCase(2,5,31.4)]
        [TestCase(-2,-5,0)]
        [TestCase(1002, 1005, 3162011)]
        public void Exchange_RetrunValueFromPositives_ReturnsCorrectValue(decimal a, decimal b ,decimal expected)
        {
            RecalculateCurrencies recalculateCurrencies = new RecalculateCurrencies();
            var result = recalculateCurrencies.Exchange(a,b);
            var floreedResult = System.Math.Floor(result);
            Assert.AreEqual(expected, floreedResult);            
        }
      
        public void Exchange_RetrunValueFromNotPositives_ReturnsException()
        {
            RecalculateCurrencies recalculateCurrencies = new RecalculateCurrencies();
            var result = recalculateCurrencies.Substract(2, 5);
            
        }





        public void Substract_ReturnSubstractValueFromPositives_ReturnsCorrectValue()
        {
            Assert.Pass();
        }
        public void Add_ReturnSumValuesFromPositives_ReturnsCorrectValue()
        {
            Assert.Pass();
        }
    }
}