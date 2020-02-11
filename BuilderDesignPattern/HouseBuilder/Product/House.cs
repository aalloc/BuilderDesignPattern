using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.HouseBuilder.Product
{
    public class House : IHousePlan
    {
        private string Basement { get; set; }
        private string Interior { get; set; }
        private string Roof { get; set; }
        private string Structure { get; set; }

        public void SetBasement(string basement)
        {
            this.Basement = basement;
        }

        public void SetInterior(string interior)
        {
            this.Interior = interior;
        }

        public void SetRoof(string roof)
        {
            Roof = roof;
        }

        public void SetStructure(string structure)
        {
            Structure = structure;
        }

    }
}
