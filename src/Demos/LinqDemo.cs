using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CSharpInVsCode
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public List<int> Scores { get; set; }
    }

    class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

    }

    public class LinqDemo : IDemo
    {
        public void Test()
        {
            //1.获取数据源
            var nums = new int[7] { 6, 5, 4, 7, 1, 2, 3 };

            //2.创建查询
            var numQuery =
                from num in nums
                where (num % 2) == 0
                orderby num descending
                select num * 3;

            //3.执行查询
            foreach (var num in numQuery)
            {
                Console.WriteLine("{0}", num);
            }

            var numQuery2 =
                (from num in nums
                where (num % 2) == 0
                select num).ToList();

            //数据源
            double[] radii = {1, 2, 3};

            //创建查询
            var query = from radius in radii
                select $"{radius * radius * 3.14}";

            //执行查询
            foreach (var i in query)
            {
                Console.WriteLine(i);
            }

            nums = new int[4] { 1, 2, 3, 4 };
            
            //创建查询表达式
            var qureyNums = from n in nums
                            where n % 2 == 0
                            orderby n descending
                            select n;

            Console.WriteLine("qureyNums:");
            foreach (var n in qureyNums)
            {
                Console.WriteLine(n);
            }
    
            //使用方法进行查询
            var queryNums2 = nums.Where(n => n % 2 == 0).OrderByDescending(n => n);

            Console.WriteLine("qureyNums2:");
            foreach (var n in queryNums2)
            {
                Console.WriteLine(n);
            }

        }

        public void TestLinqGroupBy()
        {
            //创建第一个数据源
            var students = new List<Student>()
            {
                new Student()
                {
                    Age = 23,
                    City = "广州",
                    Name = "小C",
                    Scores = new List<int>(){85,88,83,97}
                },
                new Student()
                {
                    Age = 18,
                    City = "广西",
                    Name = "小明",
                    Scores = new List<int>(){86,78,85,90}
                },
                new Student()
                {
                    Age = 33,
                    City = "梦里",
                    Name = "小叁",
                    Scores = new List<int>(){86,68,73,97}
                }
            };

            //创建第二个数据源
            var teachers = new List<Teacher>()
            {
                new Teacher()
                {
                    Age = 35,
                    City = "梦里",
                    Name = "啵哆"
                },
                new Teacher()
                {
                    Age = 28,
                    City = "云南",
                    Name = "小红"
                },
                new Teacher()
                {
                    Age = 38,
                    City = "河南",
                    Name = "丽丽"
                }
            };

            //创建查询
            var peopleInDreams = (from student in students
                            where student.City == "梦里"
                            select student.Name)
                            .Concat(from teacher in teachers
                                    where teacher.City == "梦里"
                                    select teacher.Name);

            //执行查询
            foreach (var person in peopleInDreams)
            {
                Console.WriteLine(person);
            }
        }

        public void TestLinqAndXml()
        {
            //创建数据源
            var students = new List<Student>()
            {
                new Student()
                {
                    Age = 18,
                    Name = "小A",
                    Scores = new List<int>() {88,85,74,66 }
                },
                new Student()
                {
                    Age = 35,
                    Name = "小B",
                    Scores = new List<int>() {88,85,74,66 }
                },
                new Student()
                {
                    Age = 28,
                    Name = "小啥",
                    Scores = new List<int>() {88,85,74,66 }
                }
            };

            //创建查询
            var studentsToXml = new XElement("Root",
                from student in students
                let x = $"{student.Scores[0]},{student.Scores[1]},{student.Scores[2]},{student.Scores[3]}"
                select new XElement("student",
                new XElement("Name", student.Name),
                new XElement("Age", student.Age),
                new XElement("Scores", x))
            );

            //执行查询
            Console.WriteLine(studentsToXml);
        }
    }
}

