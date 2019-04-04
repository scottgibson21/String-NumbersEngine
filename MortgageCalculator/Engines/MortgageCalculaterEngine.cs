using MortgageCalculator.Engines.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculator.Engines
{
    public class MortgageCalculatorEngine : IMortgageCalculatorEngine
    {

        public MortgageCalculationResult AmortizeMortgage(MortgageCalculationRequest request)
        {
            var n = request.TotalCadencePayments;
            var cadenceInterest = request.CadenceInterest;
            var discount = ((Math.Pow((double)(1 + cadenceInterest), n)) - 1)/
                ((double)cadenceInterest * (Math.Pow((double)(1 + cadenceInterest), n)));

            var result = new MortgageCalculationResult();
            result.PaymentTotal = Math.Round((request.Principal / (decimal)discount), 2);

            var loanBalance = request.Principal;

            for (int i = 0; i < request.TotalCadencePayments; i++)
            {
                var tempIntPmt = Math.Round(loanBalance * cadenceInterest, 2);
                result.InterestPayments.Add(tempIntPmt);

                var tempPrinciplePayment = result.PaymentTotal - tempIntPmt;
                result.PrincipalPayments.Add(tempPrinciplePayment);

                loanBalance -= tempPrinciplePayment;
                result.RemainingBalance.Add(loanBalance);
            }

            return result;

        }
    }
}
