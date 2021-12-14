namespace advent_of_code_2021.Solvers.Day04.PuzzleA
{
    public class Solver
    {
        public static int Solve(List<string> inputLines)
        {
            var bingoNumbers = inputLines[0]
                .Split(',')
                .Select(c => Convert.ToInt32(c))
                .ToList();

            var bingoBoards = ParseBingoBoards(inputLines.Skip(2).ToList());

            return PlayBingo(
                bingoNumbers,
                bingoBoards
            );
        }

        private static List<List<List<BingoCell>>> ParseBingoBoards(List<string> inputLines)
        {
            var bingoBoards = new List<List<List<BingoCell>>>();

            var currentBingoBoard = new List<List<BingoCell>>();

            foreach(var inputLine in inputLines)
            {
                if (string.IsNullOrWhiteSpace(inputLine))
                {
                    bingoBoards.Add(currentBingoBoard);

                    currentBingoBoard = new List<List<BingoCell>>();
                }
                else
                {
                    var numericInputLine = inputLine
                        .Split(null)
                        .Where(c => !string.IsNullOrWhiteSpace(c))
                        .Select(c => Convert.ToInt32(c))
                        .Select(n => new BingoCell(n))
                        .ToList();

                    currentBingoBoard.Add(numericInputLine);
                }
            }

            bingoBoards.Add(currentBingoBoard);

            return bingoBoards;
        }
    
        private static int PlayBingo(
            List<int> bingoNumbers,
            List<List<List<BingoCell>>> bingoBoards
        )
        {
            foreach (var bingoNumber in bingoNumbers)
            {
                // Mark number on each board.
                foreach (var bingoBoard in bingoBoards)
                {
                    foreach (var row in bingoBoard)
                    {
                        foreach (var cell in row)
                        {
                            if (cell.BingoNumber == bingoNumber)
                            {
                                cell.Marked = true;
                            }
                        }
                    }
                }
            
                // Check if any winners on each board.
                foreach (var bingoBoard in bingoBoards)
                {
                    if (AnyColumnsAreFilled(bingoBoard) || AnyRowsAreFilled(bingoBoard))
                    {
                        var unmarkedSum = GetSumOfUnmarkedCells(bingoBoard);
                        
                        return unmarkedSum * bingoNumber;
                    }
                }
            }

            return 0;
        }    

        private static bool AnyColumnsAreFilled(List<List<BingoCell>> bingoBoard)
        {
            var rowLength = bingoBoard.First().Count;

            for (var i = 0; i < rowLength; i++)
            {
                var columnIsFilled = true;

                foreach (var row in bingoBoard)
                {
                    if (!row[i].Marked)
                    {
                        columnIsFilled = false;
                    }
                }

                if (columnIsFilled)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool AnyRowsAreFilled(List<List<BingoCell>> bingoBoard)
        {
            foreach (var row in bingoBoard)
            {
                if (row.All(bc => bc.Marked))
                {
                    return true;
                }
            }

            return false;
        }

        private static int GetSumOfUnmarkedCells(List<List<BingoCell>> bingoBoard)
        {
            return bingoBoard.SelectMany(r => r.Where(bc => !bc.Marked)).Sum(bc => bc.BingoNumber);
        }

        private class BingoCell
        {
            public BingoCell(int bingoNumber)
            {
                this.BingoNumber = bingoNumber;
                this.Marked = false;
            }

            public int BingoNumber { get; set; }

            public bool Marked { get; set; }
        }    
    }
}