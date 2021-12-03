namespace advent_of_code_2021.Solvers.Day03.PuzzleB
{
    public static class Solver
    {
        public static int Solve(List<string> inputLines)
        {
            var binaryStrings = inputLines;
            var binaryStringLength = binaryStrings.FirstOrDefault()?.Length;

            if (binaryStringLength.HasValue && binaryStringLength.Value > 0)
            {
                var oxygenGeneratorRating = FindOxygenGeneratorRating(
                    binaryStrings,
                    binaryStringLength.Value);

                var co2ScrubberRating = FindCO2ScrubberRating(
                    binaryStrings,
                    binaryStringLength.Value);

                return oxygenGeneratorRating * co2ScrubberRating;
            }
            else
            {
                return 0;
            }
        }

        private static int FindOxygenGeneratorRating(
            List<string> binaryStrings,
            int binaryStringLength)
        {
            var filteredBinaryStrings = binaryStrings;

            for (var i = 0; i < binaryStringLength; i++)
            {
                var onesCount = filteredBinaryStrings.Select(fbs => fbs[i]).Where(c => c == '1').Count();
                var zeroesCount = filteredBinaryStrings.Select(fbs => fbs[i]).Where(c => c == '0').Count();

                if (onesCount >= zeroesCount)
                {
                    filteredBinaryStrings = filteredBinaryStrings.Where(fbs => fbs[i] == '1').ToList();
                }
                else
                {
                    filteredBinaryStrings = filteredBinaryStrings.Where(fbs => fbs[i] == '0').ToList();
                }

                if (filteredBinaryStrings.Count == 1)
                {
                    break;
                }
            }

            return Convert.ToInt32(filteredBinaryStrings.FirstOrDefault(), 2);
        }

        private static int FindCO2ScrubberRating(
            List<string> binaryStrings,
            int binaryStringLength)
        {
            var filteredBinaryStrings = binaryStrings;

            for (var i = 0; i < binaryStringLength; i++)
            {
                var onesCount = filteredBinaryStrings.Select(fbs => fbs[i]).Where(c => c == '1').Count();
                var zeroesCount = filteredBinaryStrings.Select(fbs => fbs[i]).Where(c => c == '0').Count();

                if (onesCount >= zeroesCount)
                {
                    filteredBinaryStrings = filteredBinaryStrings.Where(fbs => fbs[i] == '0').ToList();
                }
                else
                {
                    filteredBinaryStrings = filteredBinaryStrings.Where(fbs => fbs[i] == '1').ToList();
                }

                if (filteredBinaryStrings.Count == 1)
                {
                    break;
                }
            }

            return Convert.ToInt32(filteredBinaryStrings.FirstOrDefault(), 2);
        }
    }
}