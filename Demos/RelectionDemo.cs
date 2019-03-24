using System;

namespace CSharpInVsCode
{
    public class ReflectionDemo : IDemo
    {
        public void Test()
        {
            var oneClass = typeof(ReflectionDemoTestClass);
            var twoClass = new ReflectionDemo().GetType();
            Console.WriteLine($"the two class is equal:{oneClass == twoClass}");
            Console.WriteLine(oneClass.Name);
            Console.WriteLine(oneClass.Namespace);
            foreach(var info in oneClass.GetProperties())
            {
                Console.WriteLine(info.Name);
            } 
        }
    }

    [ContextStatic]
    public class ReflectionDemoTestClass
    {
        public void Test()
        {

        }

        public int Index {get; set;}

        public readonly int count;

    }

}

