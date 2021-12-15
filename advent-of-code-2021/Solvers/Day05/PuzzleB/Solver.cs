using System.Text.RegularExpressions;

namespace advent_of_code_2021.Solvers.Day05.PuzzleB
{
    public class Solver
    {
        public static int Solve(List<string> inputLines)
        {
            var lines = inputLines.Select(il => new Line(il));

            var pointCounts = new Dictionary<Point, int>();

            foreach (var line in lines)
            {
                if (line.IsHorizontal())
                {
                    var startX = 0;
                    var endX = 0;

                    if (line.StartPoint.X > line.EndPoint.X)
                    {
                        endX = line.StartPoint.X;
                        startX = line.EndPoint.X;
                    }
                    else
                    {
                        startX = line.StartPoint.X;
                        endX = line.EndPoint.X;
                    }

                    for (var x = startX; x <= endX; x++)
                    {
                        var currentPoint = new Point(x, line.StartPoint.Y);

                        if (pointCounts.ContainsKey(currentPoint))
                        {
                            pointCounts[currentPoint]++;
                        }
                        else
                        {
                            pointCounts.Add(currentPoint, 1);
                        }
                    }
                }
                else if (line.IsVertical())
                {
                    var startY = 0;
                    var endY = 0;

                    if (line.StartPoint.Y > line.EndPoint.Y)
                    {
                        endY = line.StartPoint.Y;
                        startY = line.EndPoint.Y;
                    }
                    else
                    {
                        startY = line.StartPoint.Y;
                        endY = line.EndPoint.Y;
                    }

                    for (var y = startY; y <= endY; y++)
                    {
                        var currentPoint = new Point(line.StartPoint.X, y);

                        if (pointCounts.ContainsKey(currentPoint))
                        {
                            pointCounts[currentPoint]++;
                        }
                        else
                        {
                            pointCounts.Add(currentPoint, 1);
                        }
                    }
                }
                else
                {
                    var startX = 0;
                    var xIsIncreasing = false;
                    
                    var startY = 0;
                    var endY = 0;

                    if (line.StartPoint.Y > line.EndPoint.Y)
                    {
                        startX = line.EndPoint.X;
                        xIsIncreasing = line.EndPoint.X < line.StartPoint.X;

                        endY = line.StartPoint.Y;
                        startY = line.EndPoint.Y;
                    }
                    else
                    {
                        startX = line.StartPoint.X;
                        xIsIncreasing = line.StartPoint.X < line.EndPoint.X;

                        startY = line.StartPoint.Y;
                        endY = line.EndPoint.Y;
                    }

                    var difference = endY - startY;

                    for (var i = 0; i <= difference; i++)
                    {
                        var currentPoint = new Point(
                            startX + (i * (xIsIncreasing ? 1 : -1)),
                            startY + i);

                        if (pointCounts.ContainsKey(currentPoint))
                        {
                            pointCounts[currentPoint]++;
                        }
                        else
                        {
                            pointCounts.Add(currentPoint, 1);
                        }
                    }
                }
            }

            return pointCounts.Values.Count(v => v >= 2);
        }

        private class Line
        {
            public Line(string inputLine)
            {
                ParseLineInput(inputLine);
            }

            public Point StartPoint { get; set; }
            public Point EndPoint { get; set; }

            public bool IsHorizontal()
            {
                return this.StartPoint.Y == this.EndPoint.Y;
            }

            public bool IsVertical()
            {
                return this.StartPoint.X == this.EndPoint.X;
            }

            private void ParseLineInput(string inputLine)
            {
                var lineParts = Regex.Replace(inputLine, @"\s+", "").Split("->");

                var firstPointParts = lineParts[0].Split(",");
                var secondPointParts = lineParts[1].Split(",");

                this.StartPoint = new Point(
                    Convert.ToInt32(firstPointParts[0]),
                    Convert.ToInt32(firstPointParts[1])
                );

                this.EndPoint = new Point(
                    Convert.ToInt32(secondPointParts[0]),
                    Convert.ToInt32(secondPointParts[1])
                );
            }
        }

        private class Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }

            public override bool Equals(object? obj)
            {
                if (!(obj is Point))
                {
                    return false;
                }

                var p = obj as Point;

                if (p is null)
                {
                    return this is null;
                }

                return this.X == p.X &&
                       this.Y == p.Y;
            }

            public override int GetHashCode()
            {
                return this.X.GetHashCode() ^
                       this.Y.GetHashCode();
            }
        }
    }
}