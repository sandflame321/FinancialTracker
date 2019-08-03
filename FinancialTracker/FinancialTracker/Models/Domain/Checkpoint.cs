using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialTracker.Models.Domain
{
    public class Checkpoint
    {
        public DateTime Date { get; set; }
        public decimal Bedrag { get; set; }
        public string Conclusie { get; set; }
        public string ToekomstZicht { get; set; }
        public Checkpoint(ICollection<Rekening> rekeningen, string conclusie, string toekomstzicht)
        {
            this.Date = DateTime.Today;
            this.Conclusie = conclusie;
            this.ToekomstZicht = toekomstzicht;
            ToevoegenBedrag(rekeningen);
        }

        private void ToevoegenBedrag(ICollection<Rekening> rekeningen)
        {
            try
            {
                this.Bedrag = rekeningen.Sum(r => r.Bedrag);
            }
            catch(Exception e)
            {
                throw new Exception("Er werden geen rekeningen teruggevonden.");
            }
        }
    }
}
