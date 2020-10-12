using CodeBlogFitness.BL.Controller;
using CodeBlogFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App CodeBlogFitness welcomes you!");
            
            Console.WriteLine("Enter username:");
            var name = Console.ReadLine();

            Console.WriteLine("Enter gender:");
            var gender = Console.ReadLine();

            Console.WriteLine("Enter birdth day:");
            var birdthDate = DateTime.Parse(Console.ReadLine()); //TODO rwfactor this!

            Console.WriteLine("Enter weight:");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height:");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birdthDate, weight, height);
            userController.Save();
        }
    }
}
