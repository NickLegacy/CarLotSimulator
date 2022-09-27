using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var lot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var car1 = new Car();
                car1.Year = 2010;
                car1.Make = "Ford";
                car1.Model = "Focus";
                car1.EngineNoise = "Loud1";
                car1.HonkNoise = "Honk1";
                car1.IsDriveable = true;

            lot.Cars.Add(car1);

            var car2 = new Car()
            {
                Year = 2011,
                Make = "Toyota",
                Model = "Prius",
                EngineNoise = "Loud2",
                HonkNoise = "Honk2",
                IsDriveable = true,
            };

            lot.Cars.Add(car2);

            var car3 = new Car(2012, "Dodge", "Charger", "Loud3", "Honk3", false);

            lot.Cars.Add(car3);
            {
                
            }

            //*************BONUS*************//

            // Call Methods
            car1.MakeEngineNoise(car1.EngineNoise);
            car2.MakeEngineNoise(car2.EngineNoise);
            car3.MakeEngineNoise(car3.EngineNoise);

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
       
            }
        }
    }
}
