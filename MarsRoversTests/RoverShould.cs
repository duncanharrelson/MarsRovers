using MarsRovers;
using System;
using Xunit;


namespace MarsRoversTests
{
    public class RoverShould
    {
        [Fact]
        public void FaceLeft()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.FaceLeft();
            //assert
            Console.WriteLine(rover.facing);
            Assert.True(rover.facing == "W");
        }

        [Fact]
        public void FaceRight()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.FaceRight();
            //assert
            Console.WriteLine(rover.facing);
            Assert.True(rover.facing == "E");
        }

        [Fact]
        public void StepForward()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.StepForward();
            //assert
            Assert.True(rover.y == 3);
        }

        [Fact]
        public void Move()
        {
            //arrange
            Rover rover = new Rover("3 3 E");
            //act
            rover.Move("MMRMMRMRRM");
            //assert
            Assert.True(rover.x == 5 && rover.y == 1 && rover.facing == "E");
        }
    }
}