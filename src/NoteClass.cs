
using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CSharpInVsCode.Note
{

    internal class Rectangle
    {
        // 成员变量
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    internal struct Books
    {
        public string Title;
        public string Author;
        public string Subject;
        public int BookId;
    };

    enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    class Box
    {
        private double length;      // 长度
        private double breadth;     // 宽度
        private double height;      // 高度

        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }
        // 重载 + 运算符来把两个 Box 对象相加
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }

        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.height == rhs.height
               && lhs.breadth == rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length != rhs.length || lhs.height != rhs.height
                || lhs.breadth != rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public static bool operator <(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length < rhs.length && lhs.height
                < rhs.height && lhs.breadth < rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length > rhs.length && lhs.height
                > rhs.height && lhs.breadth > rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator <=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length <= rhs.length && lhs.height
                <= rhs.height && lhs.breadth <= rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length >= rhs.length && lhs.height
               >= rhs.height && lhs.breadth >= rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", length, breadth, height);
        }

    }

    public class NoteClass
    {
        private NoteClass()
        {
        }

        private static void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }

        public static void PrintNote()
        {
            Console.WriteLine("Hello Csharp Note!");
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.WriteLine("Size of int: {0}", sizeof(int));
            double d = 2345.4f;
            var ii = (int)d;
            Console.WriteLine(ii);
            int i = 75;
            float f = 53.005f;
            d = 2345.7652f;
            bool bl = true;
            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(bl.ToString());
            int a = 10;
            int b = 20;
            int c = a + b;
            string astr = "hello, world";                  // hello, world
            string bstr = @"hello, world";               // hello, world
            string cstr = "hello \t world";               // hello     world
            string dstr = @"hello \t world";               // hello \t world
            string estr = "Joe said \"Hello\" to me";      // Joe said "Hello" to me
            string fstr = @"Joe said ""Hello"" to me";   // Joe said "Hello" to me
            string gstr = "\\\\server\\share\\file.txt";   // \\server\share\file.txt
            string hstr = @"\\server\share\file.txt";      // \\server\share\file.txt
            string istr = "one\r\ntwo\r\nthree";
            string jstr = @"one two three";
            Console.WriteLine(astr + bstr + cstr + dstr + estr + fstr + gstr + hstr + istr + jstr);
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            a = 21;
            b = 10;

            c = a + b;
            Console.WriteLine("Line 1 - c 的值是 {0}", c);
            c = a - b;
            Console.WriteLine("Line 2 - c 的值是 {0}", c);
            c = a * b;
            Console.WriteLine("Line 3 - c 的值是 {0}", c);
            c = a / b;
            Console.WriteLine("Line 4 - c 的值是 {0}", c);
            c = a % b;
            Console.WriteLine("Line 5 - c 的值是 {0}", c);

            // ++a 先进行自增运算再赋值
            c = ++a;
            Console.WriteLine("Line 6 - c 的值是 {0}", c);

            // 此时 a 的值为 22
            // --a 先进行自减运算再赋值
            c = --a;
            Console.WriteLine("Line 7 - c 的值是 {0}", c);

            a = 21;
            b = 10;

            if (a == b)
            {
                Console.WriteLine("Line 1 - a 等于 b");
            }
            else
            {
                Console.WriteLine("Line 1 - a 不等于 b");
            }
            if (a < b)
            {
                Console.WriteLine("Line 2 - a 小于 b");
            }
            else
            {
                Console.WriteLine("Line 2 - a 不小于 b");
            }
            if (a > b)
            {
                Console.WriteLine("Line 3 - a 大于 b");
            }
            else
            {
                Console.WriteLine("Line 3 - a 不大于 b");
            }
            /* 改变 a 和 b 的值 */
            a = 5;
            b = 20;
            if (a <= b)
            {
                Console.WriteLine("Line 4 - a 小于或等于 b");
            }
            if (b >= a)
            {
                Console.WriteLine("Line 5 - b 大于或等于 a");
            }

            a = 60;            /* 60 = 0011 1100 */
            b = 13;            /* 13 = 0000 1101 */
            c = 0;

            c = a & b;           /* 12 = 0000 1100 */
            Console.WriteLine("Line 1 - c 的值是 {0}", c);

            c = a | b;           /* 61 = 0011 1101 */
            Console.WriteLine("Line 2 - c 的值是 {0}", c);

            c = a ^ b;           /* 49 = 0011 0001 */
            Console.WriteLine("Line 3 - c 的值是 {0}", c);

            c = ~a;               /*-61 = 1100 0011 */
            Console.WriteLine("Line 4 - c 的值是 {0}", c);

            c = a << 2;     /* 240 = 1111 0000 */
            Console.WriteLine("Line 5 - c 的值是 {0}", c);

            c = a >> 2;     /* 15 = 0000 1111 */
            Console.WriteLine("Line 6 - c 的值是 {0}", c);

            a = 21;

            c = a;
            Console.WriteLine("Line 1 - =  c 的值 = {0}", c);

            c += a;
            Console.WriteLine("Line 2 - += c 的值 = {0}", c);

            c -= a;
            Console.WriteLine("Line 3 - -=  c 的值 = {0}", c);

            c *= a;
            Console.WriteLine("Line 4 - *=  c 的值 = {0}", c);

            c /= a;
            Console.WriteLine("Line 5 - /=  c 的值 = {0}", c);

            c = 200;
            c %= a;
            Console.WriteLine("Line 6 - %=  c 的值 = {0}", c);

            c <<= 2;
            Console.WriteLine("Line 7 - <<=  c 的值 = {0}", c);

            c >>= 2;
            Console.WriteLine("Line 8 - >>=  c 的值 = {0}", c);

            c &= 2;
            Console.WriteLine("Line 9 - &=  c 的值 = {0}", c);

            c ^= 2;
            Console.WriteLine("Line 10 - ^=  c 的值 = {0}", c);

            c |= 2;
            Console.WriteLine("Line 11 - |=  c 的值 = {0}", c);

            /* sizeof 运算符的实例 */
            Console.WriteLine("int 的大小是 {0}", sizeof(int));
            Console.WriteLine("short 的大小是 {0}", sizeof(short));
            Console.WriteLine("double 的大小是 {0}", sizeof(double));

            /* 三元运算符的实例 */
            a = 10;
            b = (a == 1) ? 20 : 30;
            Console.WriteLine("b 的值是 {0}", b);

            b = (a == 10) ? 20 : 30;
            Console.WriteLine("b 的值是 {0}", b);

            a = 100;

            Console.WriteLine("在方法调用之前，a 的值： {0}", a);

            /* 调用函数来获取值 */
            getValue(out a);

            Console.WriteLine("在方法调用之后，a 的值： {0}", a);

            int[] n = new int[10]; /* n 是一个带有 10 个整数的数组 */

            /* 初始化数组 n 中的元素 */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* 输出每个数组元素的值 */
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Element[{0}] = {1}", i, n[i]);
            }

            foreach (int j in n)
            {
                int k = j - 100;
                Console.WriteLine("Element[{0}] = {1}", j, k);
            }

            string str1 = "This is test";
            string str2 = "This is text";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }

            int xSun = (int)Day.Sun;
            int xFri = (int)Day.Fri;
            Console.WriteLine("Sun = {0}", xSun);
            Console.WriteLine("Fri = {0}", xFri);

            Box Box1 = new Box();          // 声明 Box1，类型为 Box
            Box Box2 = new Box();          // 声明 Box2，类型为 Box
            Box Box3 = new Box();          // 声明 Box3，类型为 Box
            Box Box4 = new Box();
            double volume = 0.0;   // 体积

            // Box1 详述
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // Box2 详述
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            // 使用重载的 ToString() 显示两个盒子
            Console.WriteLine("Box1： {0}", Box1.ToString());
            Console.WriteLine("Box2： {0}", Box2.ToString());

            // Box1 的体积
            volume = Box1.getVolume();
            Console.WriteLine("Box1 的体积： {0}", volume);

            // Box2 的体积
            volume = Box2.getVolume();
            Console.WriteLine("Box2 的体积： {0}", volume);

            // 把两个对象相加
            Box3 = Box1 + Box2;
            Console.WriteLine("Box3： {0}", Box3.ToString());
            // Box3 的体积
            volume = Box3.getVolume();
            Console.WriteLine("Box3 的体积： {0}", volume);

            //comparing the boxes
            if (Box1 > Box2)
                Console.WriteLine("Box1 大于 Box2");
            else
                Console.WriteLine("Box1 不大于 Box2");
            if (Box1 < Box2)
                Console.WriteLine("Box1 小于 Box2");
            else
                Console.WriteLine("Box1 不小于 Box2");
            if (Box1 >= Box2)
                Console.WriteLine("Box1 大于等于 Box2");
            else
                Console.WriteLine("Box1 不大于等于 Box2");
            if (Box1 <= Box2)
                Console.WriteLine("Box1 小于等于 Box2");
            else
                Console.WriteLine("Box1 不小于等于 Box2");
            if (Box1 != Box2)
                Console.WriteLine("Box1 不等于 Box2");
            else
                Console.WriteLine("Box1 等于 Box2");
            Box4 = Box3;
            if (Box3 == Box4)
                Console.WriteLine("Box3 等于 Box4");
            else
                Console.WriteLine("Box3 不等于 Box4");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

