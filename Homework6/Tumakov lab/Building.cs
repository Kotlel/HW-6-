using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_lab
{
    class Building
    {
        static int buildingNumCounter;
        int buildingNum;
        int buildingHeight;
        int buildingFloor;
        int apartmentsCount;
        int entranceCount;
        public Building(int buildingHeight, int buildingFloor, int apartmentsCount, int entranceCount)
        {
            if (buildingHeight > 0 && buildingFloor > 0 && apartmentsCount > 0 && entranceCount > 0 && ((double)apartmentsCount/buildingFloor/entranceCount) % 1 == 0)
            {
                this.buildingNum = buildingNumCounter ++;
                this.buildingHeight = buildingHeight;
                this.buildingFloor = buildingFloor;
                this.apartmentsCount = apartmentsCount;
                this.entranceCount = entranceCount;
            }
            else { Console.WriteLine("Введите данные правильно. Параметры целые числа больше нуля, а количество квартир на каждом этаже, каждого подъезда одинаково"); }
        }
        public string GetFullInfo()
        {
            if (buildingFloor == 0)
            {
                return "Здание не прошло проверку на существование";
            }
            else { return $"Номер дома {buildingNum}, Высота {buildingHeight}, Этажей {buildingFloor}, Квартир {apartmentsCount}, Подъездов {entranceCount}"; }
        }
        public string HeightOfFloor()
        {
            if (buildingFloor == 0)
            {
                return "Здание не прошло проверку на существование";
            }
            else { return $"Высота этажа {((double)buildingHeight / buildingFloor)}"; }
        }
        public string CountOfFloorApartmentsInEntrance()
        {
            if (buildingFloor == 0)
            {
                return "Здание не прошло проверку на существование";
            }
            else { return $"Количество квартир на этаже {apartmentsCount / buildingFloor / entranceCount}"; }
        }
        public string CountOfEntranceApartments()
        {
            if (buildingFloor == 0)
            {
                return "Здание не прошло проверку на существование";
            }
            else { return $"Количество квартир в подъезде {apartmentsCount / entranceCount}"; }
        }
    }
}
