using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    abstract class Vehicles
    {
        private static string Name;

        public static string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public static int X { get; set; }
        public static int Y { get; set; }
        public Vehicles()
        {
            Name = "000";
            X = 0;
            Y = 0;
        }
        abstract public int Left(int Number);
        abstract public int Right(int Number);
        abstract public int Forward(int Number);
        abstract public int Back(int Number);
        abstract public void Print();
    }

    class Earth : Vehicles
    {
        public static string Movement;
        public override void Print()
        {
            Console.WriteLine("Наземный транспорт с двигателем {0} {1} {2} {3} {4} {5}", GyroScooter.name, Motorcycle.name, Car.name, ATV.name,
                Bus.name, Train.name);
            Console.WriteLine("Имеет положение {0},{1} {2},{3} {4},{5} {6},{7} {8},{9} {10},{11}", GyroScooter.X, GyroScooter.Y, Motorcycle.X, Motorcycle.Y,
                Car.X, Car.Y, ATV.X, ATV.Y, Bus.X, Bus.Y, Train.X, Train.Y);
            Console.WriteLine("Наземный транспорт без двигателя {0} {1} {2} {3}", Scooter.name, Bicycle.name, Horse.name, Elephant.name);
            Console.WriteLine("Имеет положение {0},{1} {2},{3} {4},{5} {6},{7}", Scooter.X, Scooter.Y, Bicycle.X, Bicycle.Y, Horse.X,
                Horse.Y, Elephant.X, Elephant.Y);
        }
        public override int Right(int Number)
        {
            int result = X + Number;
            return result;
        }
        public override int Left(int Number)
        {
            int result = X - Number;
            return result;
        }
        public override int Back(int Number)
        {
            int result = Y - Number;
            return result;
        }
        public override int Forward(int Number)
        {
            int result = Y + Number;
            return result;
        }
        public Earth()
        {
            Movement = "Сила";
            Y = 0;
        }
    }

    class HumanEarth : Earth
    {
        public HumanEarth()
        {
            Movement = "от человеческих ног";
        }
    }
    class Scooter : HumanEarth
    {
        public Scooter()
        {
            name = "Самокат";
            X = 124;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Наземный транпорт {0} не имеет двигателя, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    }
    class Bicycle : HumanEarth
    {
        public Bicycle()
        {
            name = "Велосипед";
            X = 349;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Наземный транпорт {0} не имеет двигателя, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    }

    class MachineEarth : Earth
    {
        public string Wheels;
        public MachineEarth()
        {
            Movement = "от двигателя";
            Wheels = "0 колес";
        }
    }
    class TwoWheels : MachineEarth
    {
        public TwoWheels()
        {
            Wheels = "2 колеса";
        }
    }
    class GyroScooter : TwoWheels
    {
        public GyroScooter()
        {
            name = "Гироскутер";
            X = 345;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Наземный транпорт {0} имеет двигатель, имеет положение {1},{2}, движение {3}, имеет {4}",
                name, X, Y, Movement, Wheels);
        }
    }
    class Motorcycle : TwoWheels
    {
        public Motorcycle()
        {
            name = "Мотоцикл";
            X = 123;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Наземный транпорт {0} имеет двигатель, имеет положение {1},{2}, движение {3}, имеет {4}",
                name, X, Y, Movement, Wheels);
        }
    }
    class FourWheels : MachineEarth
    {
        public FourWheels()
        {
            Wheels = "4 колеса";
        }
    }
    class Car : FourWheels
    {
        public Car()
        {
            name = "Автомобиль";
            X = 972;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Наземный транпорт {0} имеет двигатель, имеет положение {1},{2}, движение {3}, имеет {4}",
                name, X, Y, Movement, Wheels);
        }
    }
    class ATV : FourWheels
    {
        public ATV()
        {
            name = "Квадроцикл";
            X = 567;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Наземный транпорт {0} имеет двигатель, имеет положение {1},{2}, движение {3}, имеет {4}",
                name, X, Y, Movement, Wheels);
        }
    } //Квадроцикл
    class MoreWheels : MachineEarth
    {
        public MoreWheels()
        {
            Wheels = "более 4-х колес";
        }
    }
    class Bus : MoreWheels
    {
        public Bus()
        {
            name = "Автобус";
            X = 439;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Наземный транпорт {0} имеет двигатель, имеет положение {1},{2}, движение {3}, имеет {4}",
                name, X, Y, Movement, Wheels);
        }
    }
    class Train : MoreWheels
    {
        public Train()
        {
            name = "Поезд";
            X = 1267;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Наземный транпорт {0} имеет двигатель, имеет положение {1},{2}, движение {3}, имеет {4}",
                name, X, Y, Movement, Wheels);
        }
    }

    class Animal : Earth
    {
        public Animal()
        {
            Movement = "от природы";
        }
    }
    class Horse : Animal
    {
        public Horse()
        {
            name = "Лошадь";
            X = 100;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Наземный транпорт {0} не имеет двигателя, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    }
    class Elephant : Animal
    {
        public Elephant()
        {
            name = "Слон";
            X = 2987;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Наземный транпорт {0} не имеет двигателя, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    }

    class Air : Vehicles
    {
        public static string Movement;
        public override void Print()
        {
            Console.WriteLine("Воздушный транспорт с двигателем {0} {1}", Airplane.name, Helicopter.name);
            Console.WriteLine("Имеет положение {0},{1} и {2},{3}", Airplane.X, Airplane.Y, Helicopter.X, Helicopter.Y);
            Console.WriteLine("Воздушный транспорт без двигателя {0} {1}", AirBalloon.name, HangGlider.name);
            Console.WriteLine("Имеет положение {0},{1} и {2},{3}", AirBalloon.X, AirBalloon.Y, HangGlider.X, HangGlider.Y);
        }
        public override int Right(int Number)
        {
            int result = X + Number;
            return result;
        }
        public override int Left(int Number)
        {
            int result = X - Number;
            return result;
        }
        public override int Back(int Number)
        {
            int result = Y - Number;
            return result;
        }
        public override int Forward(int Number)
        {
            int result = Y + Number;
            return result;
        }
        public Air()
        {
            Movement = "Сила";
            Y = 5;
        }
    }

    class WithoutEngine : Air
    {
        public WithoutEngine()
        {
            Movement = "от ветра";
        }
    }
    class AirBalloon : WithoutEngine
    {
        public AirBalloon()
        {
            name = "Воздушный шар";
            X = 3;
            Y = 11;
        }
        public override void Print()
        {
            Console.WriteLine("Воздушный транпорт {0} не имеет двигателя, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    }
    class HangGlider : WithoutEngine
    {
        public HangGlider()
        {
            name = "Дельтаплан";
            X = 7;
            Y = 10;
        }
        public override void Print()
        {
            Console.WriteLine("Воздушный транпорт {0} не имеет двигателя, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    } //Дельтаплан

    class WithEngine : Air
    {
        public WithEngine()
        {
            Movement = "от двигателя";
        }
    }
    class Airplane : WithEngine
    {
        public Airplane()
        {
            name = "Самолет";
            X = 43;
            Y = 212;
        }
        public override void Print()
        {
            Console.WriteLine("Воздушный транпорт {0} имеет двигатель, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    }
    class Helicopter : WithEngine
    {
        public Helicopter()
        {
            name = "Вертолет";
            X = 43;
            Y = 86;
        }
        public override void Print()
        {
            Console.WriteLine("Воздушный транпорт {0} имеет двигатель, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    }

    class Water : Vehicles
    {
        public static string Movement;
        public override void Print()
        {
            Console.WriteLine("Водный транспорт {0} {1} {2} {3} {4} {5}", CargoShip.name, WoodenBoat.name, RubberBoat.name, Liner.name,
                Yacht.name, Tanker.name);
            Console.WriteLine("Имеет положение {0},{1} {2},{3} {4},{5} {6},{7} {8},{9} {10},{11}", CargoShip.X, CargoShip.Y, WoodenBoat.X,
                WoodenBoat.Y, RubberBoat.X, RubberBoat.Y, Liner.X, Liner.Y, Yacht.X, Yacht.Y, Tanker.X, Tanker.Y);
        }
        public override int Right(int Number)
        {
            int result = X + Number;
            return result;
        }
        public override int Left(int Number)
        {
            int result = X - Number;
            return result;
        }
        public override int Back(int Number)
        {
            int result = Y - Number;
            return result;
        }
        public override int Forward(int Number)
        {
            int result = Y + Number;
            return result;
        }
        public Water()
        {
            Movement = "Сила";
            Y = 0;
        }
    }

    class CargoShip : Water
    {
        public CargoShip()
        {
            name = "Сухогруз";
            X = 256;
            Y = 0;
            Movement = "от двигателя";
        }
        public override void Print()
        {
            Console.WriteLine("Водный транпорт {0} перевозит грузы, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    }

    class Passenger : Water
    {

    }
    class HumanWater : Passenger
    {
        public HumanWater()
        {
            Movement = "от рук";
        }
    }
    class WoodenBoat : HumanWater
    {
        public WoodenBoat()
        {
            name = "Деревяная лодка";
            X = 286;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Водный транпорт {0} перевозит пассажиров, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    }
    class RubberBoat : HumanWater
    {
        public RubberBoat()
        {
            name = "Резиновая лодка";
            X = 987;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Водный транпорт {0} перевозит пассажиров, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    }
    class MachineWater : Passenger
    {
        public MachineWater()
        {
            Movement = "от двигателя";
        }
    }
    class Liner : MachineWater
    {
        public Liner()
        {
            name = "Лайнер";
            X = 398;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Водный транпорт {0} перевозит пассажиров, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    }
    class Yacht : MachineWater
    {
        public Yacht()
        {
            name = "Яхта";
            X = 456;
            Y = 0;
        }
        public override void Print()
        {
            Console.WriteLine("Водный транпорт {0} перевозит пассажиров, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    }

    class Tanker : Water
    {
        public Tanker()
        {
            name = "Танкер";
            X = 856;
            Y = 0;
            Movement = "от двигателя";
        }
        public override void Print()
        {
            Console.WriteLine("Водный транпорт {0} перевозит нефтепродукты, имеет положение {1},{2}, движение {3}",
                name, X, Y, Movement);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AirBalloon airBalloon = new AirBalloon();
            airBalloon.Print();
            HangGlider hangGlider = new HangGlider();
            hangGlider.Print();
            Airplane airplane = new Airplane();
            airplane.Print();
            Helicopter helicopter = new Helicopter();
            helicopter.Print();
            CargoShip cargoShip = new CargoShip();
            cargoShip.Print();
            WoodenBoat woodenBoat = new WoodenBoat();
            woodenBoat.Print();
            RubberBoat rubberBoat = new RubberBoat();
            rubberBoat.Print();
            Liner liner = new Liner();
            liner.Print();
            Yacht yacht = new Yacht();
            yacht.Print();
            Tanker tanker = new Tanker();
            tanker.Print();
            Scooter scooter = new Scooter();
            scooter.Print();
            Bicycle bicycle = new Bicycle();
            bicycle.Print();
            GyroScooter gyroScooter = new GyroScooter();
            gyroScooter.Print();
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Print();
            Car car = new Car();
            car.Print();
            ATV aTV = new ATV();
            aTV.Print();
            Bus bus = new Bus();
            bus.Print();
            Train train = new Train();
            train.Print();
            Horse horse = new Horse();
            horse.Print();
            Elephant elephant = new Elephant();
            elephant.Print();
        }
    }
}
