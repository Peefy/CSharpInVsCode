using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CSharpInVsCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new ReflectionDemo().Test();
            Note.NoteClass.PrintNote();
        }
    }
}
