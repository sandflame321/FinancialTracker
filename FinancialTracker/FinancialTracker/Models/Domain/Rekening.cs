using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialTracker.Models.Domain
{
    public class Rekening
    {
        public decimal Bedrag { get; set; }
        public RekeningType Type { get; set; }

        public Rekening(decimal bedrag, RekeningType type)
        {
            try
            {
                this.Bedrag = bedrag;
                this.Type = type;
            }
            catch (Exception e)
            {
                throw new Exception("Voer een juist type rekening in.");
            }
        }
    }
}
