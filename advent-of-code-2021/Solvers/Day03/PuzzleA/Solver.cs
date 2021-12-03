namespace advent_of_code_2021.Solvers.Day03.PuzzleA
{
    public static class Solver
    {
        public static int Solve(List<string> inputLines)
        {
            var binaryStrings = inputLines;
            var binaryStringLength = binaryStrings.FirstOrDefault()?.Length;

            var gammaRateBinaryString = string.Empty;
            var epsilonRateBinaryString = string.Empty;

            if (binaryStringLength.HasValue && binaryStringLength.Value > 0)
            {
                for (var i = 0; i < binaryStringLength.Value; i++)
                {
                    var onesCount = binaryStrings.Select(bs => bs[i]).Where(c => c == '1').Count();
                    var zeroesCount = binaryStrings.Select(bs => bs[i]).Where(c => c == '0').Count();

                    if (onesCount > zeroesCount)
                    {
                        gammaRateBinaryString += "1";
                        epsilonRateBinaryString += "0";
                    }
                    else
                    {
                        gammaRateBinaryString += "0";
                        epsilonRateBinaryString += "1";
                    }
                }

                var gammaRate = Convert.ToInt32(gammaRateBinaryString, 2);
                var epsilonRate = Convert.ToInt32(epsilonRateBinaryString, 2);

                return gammaRate * epsilonRate;
            }
            else
            {
                return 0;
            }
        }
    }
}