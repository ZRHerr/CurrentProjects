using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameProj
{
    public class PlanetGenerator
    {

        public static List<SolarSystem> SomeGuysSky()
        {
            string systemName = "";
            string planetName = "";
            int numberOfPlanets = 0;
            double x = 0.0;
            double y = 0.0;
            double multiplier = 0.0;
            Random rnd = new Random();
            List<Planet>[] listOfPlanets = new List<Planet>[100];
            List<double[]> coordinates = new List<double[]>();
            List<SolarSystem> universe = new List<SolarSystem>();
            int planetCount = 0;

            // Populates the univrse with 50 planetary systems, each one of which have up to 10 planets. 
            for (int i = 0; i < 100; i++)
            {
                // Generating a random name for a system
                char letter = (char)rnd.Next(65, 90);
                int number = rnd.Next(999);
                systemName = letter + Convert.ToString(number);
                if (number <= 250)
                {
                    //Console.WriteLine("This is an icy solar system");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (number <= 500 || number >= 251)
                {
                    /*Console.WriteLine("This is a hot solarsystem");*/
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (number <= 750 || number >= 501)
                {
                    //Console.WriteLine("This is a gassy solarsystem (eww, stinky!)");
                    Console.ForegroundColor = ConsoleColor.Green;

                }
                else if (number <= 999 || number >= 751)
                {
                    //Console.WriteLine("This is a greasy solarsystem (GROSS!)");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine("This is an Earth-like solarsystem");
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                // Generating coordinates for the planetary system
                x = Math.Round(rnd.NextDouble() * 100.0 - 50.0, 4);
                y = Math.Round(rnd.NextDouble() * 100.0 - 50.0, 4);

                // Generating a list of planets for the system 
                listOfPlanets[i] = new List<Planet>();
                numberOfPlanets = rnd.Next(1, 10);
                for (int j = 0; j < numberOfPlanets; j++)
                {
                    if (i == 0)
                    {
                        //Create a SolarSystem
                        numberOfPlanets = 8;
                        string[] solarSystemPlanets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
                        double[,] ssCoordinates = new double[,] { { 0.0, -0.0039 }, { 0.0, -0.0030 }, { 0.0, 0.0 }, { 0.0, 0.004 }, { 0.0, 0.0078 }, { 0.0, 0.0105 }, { 0.0, 0.015 }, { 0.0, 0.023 } };
                        multiplier = 1;
                        listOfPlanets[i].Add(new Planet(solarSystemPlanets[j], new double[] { ssCoordinates[j, 0], ssCoordinates[j, 1] }, multiplier));
                    }
                    else
                    {
                        // creates an array of coordinates for the planet and adds it to the list of coordinates
                        coordinates.Add(new double[2]);
                        // Generating a random name for a system
                        planetName = systemName + "-" + Convert.ToString(j + 1);
                        // Generating coordinates within .005 lightyear radius around the system center. 
                        x = x + Math.Round((rnd.NextDouble() * .01 - .005), 4);
                        y = y + Math.Round((rnd.NextDouble() * .01 - .005), 4);
                        coordinates[planetCount][0] = x;
                        coordinates[planetCount][1] = y;
                        // Generating a random number between 0.5 and 2.0
                        multiplier = rnd.NextDouble() * (2.0 - 0.5) + 0.5;
                        // adds the created planet to the list of planets
                        listOfPlanets[i].Add(new Planet(planetName, coordinates[planetCount], multiplier));
                        planetCount++;
                    }
                }
                // adds the created planetary system to the universe
                universe.Add(new SolarSystem(systemName, numberOfPlanets, listOfPlanets[i]));
            }
            return universe;
        }

        // Identifies the Planets within reach with the current fuel level 
        public List<Planet> ReachablePlanets(List<SolarSystem> universe)
        {
            double maxRange = 0.0;
            List<Planet> reachablePlanets = new List<Planet>();

            // 1 ton of fuel is spent to travel 1 lightyear, regardless of the ship's model
            maxRange = character.GetFuel();
            // loops through all planets and creates a list of all the reachable ones
            for (int i = 0; i < universe.Count(); i++)
            {
                for (int j = 0; j < universe[i].GetPlanets().Count(); j++)
                {
                    // Ensures that the current location is not listed
                    if (universe[i].GetPlanets()[j].GetName() != character.GetLocation().GetName())
                    {
                        // Compares the distance of the next planet on the list to the maximum distance possible to travel with current fuel level
                        if (character.GetDistance(character.GetLocation().GetCoordinates(), universe[i].GetPlanets()[j].GetCoordinates()) <= maxRange)
                        {
                            reachablePlanets.Add(universe[i].GetPlanets()[j]);
                        }
                    }
                }
            }
            return reachablePlanets;
        }
        Character character = new Character();
    }
}
