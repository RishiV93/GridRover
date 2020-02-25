using RoverChallenge;
using System;
using System.Collections.Generic;
using Xunit;

namespace RoverChallengeTests
{
    public class GridHandlerTests
    {
        [Fact]
        public void RotateClockWiseReturnsNextDirection()
        {
            var intList = new List<int>() { 5, 5 };
            var grid = new GridHandler(intList);

            var newDirection = grid.Rotate(true, "N");

            Assert.Equal("E", newDirection);
        }

        [Fact]
        public void RotateAntiClockWiseReturnsNextDirection()
        {
            var intList = new List<int>() { 5, 5 };
            var grid = new GridHandler(intList);

            var newDirection = grid.Rotate(false, "N");

            Assert.Equal("W", newDirection);
        }
    }
}