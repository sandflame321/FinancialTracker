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
        public Rekening bankkaart { get; set; }
        public Rekening spaarrekening { get; set; }
        public Rekening portefeuille { get; set; }
        public Checkpoint(ICollection<Rekening> rekeningen, string conclusie, string toekomstzicht)
        {
            this.Date = DateTime.Today;
            this.Conclusie = conclusie;
            this.ToekomstZicht = toekomstzicht;
            ToevoegenBedrag(rekeningen);
        }
        //Verdeel de bedragen onder de juiste rekeningen.
        private void ToevoegenBedrag(ICollection<Rekening> rekeningen)
        {
            try
            {
                this.Bedrag = rekeningen.Sum(r => r.Bedrag);
                this.bankkaart = rekeningen.Where(b => b.Type.Equals(RekeningType.Bankkaart)).First();
                this.spaarrekening = rekeningen.Where(b => b.Type.Equals(RekeningType.Spaarrekening)).First();
                this.portefeuille = rekeningen.Where(b => b.Type.Equals(RekeningType.Portefeuille)).First();
            }
            catch(Exception e)
            {
                throw new Exception("Er werden geen rekeningen teruggevonden.");
            }
        }
    }
}
