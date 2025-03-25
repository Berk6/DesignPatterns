using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Structural.Flyweight
{
    public class Character
    {
        // Intrinsic properties
        private char _value;
        private bool _upperCase;

        // Extrinsic properties
        private Line _line;
        private int  _position;

        public Character(char value, bool upperCase)
        {
            this._value = value;
            this._upperCase = upperCase;
        }

        public Character(int value)
        {
            this._value = (char)value;
        }

        public char GetValue() => _value;

        public bool IsUpperCase() => _upperCase;

        public Line GetLine() => _line;

        public void SetLine(Line line) => this._line = line;

        public int GetPosition() => _position;

        public void SetPosition(int position) => this._position = position;

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
