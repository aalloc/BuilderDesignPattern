using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderDesignPattern.HouseBuilder.Product;

namespace BuilderDesignPattern.HouseBuilder.Builder
{
    public class ElegantHouseBuilder : IHouseBuilder
    {
        House _house;
        public ElegantHouseBuilder()
        {
            _house = new House();
        }
        public void BuildBasement()
        {
            _house.SetBasement("Concrete Tiled Basement");
        }

        public void BuildInterior()
        {
            _house.SetInterior("Elegant Interior");
        }

        public void BuildRoof()
        {
            _house.SetRoof("Asbestos Roofing");
        }

        public void BuildStructure()
        {
            _house.SetStructure("Concrete Structure");
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}
