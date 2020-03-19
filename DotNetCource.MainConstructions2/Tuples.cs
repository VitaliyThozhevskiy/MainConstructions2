namespace DotNetCource.MainConstructions2
{
    public static class Tuples
    {
        public static void Show()
        {
            (int, int) point = (X: 1, y: 2);
            (string, int, string) values = (Name: "a", Age: 5, Lastname: "c");
            var (first, _, last) = SplitNames("Philip F Japikse");
        }

        public static (string first, string middle, string last) SplitNames(string fullName)
        {
            return ("Philip", "F", "Japikse");
        }
    }
}
