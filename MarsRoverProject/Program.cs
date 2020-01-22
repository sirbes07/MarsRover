using MarsRoverProject.Model;
using MarsRoverProject.Workers;
using System;

namespace MarsRoverProject
{
    class Program
    {      
        static void Main(string[] args)
        {
            Plateau plateau = new Plateau(5, 5);
            Position position = new Position(1, 2);


            Rover rover = new Rover(plateau, position, DirectionStatus.N);
            MovingHelper.AllProcessDiagram(rover, "LMLMLMLMM");
            Console.WriteLine(MovingHelper.LastPosition(rover)); // ====>> Must Be 1 3 N !


            MovingHelper.SetPosition(rover, 3, 3, DirectionStatus.E);
            MovingHelper.AllProcessDiagram(rover, "MMRMMRMRRM");
            Console.WriteLine(MovingHelper.LastPosition(rover)); // ====>> Must Be 5 1 E !

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
