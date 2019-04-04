using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculator.Engines.Contracts
{
    public interface IMortgageCalculatorEngine
    {
        MortgageCalculationResult AmortizeMortgage(MortgageCalculationRequest request);
    }
}
