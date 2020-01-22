using MarsRoverProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProject.Workers
{
    public static class MovingHelper
    {
        public static void SetPosition(this Rover rover, int x, int y, DirectionStatus direction)
        {
            if (rover.position == null)
            {
                rover.position = new Position(x, y);
            }
            else
            {
                rover.position.x = x;
                rover.position.y = y;
            }

            rover.directionStatus = direction;
        }

        public static string LastPosition(this Rover rover)
        {
            return rover.position.x + " " + rover.position.y + " " + rover.directionStatus;
        }

        public static void AllProcessDiagram(this Rover rover, string allCommand)
        {
            for (int i = 0; i < allCommand.Length; i++)
            {
                RunRover(rover,allCommand[i]);
            }
        }

        public static void RunRover(this Rover rover, char command)
        {
            if ('L' == command)
                TurnLeft(rover);
            else if ('R' == command)
                TurnRight(rover);
            else if ('M' == command)
            {
                if (!Move(rover))
                    Console.WriteLine("Not allowed existing area!");
            }
        }

        public static bool Move(this Rover rover)
        {
            if (!ValidateWorking.IsPlatoAndMovingAvailable(rover.position, rover.plateu))
            {
                return false;
            }
            switch (rover.directionStatus)
            {
                case DirectionStatus.N:
                    rover.position.y += 1;
                    break;
                case DirectionStatus.E:
                    rover.position.x += 1;
                    break;
                case DirectionStatus.S:
                    rover.position.y -= 1;
                    break;
                case DirectionStatus.W:
                    rover.position.x -= 1;
                    break;
            }

            return true;
        }


        public static void TurnLeft(this Rover rover)
        {
            switch (rover.directionStatus)
            {
                case DirectionStatus.W:
                    rover.directionStatus = DirectionStatus.S;
                    break;
                case DirectionStatus.E:
                    rover.directionStatus = DirectionStatus.N;
                    break;
                case DirectionStatus.S:
                    rover.directionStatus = DirectionStatus.E;
                    break;
                case DirectionStatus.N:
                    rover.directionStatus = DirectionStatus.W;
                    break;
            }
        }

        public static void TurnRight(this Rover rover)
        {
            switch (rover.directionStatus)
            {
                case DirectionStatus.W:
                    rover.directionStatus = DirectionStatus.N;
                    break;
                case DirectionStatus.E:
                    rover.directionStatus = DirectionStatus.S;
                    break;
                case DirectionStatus.S:
                    rover.directionStatus = DirectionStatus.W;
                    break;
                case DirectionStatus.N:
                    rover.directionStatus = DirectionStatus.E;
                    break;
            }
        }
    }
}
