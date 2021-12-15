namespace advent_of_code_2021.Solvers.Day07.PuzzleA
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
                var totalFuelCost = crabPositions.Select(cp => Math.Abs(cp - i)).Sum();

                fuelCosts.Add(new FuelCost(i, totalFuelCost));
            }

            return fuelCosts.Select(fc => fc.TotalFuelCost).Min();
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