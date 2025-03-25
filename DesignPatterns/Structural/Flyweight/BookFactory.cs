namespace DesignPatterns.Structural.Flyweight
{
    public class BookFactory : IFactory
    {
        private List<Character> _characters = new();
        private List<Line> _line= new();
        public Book CreateBook(string name, int numberOfPages)
        {
            return new Book(name, numberOfPages);
        }

        public Character CreateCharacter(char c, bool upperCase)
        {
            Character character = _characters.Find(x => x.GetValue() == c && x.IsUpperCase() == upperCase);
            if (character == null)
            {
                character = new Character(c, upperCase);
                _characters.Add(character);
            }
            return character;
        }

        public Line CreateLine(int numberOfCharacters)
        {
            Line line = _line.Find(x => x.getChars().Count == numberOfCharacters);
            if (line == null)
            {
                line = new Line(numberOfCharacters);
                _line.Add(line);
            }
            return line;
        }

        public Page CreatePage(int no, int numberOfLines)
        {
            return new Page(no, numberOfLines);
        }
    }
}
