using BuilderDesignPattern.HouseBuilder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.HouseBuilder.Builder
{
    public interface IHouseBuilder
    {
        void BuildBasement();
        void BuildRoof();
        void BuildStructure();
        void BuildInterior();
        House GetHouse();
    }
}
