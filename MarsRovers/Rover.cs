using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRovers;


namespace MarsRovers
{
    public class Rover
    {
        public int x;  // x coordinate
        public int y;  // y coordinate
        public string facing; // rover facing in cardinal direction (N, E, S, W)

        public Rover(string roverStartingPosition)
        {
            RoverStartingPosition = roverStartingPosition;

            x = Convert.ToInt32(RoverStartingPosition.Split(" ")[0]);
            y = Convert.ToInt32(RoverStartingPosition.Split(" ")[1]);
            facing = RoverStartingPosition.Split(" ")[2];
        }

        public string RoverStartingPosition { get; set; }
        public string RoverOneMovement { get; set; }

        //Changes facing 90 degrees to the left based on instruction L
        public void FaceLeft()
        {
            switch (facing)
            {
                case "N":
                    facing = "W";
                    break;
                case "E":
                    facing = "N";
                    break;
                case "S":
                    facing = "E";
                    break;
                case "W":
                    facing = "S";
                    break;
                default:
                    throw new ArgumentException("Improper input for facing.  Please use N, E, S, or W");
            }

        }

        //Changes facing 90 degrees to the right based on instruction R
        public void FaceRight()
        {
            switch (facing)
            {
                case "N":
                    facing = "E";
                    break;
                case "E":
                    facing = "S";
                    break;
                case "S":
                    facing = "W";
                    break;
                case "W":
                    facing = "N";
                    break;
                default:
                    throw new ArgumentException("Improper input for facing.  Please use N, E, S, or W");
            }
        }

        //Moves rover one space in direction facing on the x, y grid. y++ for north, x++ for east, y-- for south, x-- for west
        public void StepForward()
        {
            switch (facing)
            {
                case "N":
                    y++;
                    break;
                case "E":
                    x++;
                    break;
                case "S":
                    y--;
                    break;
                case "W":
                    x--;
                    break;
            }
        }

        public string Move(string roverCommand) // "LMLMLMLMM" or "MMRMMRMRRM"
        {
            //split command input into char array to process FaceLeft, FaceRight, and StepForward
            char[] commands = roverCommand.ToCharArray();

            //loop through array, calling appropriate function.  L = FaceLeft, R = FaceRight, M = StepForward
            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case 'L':
                        FaceLeft();
                        break;
                    case 'R':
                        FaceRight();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            return $"{x} {y} {facing}";
        }
    }
}
