﻿using System;
using Course10.FirstExerciceEntities;
using Course10.Services;

namespace Course10.FirstExerciceServices
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months) {
            double valuePerMonth = contract.TotalValue / months;
            for (int i = 1; i <= months; i++) { 
                DateTime date = contract.Date.AddMonths(i);

                double updatedQuota = valuePerMonth + _onlinePaymentService.Interest(valuePerMonth, i);

                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);

                contract.AddInstallment(new Installment(date, fullQuota));

            }
        }
    }
}
