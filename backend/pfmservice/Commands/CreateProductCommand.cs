using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pfmservice.Models;

namespace pfmservice.Commands
{
    public class CreateProductCommand
    {
        
        public string BeneficiaryName { get; set; }

        public DateTime date { get; set; }

        public Direction Direction { get; set; }

        public double Amount { get; set; }

        public string Description { get; set; } 
        
        public string Mcc { get; set; } 

        public string Currency { get; set; }

        public TransactionKind Kind { get; set; }

    }
}