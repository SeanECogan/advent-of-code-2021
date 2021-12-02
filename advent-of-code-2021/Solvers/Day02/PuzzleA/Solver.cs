namespace advent_of_code_2021.Solvers.Day02.PuzzleA
{
    public static class Solver
    {
        public static int Solve(List<string> inputLines)
        {
            var instructions = inputLines;

            var horizontalPosition = 0;
            var verticalPosition = 0;

            foreach (var instruction in instructions)
            {
                var instructionParts = instruction.Split(" ");

                switch (instructionParts[0].ToLower())
                {
                    case "forward":
                        horizontalPosition += Convert.ToInt32(instructionParts[1]);
                        break;

                    case "up":
                        verticalPosition -= Convert.ToInt32(instructionParts[1]);
                        break;

                    case "down":
                        verticalPosition += Convert.ToInt32(instructionParts[1]);
                        break;

                    default:
                        break;
                }
            }

            return horizontalPosition * verticalPosition;
        }
    }
}