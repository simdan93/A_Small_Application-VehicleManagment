using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SmallConsoleJSONApp
{
    public class Car
    {
        public int id { get; set; }
        public string licence_plate { get; set; }
        public double engine_power { get; set; }
        public double max_speed { get; set; }
        public string colour { get; set; }
        public string typeVehicle { get; set; }
        public bool canDrive { get; set; }
    }

    public class Plane
    {
        public int id { get; set; }
        public string registration { get; set; }
        public double engine_power { get; set; }
        public double wingspan { get; set; }
        public double load_capacity { get; set; }
        public double net_weight { get; set; }
        public string flying_class { get; set; }
        public bool canFly { get; set; }
    }

    public class Boat
    {
        public int id { get; set; }
        public string registration { get; set; }
        public double engine_power { get; set; }
        public double max_speed { get; set; }
        public double gross_tonnage { get; set; }
        public bool canSail { get; set; }
    }

    class ManageVehicles
    {
        public List<Car> MakeCars()
        {
            var RegisteredCars = new List<Car>
            {
                new Car { id = 0, licence_plate = "NF123456", engine_power = 147 , max_speed = 200 , colour = "green", typeVehicle = "Personal Vehicle", canDrive = false },
                new Car { id = 1, licence_plate = "NF654321", engine_power = 150 , max_speed = 195 , colour = "blue", typeVehicle = "Personal Vehicle", canDrive = false }
            };

            return RegisteredCars;
        }
        public void DisplayCarInfo(List<Car> RegisteredCars)
        {
            //Print out to console
            Console.WriteLine("Car details:");
            foreach (Car car in RegisteredCars)
            {
                Console.WriteLine("ID: {0}", car.id);
                Console.WriteLine("Licence plate: {0}", car.licence_plate);
                Console.WriteLine("Engine power: {0} kW ", car.engine_power);
                Console.WriteLine("Max speed: {0} km/h", car.max_speed);
                Console.WriteLine("Colour: {0}", car.colour);
                Console.WriteLine("Type: {0}", car.typeVehicle);
                Console.Write("Can car drive? ");
                if (car.canDrive == true)
                    Console.WriteLine("yes\n");
                else
                    Console.WriteLine("no\n");
            }

            //Convert to JSON
            string serializedResult = JsonConvert.SerializeObject(RegisteredCars, Formatting.Indented);

            //Print out in JSON-format
            Console.WriteLine("Car details in JSON-format:");
            Console.WriteLine("{0}", serializedResult);

            //Car deserializedProduct = JsonConvert.DeserializeObject<Car>(serializedResult);

            //Write list to file
            Console.Write("Uploads details to file... ");
            System.IO.File.WriteAllText(@"D:\workspace\small_test\JSON-files\cars.json", serializedResult);
            Console.WriteLine("uploaded.\n");
        }
        public void MatchCars(List<Car> cars)
        {
            string car1LicensPlate = "";
            string car2LicensPlate = "";

            /*Check if car 1 and car 2 has the same licenseplate */
            //Writes to console
            Console.WriteLine("Checking to see if the two cars have the same licensplate... ");
            foreach (Car car in cars)
            {
                if (car.id == 0)
                    car1LicensPlate = car.licence_plate;
                else if (car.id == 1)
                    car2LicensPlate = car.licence_plate;
                Console.WriteLine("Car {0} (Licensplate) = {1}", (car.id+1), car.licence_plate);
            }

            //Way 1 - check licence plate
            if (car1LicensPlate == car2LicensPlate)
                Console.Write("Licensplate are equal.");
            else
                Console.Write("Licensplate are not equal.\n\n");
        }

        public List<Plane> MakePlanes()
        {
            var RegisteredPlanes = new List<Plane>
            {
                new Plane { id = 0, registration = "LN1234", engine_power = 1000 , wingspan = 30, load_capacity = 2, net_weight = 10, flying_class = "Jet Plane", canFly = false }
            };

            return RegisteredPlanes;
        }
        public void DisplayPlaneInfo(List<Plane> RegisteredPlanes)
        {
            //Print out to console
            Console.WriteLine("Plane details for console:");
            foreach (Plane plane in RegisteredPlanes)
            {
                Console.WriteLine("ID: {0} ", plane.id);
                Console.WriteLine("Registration: {0}", plane.registration);
                Console.WriteLine("Engine power: {0} kW", plane.engine_power);
                Console.WriteLine("wingspan: {0}m", plane.wingspan);
                Console.WriteLine("load_capacitye: {0} tonns", plane.load_capacity);
                Console.WriteLine("net_weight: {0} tonns", plane.net_weight);
                Console.WriteLine("flying_class: {0}", plane.flying_class);
                Console.Write("Can plane fly? ");
                if (plane.canFly == true)
                    Console.WriteLine("yes\n");
                else
                    Console.WriteLine("no\n");
            }

            //Convert to JSON
            string serializedResult = JsonConvert.SerializeObject(RegisteredPlanes, Formatting.Indented);
            
            //Print out in JSON-format
            Console.WriteLine("Plane details in JSON-format:");
            Console.WriteLine("{0}", serializedResult);

            //Plane deserializedProduct = JsonConvert.DeserializeObject<Plane>(serializedResult);
            
            //Write list to file
            Console.Write("Uploads details to file... ");
            System.IO.File.WriteAllText(@"D:\workspace\small_test\JSON-files\planes.json", serializedResult);
            Console.WriteLine("uploaded.\n");
        }

        public List<Boat> MakeBoats()
        {
            var RegisteredBoats = new List<Boat>
            {
                new Boat { id = 0, registration = "ABC123", engine_power = 100, max_speed = 30, gross_tonnage = 500, canSail = false }
            };

            return RegisteredBoats;
        }
        public void DisplayBoatInfo(List<Boat> RegisteredBoats)
        {
            //Print out to console
            Console.WriteLine("Boat details for console:");
            foreach (Boat boat in RegisteredBoats)
            {
                Console.WriteLine("ID: {0}", boat.id);
                Console.WriteLine("Registration: {0}", boat.registration);
                Console.WriteLine("Engine power: {0} kW", boat.engine_power);
                Console.WriteLine("Max speed: {0} knot per hour", boat.max_speed);
                Console.WriteLine("Gross tonnage: {0} kg", boat.gross_tonnage);
                Console.Write("Can boat sail/drive? ");
                if (boat.canSail == true)
                    Console.WriteLine("yes\n");
                else
                    Console.WriteLine("no\n");
            }

            //Convert to JSON
            string serializedResult = JsonConvert.SerializeObject(RegisteredBoats, Formatting.Indented);

            //Print out in JSON-format
            Console.WriteLine("Boat details in JSON-format:");
            Console.WriteLine("{0}", serializedResult);

            //Boat deserializedProduct = JsonConvert.DeserializeObject<Boat>(serializedResult);
            
            //Write list to file
            Console.Write("Uploads details to file... ");
            System.IO.File.WriteAllText(@"D:\workspace\small_test\JSON-files\boats.json", serializedResult);
            Console.WriteLine("uploaded.\n");
        }

        static void Main(string[] args)
        {
            //Declare a name for our object in our main class
            ManageVehicles manage = new ManageVehicles();
            
            List<Car> cars = manage.MakeCars();
            //Makes two car objects
            manage.DisplayCarInfo(cars);
            //Displays the elements for each object
            manage.MatchCars(cars);
            //match the two cars to see if they have the same licens plate

            List<Plane> planes = manage.MakePlanes();
            //Makes a plane-object
            manage.DisplayPlaneInfo(planes);
            //Displays the elements for the object

            /* Set new values for the plane and car1 */
            foreach (Plane plane in planes)
            {
                if (plane.id == 0)
                    plane.canFly = true;
            }
            foreach (Car car in cars)
            {
                if(car.id == 0)
                    car.canDrive = true;
            }
            Console.WriteLine("Plane may now fly and car 1 may now drive.\n");
            //Display the new information
            manage.DisplayPlaneInfo(planes);
            manage.DisplayCarInfo(cars);

            List<Boat> boats = manage.MakeBoats();
            //Makes a boat-object
            manage.DisplayBoatInfo(boats);
            //Displays the elements for the object

            //Let the user press any key to exit the app
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
