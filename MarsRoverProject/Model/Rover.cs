using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProject.Model
{
    public class Rover
    {
        public  Plateau plateu;
        public  Position position;
        public  DirectionStatus directionStatus;

        public Rover(Plateau plateu,Position position,DirectionStatus directionStatus)
        {
            this.plateu = plateu;
            this.position = position;
            this.directionStatus = directionStatus;
        }
    }
}
