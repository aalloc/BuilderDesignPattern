using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.CharacterBuilder.Product
{
    public interface ICharacterPlan
    {
        void SetGender();
        void SetName();
        void SetClass();
        void SetWeapon();
        void SetHelmet();
        void SetArmor();


            
    }
}
