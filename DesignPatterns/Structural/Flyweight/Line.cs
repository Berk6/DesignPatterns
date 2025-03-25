using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Structural.Flyweight
{
    public class Line
    {
        private List<Character> _chars;
        private Character _endOfLine = new ('\n');
        private int _emptyPosition;
        private bool _isFull;
        private int _numberOfCharacters = 1;
        public Line(int numberOfCharacters)
        {
            this._numberOfCharacters = numberOfCharacters;
            _chars = new List<Character>(numberOfCharacters);
        }
        public bool Add(Character character)
        {
            if (!_isFull)
            {
                _chars.Add(character);
                character.SetLine(this);
                character.SetPosition(_emptyPosition);
                _emptyPosition++;
                if (_emptyPosition == _numberOfCharacters + 1)
                    _isFull = true;
                return true;
            }
            else
                return false;
        }
        public void AddEndOfLine() => _chars.Add(_endOfLine);

        public List<Character> getChars() => _chars;

        public override string ToString()
        {
            StringBuilder sb = new ();
            foreach (var character in _chars)
            {
                sb.Append(character.GetValue());
            }
            return sb.ToString();
        }
    }
}
