# Martian Robots
Martian Robots Challenge for Red Badger

This is a C# .NET Core project.

## How to Run:
1. Download the appropriate .NET SDK for your operating system from https://dotnet.microsoft.com/en-us/download 
2. Download and unzip the code
3. Go to the project root folder from the command line
4. **To Run the Code**, type into the command line (without quotes): "dotnet run --project:./MartianRobots"
5. **To Run the Tests**, type into the command line (without quotes): "dotnet test"

## Problem:
The surface of Mars can be modelled by a rectangular grid around which robots are able to move according to instructions provided from Earth. 

A robot position consists of a grid coordinate (a pair of integers: x-coordinate followed by y-coordinate) and an orientation (N, S, E, W for north, south, east, and west)

A robot instruction is a string of the letters “L”, “R”, and “F” which represent, respectively, the instructions:
  - Left : the robot turns left 90 degrees and remains on the current grid point.
  - Right : the robot turns right 90 degrees and remains on the current grid point.
  - Forward : the robot moves forward one grid point in the direction of the current orientation and maintains the same orientation.
  
The direction North corresponds to the direction from grid point (x, y) to grid point (x, y+1).

Since the grid is rectangular and bounded, a robot that moves “off” an edge of the grid is lost forever. However, lost robots leave a robot “scent” that prohibits future robots from dropping off the world at the same grid point. The scent is left at the last grid position the robot occupied before disappearing over the edge. An instruction to move “off” the world from a grid point from which a robot has been previously lost is simply ignored by the current robot.

## Input:
The first line of input is the upper-right coordinates of the rectangular world, the lower-left coordinates are assumed to be 0, 0.

The remaining input consists of a sequence of robot positions and instructions (two lines per robot). A position consists of two integers specifying the initial coordinates of the robot and an orientation (N, S, E, W), all separated by whitespace on one line. A robot instruction is a string of the letters “L”, “R”, and “F” on one line.

Each robot is processed sequentially.

The maximum value for any coordinate is 50.
All instruction strings will be less than 100 characters in length.

## Output:
Shows the final grid position and orientation of the robot. If a robot falls off the edge of the grid the word “LOST” is printed after the position and orientation

## Future Improvements:
- Decrease dependency between `Grid` and `Robot`, perhaps using interfaces.
- Make `Grid` more cohesive by moving scent logic out, perhaps to robot or make it more generic (e.g. generic "entities" held in Grid, with type 'Scent')
- Accept user input from program arguments
- More tests for Scent logic, more coverage









