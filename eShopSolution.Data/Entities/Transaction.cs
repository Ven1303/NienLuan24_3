using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
   public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ExternalTransactionId { get; set; }
        public int Amount { get; set; }
        public float fee { get; set; }
        public string Result { get; set; }
        public TransactionStatus Status { get; set; }
        public string Message { get; set; }
        public string Provider { get; set; }
    }
}
