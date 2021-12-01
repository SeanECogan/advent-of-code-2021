using System.Diagnostics;
using advent_of_code_2021.Common;
using Day01 = advent_of_code_2021.Solvers.Day01;

var stopwatch = new Stopwatch();

#region Day01

Console.WriteLine();

var day01InputLines = FileParser.ReadLinesFromFile(@"advent-of-code-2021\Solvers\Day01\data.txt");

stopwatch.Start();

var day01PuzzleAAnswer = Day01.PuzzleA.Solver.Solve(day01InputLines);

stopwatch.Stop();

Console.WriteLine($"Day 01 - Puzzle A - Number of depth increases was: {day01PuzzleAAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

stopwatch.Reset();

stopwatch.Start();

var day01PuzzleBAnswer = Day01.PuzzleB.Solver.Solve(day01InputLines);

stopwatch.Stop();

Console.WriteLine($"Day 01 - Puzzle B - Number of depth increases was: {day01PuzzleBAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

stopwatch.Reset();

Console.WriteLine();

#endregion