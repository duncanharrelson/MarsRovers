using System;
using MarsRovers;

// Establish grid size through user input  (X * Y) squares.  Lower left is 0, 0 and boundary is X spaces right and Y spaces up.  Input as X Y.
// Take in rover default position through input (X Y Z) where Z is rover facing as N, E, S, W.  (Set up N, E, S, W as Enum)
// Command is String of characters given in format of LRM where L and R are to change facing 90 degrees left or right respectively and M moves forward one space.
// Fleet of two rovers in the problem statement.  Create scaling for number of Rovers beyond 2?
//          Input structured as:
//          one grid size,
//          Array of instructions for Rover1 [starting position Rover1, movement command Rover1],
//          Array of instructions for Rover2 [starting position Rover2, movement command Rover2]

// Output structured as X Y Z for Rover1 and X Y Z for Rover2

// Expected behavior:
// Rover should rotate left
// Rover should rotate right
// Rover should move forward, update current position
// Rover should go to 1 3 N

// Test Input looks like:
// Size: 5 5
// Rover1 Start: 1 2 N
// Rover1 Move: LMLMLMLMM
// Rover2 Start: 3 3 E
// Rover2 Move: MMRMMRMRRM

// Expected output:
// 1 3 N    <- Rover1
// 5 1 E    <- Rover2

namespace MarsRovers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter plateau size");
            string? boundary = Console.ReadLine();

            Console.WriteLine("Please enter Rover 1 starting location");
            string? roverOneStartingPosition = Console.ReadLine();
            
            Console.WriteLine("Please enter Rover 1 commands");
            string? roverOneMovement = Console.ReadLine();
            
            Console.WriteLine("Please enter Rover 2 starting location");
            string? roverTwoStartingPosition = Console.ReadLine();

            Console.WriteLine("Please enter Rover 2 commands");
            string? roverTwoMovement = Console.ReadLine();

            if (!string.IsNullOrEmpty(roverOneStartingPosition) && !string.IsNullOrEmpty(roverOneMovement))
            {
                Rover rover1 = new Rover(roverOneStartingPosition);
                Console.WriteLine(rover1.Move(roverOneMovement));
            }

            if (!string.IsNullOrEmpty(roverTwoStartingPosition) && !string.IsNullOrEmpty(roverTwoMovement))
            {
                Rover rover2 = new Rover(roverTwoStartingPosition);
                Console.WriteLine(rover2.Move(roverTwoMovement));
            }
        }
    }
}