namespace advent_of_code_2021.Solvers.Day07.PuzzleB
{
    public class Solver
    {
        public static long Solve(string inputLine)
        {
            var crabPositions = inputLine.Split(",").Select(c => Convert.ToInt32(c)).ToList();
            var minPosition = crabPositions.Min();
            var maxPosition = crabPositions.Max();

            var fuelCosts = new List<FuelCost>();

            for (var i = minPosition; i <= maxPosition; i++)
            {
                var totalFuelCost = crabPositions.Select(cp => SumAllNumbersInRange(Math.Abs(cp - i))).Sum();

                fuelCosts.Add(new FuelCost(i, totalFuelCost));
            }

            return fuelCosts.Select(fc => fc.TotalFuelCost).Min();
        }

        private static int SumAllNumbersInRange(int range)
        {
            var total = 0;

            for (var i = 1; i <= range; i++)
            {
                total += i;
            }

            return total;
        }

        private class FuelCost
        {
            public FuelCost(int position, int totalFuelCost)
            {
                Position = position;
                TotalFuelCost = totalFuelCost;
            }

            public int Position { get; set; }
            public int TotalFuelCost { get; set; }
        }
    }
}