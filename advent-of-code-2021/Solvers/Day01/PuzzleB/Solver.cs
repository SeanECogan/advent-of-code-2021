namespace advent_of_code_2021.Solvers.Day01.PuzzleB
{
    public static class Solver
    {
        public static int Solve(List<string> inputLines)
        {
            var depthReadings = inputLines.Select(il => Convert.ToInt32(il)).ToList();

            var numberOfIncreases = 0;

            var previousReading = Int32.MaxValue;

            var currentDepthIndex = 0;

            for (currentDepthIndex = 0; currentDepthIndex < (depthReadings.Count - 2); currentDepthIndex++)
            {
                var currentReading = depthReadings[currentDepthIndex] + depthReadings[currentDepthIndex + 1] + depthReadings[currentDepthIndex + 2];

                if (currentReading > previousReading)
                {
                    numberOfIncreases++;
                }

                previousReading = currentReading;
            }

            return numberOfIncreases;
        }
    }
}