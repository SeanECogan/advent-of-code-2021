using System.Diagnostics;
using advent_of_code_2021.Common;
using Day01 = advent_of_code_2021.Solvers.Day01;
using Day02 = advent_of_code_2021.Solvers.Day02;
using Day03 = advent_of_code_2021.Solvers.Day03;
using Day04 = advent_of_code_2021.Solvers.Day04;
using Day05 = advent_of_code_2021.Solvers.Day05;
using Day06 = advent_of_code_2021.Solvers.Day06;

var stopwatch = new Stopwatch();

Console.WriteLine();

// #region Day01

// var day01InputLines = FileParser.ReadLinesFromFile(@"advent-of-code-2021\Solvers\Day01\data.txt");

// stopwatch.Start();

// var day01PuzzleAAnswer = Day01.PuzzleA.Solver.Solve(day01InputLines);

// stopwatch.Stop();

// Console.WriteLine($"Day 01 - Puzzle A - Number of depth increases was: {day01PuzzleAAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

// stopwatch.Reset();

// stopwatch.Start();

// var day01PuzzleBAnswer = Day01.PuzzleB.Solver.Solve(day01InputLines);

// stopwatch.Stop();

// Console.WriteLine($"Day 01 - Puzzle B - Number of depth increases was: {day01PuzzleBAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

// stopwatch.Reset();

// Console.WriteLine();

// #endregion

// #region Day02

// var day02InputLines = FileParser.ReadLinesFromFile(@"advent-of-code-2021\Solvers\Day02\data.txt");

// stopwatch.Start();

// var day02PuzzleAAnswer = Day02.PuzzleA.Solver.Solve(day02InputLines);

// stopwatch.Stop();

// Console.WriteLine($"Day 02 - Puzzle A - Final position was: {day02PuzzleAAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

// stopwatch.Reset();

// stopwatch.Start();

// var day02PuzzleBAnswer = Day02.PuzzleB.Solver.Solve(day02InputLines);

// stopwatch.Stop();

// Console.WriteLine($"Day 02 - Puzzle B - Final position was: {day02PuzzleBAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

// stopwatch.Reset();

// Console.WriteLine();

// #endregion

// #region Day03

// var day03InputLines = FileParser.ReadLinesFromFile(@"advent-of-code-2021\Solvers\Day03\data.txt");

// stopwatch.Start();

// var day03PuzzleAAnswer = Day03.PuzzleA.Solver.Solve(day03InputLines);

// stopwatch.Stop();

// Console.WriteLine($"Day 03 - Puzzle A - Power consumption was: {day03PuzzleAAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

// stopwatch.Reset();

// stopwatch.Start();

// var day03PuzzleBAnswer = Day03.PuzzleB.Solver.Solve(day03InputLines);

// stopwatch.Stop();

// Console.WriteLine($"Day 03 - Puzzle B - Life support rating was: {day03PuzzleBAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

// stopwatch.Reset();

// Console.WriteLine();

// #endregion

// #region Day04

// var day04InputLines = FileParser.ReadLinesFromFile(@"advent-of-code-2021\Solvers\Day04\data.txt");

// stopwatch.Start();

// var day04PuzzleAAnswer = Day04.PuzzleA.Solver.Solve(day04InputLines);

// stopwatch.Stop();

// Console.WriteLine($"Day 04 - Puzzle A - Final score was: {day04PuzzleAAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

// stopwatch.Reset();

// stopwatch.Start();

// var day04PuzzleBAnswer = Day04.PuzzleB.Solver.Solve(day04InputLines);

// stopwatch.Stop();

// Console.WriteLine($"Day 04 - Puzzle B - Final score of last board was: {day04PuzzleBAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

// stopwatch.Reset();

// Console.WriteLine();

// #endregion

// #region Day05

// var day05InputLines = FileParser.ReadLinesFromFile(@"advent-of-code-2021\Solvers\Day05\data.txt");

// stopwatch.Start();

// var day05PuzzleAAnswer = Day05.PuzzleA.Solver.Solve(day05InputLines);

// stopwatch.Stop();

// Console.WriteLine($"Day 05 - Puzzle A - Number of points where at least two lines overlap was: {day05PuzzleAAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

// stopwatch.Reset();

// stopwatch.Start();

// var day05PuzzleBAnswer = Day05.PuzzleB.Solver.Solve(day05InputLines);

// stopwatch.Stop();

// Console.WriteLine($"Day 05 - Puzzle B - Number of points where at least two lines overlap was: {day05PuzzleBAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

// stopwatch.Reset();

// Console.WriteLine();

// #endregion

#region Day06

var day06InputLine = FileParser.ReadLineFromFile(@"advent-of-code-2021\Solvers\Day06\data.txt");
var day06PuzzleANumberOfDays = 80;
var day06PuzzleBNumberOfDays = 256;

stopwatch.Start();

var day06PuzzleAAnswer = Day06.PuzzleA.Solver.Solve(day06InputLine, day06PuzzleANumberOfDays);

stopwatch.Stop();

Console.WriteLine($"Day 06 - Puzzle A - Number of lanternfish after {day06PuzzleANumberOfDays} was: {day06PuzzleAAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

stopwatch.Reset();

stopwatch.Start();

var day06PuzzleBAnswer = Day06.PuzzleA.Solver.Solve(day06InputLine, day06PuzzleBNumberOfDays);

stopwatch.Stop();

Console.WriteLine($"Day 06 - Puzzle B - Number of lanternfish after {day06PuzzleBNumberOfDays} was: {day06PuzzleBAnswer} ({Math.Round((double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerMillisecond, 3)} ms)");

stopwatch.Reset();

Console.WriteLine();

#endregion