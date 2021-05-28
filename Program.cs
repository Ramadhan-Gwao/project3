using System;

namespace project3
{
    class Program
    {
        static string[] allPlanets = {"Mercury","Mars","Saturn","Uranus"};
        static double[] earthTimePlanets = {0.2408467,1.8808158,29.447498,84.016846};
        static double humanTime = 631154000;
        static double orbitalPeriodDays = 365.25;
        static int orbitalPeriodSec = 31557600;
        static void Main(string[] args)
        {
            double result = calculateAge(humanTime);
            double result1 = calculateEarthAge(result);
            var planets = calculatePlanetsage(earthTimePlanets,result);
            for (var i = 0; i < planets.Length; i++)
            {
                Console.WriteLine($"Earth Age: {result1} Earth-years old    Age: {planets[i]} {allPlanets[i]}-years old");
            }
        }
        static double calculateAge(double age)
        {
            double result = (age*orbitalPeriodDays)/orbitalPeriodSec;   
            return result;
        }
        static double calculateEarthAge(double age)
        {
            double result1 = Math.Floor(age/orbitalPeriodDays);
            return result1;
        }
        static double[] calculatePlanetsage(double[] age,double time)
        {  
            double[] result = new Double[4];
            for (var i = 0; i < earthTimePlanets.Length; i++)
            {
                result[i] = Math.Floor(time/age[i]);
            }
            return result;
        }
    }
}
