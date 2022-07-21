using System;
using System.Runtime.InteropServices;
using Calculator;

calculator a = new();

unsafe
{

    int number1 = 5;
    TypedReference tr1 = __makeref(number1);
    a.inputnumber(tr1);

    int number2 = 1;
    TypedReference tr2 = __makeref(number2);
    a.inputnumber(tr2);

    if (a.plus(out string test) == true)
    {
        TypedReference tr3 = __makeref(test);
        int* ret = a.getvalue(tr3);
        
        Console.WriteLine(*ret);
    }
    else if (false)
    {
        Console.WriteLine("NO WORKY");
    }
}