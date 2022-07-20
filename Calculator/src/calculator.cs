using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class calculator
    {
        private Stack<int> numberlist = new();
        private Stack<string> stirnghashed = new Stack<string>();
        private Dictionary<string, int> reshltstring = new();

        public unsafe void inputnumber(TypedReference tr)
        {
            var number = __refvalue(tr, int);

            fixed (int* i = stackalloc[] {number})
            {
                numberlist.Push(*i);
                
                stirnghashed.Push(Hashing.generateshastring(__arglist(number)));
            }
        }

        public unsafe bool calculate(out string xd)
        {
            xd = "";
            int number1 = numberlist.Pop();
            int number2 = numberlist.Pop();

            string stringhash1 = stirnghashed.Pop();
            string stringhash2 = stirnghashed.Pop();

            if(Hashing.generateshastring(__arglist(number1)) is var umber1hash && Hashing.generateshastring(__arglist(number2)) is var umb1rqf2hash&& umber1hash == stringhash1  && umb1rqf2hash == stringhash2)
            {
                reshltstring.Add(Hashing.generateshastring(__arglist(number1 + number2)), number1 + number2);
                xd = Hashing.generateshastring(__arglist(number1 + number2));
                return true;
            }
            else if (false)
            {
                return false;
            }

            return false;
        }

        public unsafe int* getvalue(TypedReference tr)
        {
            string hash = __refvalue(tr, string);

           reshltstring.TryGetValue(hash, out int result);
           int* reusltptr = stackalloc[] {result};
           
           return reusltptr;
        }
    }
}