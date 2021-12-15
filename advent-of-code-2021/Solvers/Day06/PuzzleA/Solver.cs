namespace advent_of_code_2021.Solvers.Day06.PuzzleA
{
    public class Solver
    {
        public static long Solve(string inputLine, int numberOfDays)
        {
            var startingLanternFish = inputLine.Split(",").Select(c => Convert.ToInt32(c)).ToList();

            var lanternFishCountsByDay = new long[9];

            for (var l = 0; l < 9; l++)
            {
                lanternFishCountsByDay[l] = startingLanternFish.Where(slf => slf == l).Count();
            }

            for (var d = 0; d < numberOfDays; d++)
            {
                var lanternFishToAdd = lanternFishCountsByDay[0];

                lanternFishCountsByDay[0] = lanternFishCountsByDay[1];
                lanternFishCountsByDay[1] = lanternFishCountsByDay[2];
                lanternFishCountsByDay[2] = lanternFishCountsByDay[3];
                lanternFishCountsByDay[3] = lanternFishCountsByDay[4];
                lanternFishCountsByDay[4] = lanternFishCountsByDay[5];
                lanternFishCountsByDay[5] = lanternFishCountsByDay[6];
                lanternFishCountsByDay[6] = lanternFishCountsByDay[7];
                lanternFishCountsByDay[7] = lanternFishCountsByDay[8];
                lanternFishCountsByDay[8] = lanternFishToAdd;

                lanternFishCountsByDay[6] += lanternFishToAdd;
            }

            long lanternFishTotal = 0;

            for (var t = 0; t < 9; t++)
            {
                lanternFishTotal += lanternFishCountsByDay[t];
            }

            return lanternFishTotal;
        }
    }
}