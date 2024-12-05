using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task7_23();
            HomeTask_1();
        }
        static void Task_1()
        {
            Console.WriteLine("Предусмотреть методы для доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.");
            BankAccountOld myAccountOld = new BankAccountOld(158, 235555, AccountType.Savings);
            Console.WriteLine(myAccountOld.GetFullInfoOld());
        }
        static void Task7_23()
        {
            Console.WriteLine("Номер счета генерировался сам и был уникальным. Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной. Добавить в класс счет в банке два метода: снять со счета и положить на счет.");
            BankAccountNew myAccount = new BankAccountNew(235555, AccountType.Current);
            BankAccountNew myFriendAccount = new BankAccountNew(51651.647m, AccountType.Current);
            Console.WriteLine(myAccount.GetFullInfo());
            Console.WriteLine(myFriendAccount.GetFullInfo());
            myAccount.TakeMoney(5000000);
            myFriendAccount.AddMoney(124.345m);
            Console.WriteLine(myAccount.GetFullInfo());
            Console.WriteLine(myFriendAccount.GetFullInfo());
        }
        static void HomeTask_1()
        {
            Console.WriteLine("7.1 Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов). Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати. Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания, и предусмотреть метод, который увеличивал бы значение этого поля.");
            Building myBuilding = new Building(123, 12, 120, 2);
            Building myFriendBuilding = new Building(150, 13, 215, 5);
            Building myDogBuilding = new Building(3, 1, 1, 1);
            Console.WriteLine(myBuilding.GetFullInfo());
            Console.WriteLine(myFriendBuilding.GetFullInfo());
            Console.WriteLine(myDogBuilding.GetFullInfo());
            Console.WriteLine(myBuilding.HeightOfFloor());
            Console.WriteLine(myFriendBuilding.HeightOfFloor());
            Console.WriteLine(myBuilding.CountOfEntranceApartments());
            Console.WriteLine(myFriendBuilding.CountOfEntranceApartments());
            Console.WriteLine(myBuilding.CountOfFloorApartmentsInEntrance());
            Console.WriteLine(myFriendBuilding.CountOfFloorApartmentsInEntrance());
        }
    }
}
