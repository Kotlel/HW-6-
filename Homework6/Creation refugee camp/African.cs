using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_refugee_camp
{
    internal class African : ManFleeingDisaster
    {
        public string tribe;
        public string reasonsFleeing;
        public string language;
        public int diamondCount;
        public African(string name, int age, string livingSpot, string disease, string tribe, string reasonsFleeing, string language, int diamondCount)
        {
            this.tribe = tribe;
            this.reasonsFleeing = reasonsFleeing;
            this.language = language;
            this.diamondCount = diamondCount;
        }

        public override void Placed()
        {
            Console.WriteLine($"{name} перемещён в блок соплеменников");
        }
        public override void Treatment()
        {
            Console.WriteLine($"{name} проходится излечение");
        }
    }
}
