using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_refugee_camp
{
    public abstract class ManFleeingDisaster
    {
        public string name;
        public int age;
        public string liveSpot;
        public string disease;
        public ManFleeingDisaster(string name, int age, string livespot, string disease)
        {
            this.name = name;
            this.age = age;
            this.liveSpot = livespot;
            this.disease = disease;
        }
        public abstract void Placed();
        public abstract void Treatment();
        public string GetInfo()
        {
            return $"Имя {name}, Возраст {age}, Травма {liveSpot}, Заболевание {disease}";
        }
        public void Infection(string newDisease)
        {
            disease = newDisease;
        }
        public void Relocation(string newSpot)
        {
            liveSpot = newSpot;
        }

    }
}
