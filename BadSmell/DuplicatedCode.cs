﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BadSmell
{
    static class DuplicatedCode
    {
        public static void FooBar()
        {
            var number = int.Parse(Console.ReadLine());

            if (number < 10)
            {
                DuplicatedCode.DoSomething();
            }
            else if (number < 20)
            {
                DuplicatedCode2.DoSomethingOther();
            }
            else
            {
                DuplicatedCode.DoSomething();
            }

            if (number < 10)
            {
                DuplicatedCode.DoSomething();
            }
            else if (number < 20)
            {
                DuplicatedCode2.DoSomethingOther();
            }
            else
            {
                DuplicatedCode.DoSomething();
            }
        }

        public static void DoSomething()
        {
            Console.WriteLine("Hello World!");
        }

        
    }
}
