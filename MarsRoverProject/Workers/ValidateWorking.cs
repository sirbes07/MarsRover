using MarsRoverProject.Model;
using MarsRoverProject.ValidateRequirements;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProject.Workers
{
    public static class ValidateWorking
    {
        public static bool IsPlatoAndMovingAvailable(Position position, Plateau plateu)
        {
            return ((StaticRequirements.MIN_HEIGHT <= position.y && StaticRequirements.MIN_WIDTH <= position.x) && (position.x <= plateu.width && position.y <= plateu.height));
        }
    }
}
