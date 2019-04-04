using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortgageCalculator.Engines;
using MortgageCalculator.Engines.Contracts;
using MortgageCalculator;
using MortgageCalculator.Constants;

namespace MortgageCalculatorTests
{
    [TestClass]
    public class MortgageCalcuationEngineTests
    {
        private IMortgageCalculatorEngine _engine;

        [TestInitialize]
        public void SetupTests()
        {
            _engine = new MortgageCalculatorEngine();
        }

        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var request = BuildbuildBaseRequest();

            //act
            MortgageCalculationResult resultTest = _engine.AmortizeMortgage(request);

            //assert
            Assert.AreNotEqual(null, resultTest);
            
        }
        #region helpers

        private MortgageCalculationRequest BuildbuildBaseRequest()
        {
            var result = new MortgageCalculationRequest()
            {
                Principal = 100000,
                Term = 10,
                Interest = .045m,
                PaymentCadence = EPaymentCadence.Monthly,
                CadenceInterest = .045m / 12m,
                TotalCadencePayments = 10 * 12,
            };

            return result;
        }

        #endregion
    }
}
