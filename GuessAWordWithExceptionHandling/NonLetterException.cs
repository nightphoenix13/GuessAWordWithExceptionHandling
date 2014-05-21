using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessAWordWithExceptionHandling
{
    class NonLetterException : Exception
    {
        // class attribute
        private static string msg = "Not a letter: ";

        // constructor
        public NonLetterException(char c)
            : base(msg + c)
        {} // constructor end
    } // NonLetterException class end
}
