using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderDesignPattern.HouseBuilder.Product;

namespace BuilderDesignPattern.HouseBuilder.Builder
{
    public class KuboHouseBuilder : IHouseBuilder
    {
        private House _house;
        public KuboHouseBuilder()
        {
            _house = new House();
        }

        public void BuildBasement()
        {
            _house.SetBasement("Silong");
        }

        public void BuildInterior()
        {
            _house.SetInterior("Straw Walls and flooring");
        }

        public void BuildRoof()
        {
            _house.SetRoof("Nipa roof");
        }

        public void BuildStructure()
        {
            _house.SetStructure("Kawayan");
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}
