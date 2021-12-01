namespace advent_of_code_2021.Common
{
    public static class FileParser
    {
        public static List<string> ReadLinesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllLines(filePath).ToList();
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}