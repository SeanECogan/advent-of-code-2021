namespace advent_of_code_2021.Solvers.Day02.PuzzleB
{
    public static class Solver
    {
        public static int Solve(List<string> inputLines)
        {
            var instructions = inputLines;

            var horizontalPosition = 0;
            var verticalPosition = 0;
            var aim = 0;

            foreach (var instruction in instructions)
            {
                var instructionParts = instruction.Split(" ");

                switch (instructionParts[0].ToLower())
                {
                    case "forward":
                        var increase = Convert.ToInt32(instructionParts[1]);
                        horizontalPosition += increase;
                        verticalPosition += aim * increase;
                        break;

                    case "up":
                        aim -= Convert.ToInt32(instructionParts[1]);
                        break;

                    case "down":
                        aim += Convert.ToInt32(instructionParts[1]);
                        break;

                    default:
                        break;
                }
            }

            return horizontalPosition * verticalPosition;
        }
    }
}