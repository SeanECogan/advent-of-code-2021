namespace advent_of_code_2021.Solvers.Day01.PuzzleA
{
    public static class Solver
    {
        public static int Solve(List<string> inputLines)
        {
            var depthReadings = inputLines.Select(il => Convert.ToInt32(il));

            var numberOfIncreases = 0;

            var previousReading = Int32.MaxValue;

            foreach (var depthReading in depthReadings)
            {
                if (depthReading > previousReading)
                {
                    numberOfIncreases++;
                }

                previousReading = depthReading;
            }

            return numberOfIncreases;
        }
    }
}