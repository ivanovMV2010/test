using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopins
{
    public class TextSearch
    {
        private string _text;
        private int _position;
        public TextSearch (string text)
        {
            _text = text;
        }

        public void GoTo (string text)
        {
           int p =  _text.IndexOf(text, _position);
           if (p > -1)
               _position = p;
          /*  if (_text.Contains(text))
                _position = _text.IndexOf(text, _position);*/
        }
        public void skip (string text)
        {
            int p = _text.IndexOf(text, _position);
            if (p > -1)
                _position = p + text.Length;
        }
        public string ReadTo(string text)
        {
            int p = _text.IndexOf(text, _position);

            string result = "" ;
            if( p > -1)
            {
                result = text.Substring(_position,p - _position); //от позиции до найденной позиции
                _position = p;
            }
            return result;
        }
    }
}
