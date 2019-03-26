using System;
using System.Reflection;
using System.Runtime.InteropServices;
[assembly: AssemblyTitleAttribute("Production assembly 4")]

namespace CSharpInVsCode
{
    ///<Summary>
    ///特性提供了功能强大的方法，用于将元数据或声明信息与代码(程序集、类型、方法、属性等)相关联。特性与程序实体关联后，即可在运行时使用“反射”的技术查询特性。
    ///</Summary>
    [System.Serializable]
    [Demo("DuGu")]
    public class AttributeDemo : IDemo
    {
        [Obsolete]
        public void Test()
        {
            throw new System.NotImplementedException();
        }
        [method: Obsolete("该方法已经过时")]
        public void MethodA([In] ref double x)
        {

        }

    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public class DemoAttribute : Attribute
    {
        private string name;
        public double version;

        public DemoAttribute(string name)
        {
            this.name = name;
            version = 1.0;
        }
    }

}

