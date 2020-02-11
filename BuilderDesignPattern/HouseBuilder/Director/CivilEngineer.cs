using BuilderDesignPattern.HouseBuilder.Builder;
using BuilderDesignPattern.HouseBuilder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.HouseBuilder.Director
{
    public class CivilEngineer
    {
        private IHouseBuilder _houseBuilder;
        public CivilEngineer(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }
        public House GetHouse()
        {
            return this._houseBuilder.GetHouse();
        }
        public void ConstructHouse()
        {
            _houseBuilder.BuildBasement();
            _houseBuilder.BuildInterior();
            _houseBuilder.BuildStructure();
            _houseBuilder.BuildRoof();
        }
    }
}
