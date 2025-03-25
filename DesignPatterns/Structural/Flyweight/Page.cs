using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public class Page
    {
        private int no;
        private List<Line> _lines;

        public Page(int no, int numberOfLine)
        {
            this.no = no;
            _lines = new List<Line>(numberOfLine);
        }

        public void Add(Line line) => _lines.Add(line);

        public List<Line> GetLines() => _lines;

        public override string ToString()
        {
            StringBuilder sb = new();
            foreach (var line in _lines)
            {
                sb.Append(line.ToString());
            }
            return sb.ToString();
        }
    }
}
