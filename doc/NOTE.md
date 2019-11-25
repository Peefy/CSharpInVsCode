
## C#笔记

C# 是一个简单的、现代的、通用的、面向对象的编程语言，它是由微软（Microsoft）开发的。C# 是由 Anders Hejlsberg 和他的团队在 .Net 框架开发期间开发的。


## C#简介

C# 是专为公共语言基础结构（CLI）设计的。CLI 由可执行代码和运行时环境组成，允许在不同的计算机平台和体系结构上使用各种高级语言。

C#特性

* **布尔条件（Boolean Conditions）**-
* **自动垃圾回收（Automatic Garbage Collection）**-
* **标准库（Standard Library）**-
* **组件版本（Assembly Versioning）**-
* **属性（Properties）和事件（Events）**-
* **委托（Delegates）和事件管理（Events Management）**-
* **易于使用的泛型（Generics）**-
* **索引器（Indexers）**-
* **条件编译（Conditional Compilation）**-
* **简单的多线程（Multithreading）**-
* **LINQ 和 Lambda 表达式**-
* **Net Core跨平台**-

**C#程序结构**

* 命名空间声明（Namespace declaration）
* 一个 class
* Class 方法
* Class 属性
* 一个 Main 方法
* 语句（Statements）& 表达式（Expressions）
* 注释

```csharp
using System;
namespace HelloWorldApplication
{
   class HelloWorld
   {
      static void Main(string[] args)
      {
         /* 我的第一个 C# 程序*/
         Console.WriteLine("Hello World");
         Console.ReadKey();
      }
   }
}
```

* 程序的第一行 using System; - using 关键字用于在程序中包含 System 命名空间。 一个程序一般有多个 using 语句。
* 下一行是 namespace 声明。一个 namespace 里包含了一系列的类。HelloWorldApplication 命名空间包含了类 HelloWorld。
* 下一行是 class 声明。类 HelloWorld 包含了程序使用的数据和方法声明。类一般包含多个方法。方法定义了类的行为。在这里，HelloWorld 类只有一个 Main 方法。
* 下一行定义了 Main 方法，是所有 C# 程序的 入口点。Main 方法说明当执行时 类将做什么动作。
* 下一行 `/*...*/` 将会被编译器忽略，且它会在程序中添加额外的 注释。
* Main 方法通过语句 Console.WriteLine("Hello World"); 指定了它的行为。 WriteLine 是一个定义在 System 命名空间中的 Console 类的一个方法。该语句会在屏幕上显示消息 "Hello, World!"。
* 最后一行 Console.ReadKey(); 是针对 VS.NET 用户的。这使得程序会等待一个按键的动作，防止程序从 Visual Studio .NET 启动时屏幕会快速运行并关闭。

**C#基本语法**

C# 是一种面向对象的编程语言。在面向对象的程序设计方法中，程序由各种相互交互的对象组成。相同种类的对象通常具有相同的类型，或者说，是在相同的 class 中。

例如，以 Rectangle（矩形）对象为例。它具有 length 和 width 属性。根据设计，它可能需要接受这些属性值、计算面积和显示细节。

来看看一个 Rectangle（矩形）类的实现，并借此讨论 C# 的基本语法：

```csharp
using System;
namespace RectangleApplication
{
    class Rectangle
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
   
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
```

**using关键字**

using 关键字用于在程序中包含命名空间。一个程序可以包含多个 using 语句。

**class关键字**

class 关键字用于声明一个类。

**C#注释**

注释是用于解释代码。编译器会忽略注释的条目。在 C# 程序中，多行注释以 `/*` 开始，并以字符 `*/` 终止，如下所示：

**成员变量**

函数是一系列执行指定任务的语句。类的成员函数是在类内声明的。我们举例的类 Rectangle 包含了三个成员函数： AcceptDetails、GetArea 和 Display。

**成员函数**

在上面的程序中，类 ExecuteRectangle 是一个包含 Main() 方法和实例化 Rectangle 类的类。

**标识符**

标识符是用来识别类、变量、函数或任何其它用户定义的项目。在 C# 中，类的命名必须遵循如下基本规则：

* 标识符必须以字母、下划线或 @ 开头，后面可以跟一系列的字母、数字（ 0 - 9 ）、下划线（ _ ）、@。
* 标识符中的第一个字符不能是数字。
* 标识符必须不包含任何嵌入的空格或符号，比如 ? - +! # % ^ & * ( ) [ ] { } . ; : " ' / \。
* 标识符不能是 C# 关键字。除非它们有一个 @ 前缀。 例如，@if 是有效的标识符，但 if 不是，因为 if 是关键字。
* 标识符必须区分大小写。大写字母和小写字母被认为是不同的字母。
* 不能与C#的类库名称相同。

**C#关键字**

关键字是 C# 编译器预定义的保留字。这些关键字不能用作标识符，但是，如果您想使用这些关键字作为标识符，可以在关键字前面加上 @ 字符作为前缀。

在 C# 中，有些关键字在代码的上下文中有特殊的意义，如 get 和 set，这些被称为上下文关键字（contextual keywords）。

下表列出了 C# 中的保留关键字（Reserved Keywords）和上下文关键字（Contextual Keywords）：

保留关键字|-|-|-|-|-|-
-|-|-|-|-|-|-
abstract|	as|	base|	bool|	break|	byte|	case
catch|	char|	checked|	class|	const|	continue|	decimal
default|	delegate|	do|	double|	else|	enum|	event
explicit|	extern|	false|	finally|	fixed|	float|	for
foreach|	goto|	if|	implicit|	in|	in (generic modifier)|	int
interface|	internal|	is|	lock|	long|	namespace|	new
null|	object|	operator|	out|	out (generic modifier)	override|	params
private|	protected|	public|	readonly|	ref|	return|	sbyte
sealed|	short|	sizeof|	stackalloc|	static|	string|	struct
switch|	this|	throw|	true|	try|	typeof|	uint
ulong|	unchecked|	unsafe|	ushort|	using|	virtual|	void
volatile|	while|		
			
上下文关键字|-|-|-|-|-|-
-|-|-|-|-|-|-
add|	alias|	ascending|	descending|	dynamic|	from|	get
global|	group|	into|	join|	let|	orderby|	partial
(type) partial| (method)	remove|	select|	set

**C#数据类型**

在 C# 中，变量分为以下几种类型：

* 值类型（Value types）
* 引用类型（Reference types）
* 指针类型（Pointer types）

**值类型（Value types）**

值类型变量可以直接分配给一个值。它们是从类 `System.ValueType` 中派生的。

值类型直接包含数据。比如 int、char、float，它们分别存储数字、字符、浮点数。当您声明一个 int 类型时，系统分配内存来存储值。

类型|	描述|	范围|	默认值
-|-|-|-
bool|	布尔值|	True 或 False|	False
byte|	8 位无符号整数|	0 到 255|	0
char|	16 位 Unicode 字符|	U +0000 到 U +ffff|	'\0'
decimal|	128 位精确的十进制值，28-29 有效位数	(-7.9 x 1028 到 7.9 x 1028) / 100 到 28|	0.0M
double|	64 位双精度浮点型|	(+/-)5.0 x 10-324 到 (+/-)1.7 x 10308|	0.0D
float|	32 位单精度浮点型|	-3.4 x 1038 到 + 3.4 x 1038|	0.0F
int|	32 位有符号整数类型|	-2,147,483,648 到 2,147,483,647|	0
long|	64 位有符号整数类型|	-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807|	0L
sbyte|	8 位有符号整数类型|	-128 到 127|	0
short|	16 位有符号整数类型|	-32,768 到 32,767|	0
uint|	32 位无符号整数类型|	0 到 4,294,967,295|	0
ulong|	64 位无符号整数类型|	0 到 18,446,744,073,709,551,615|	0
ushort|	16 位无符号整数类型|	0 到 65,535|	0

如需得到一个类型或一个变量在特定平台上的准确尺寸，可以使用 `sizeof` 方法。表达式 `sizeof(type)` 产生以字节为单位存储对象或类型的存储尺寸。

```csharp
using System;

namespace DataTypeApplication
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Size of int: {0}", sizeof(int));
         Console.ReadLine();
      }
   }
}
```

**引用类型（Reference types）**

引用类型不包含存储在变量中的实际数据，但它们包含对变量的引用。

换句话说，它们指的是一个内存位置。使用多个变量时，引用类型可以指向一个内存位置。如果内存位置的数据是由一个变量改变的，其他变量会自动反映这种值的变化。内置的 引用类型有：`object`、`dynamic` 和 `string`。

**对象（Object）类型**

对象（Object）类型 是 C# 通用类型系统（Common Type System - CTS）中所有数据类型的终极基类。Object 是 System.Object 类的别名。所以对象（Object）类型可以被分配任何其他类型（值类型、引用类型、预定义类型或用户自定义类型）的值。但是，在分配值之前，需要先进行类型转换。

当一个值类型转换为对象类型时，则被称为 装箱；另一方面，当一个对象类型转换为值类型时，则被称为 拆箱。

**动态（Dynamic）类型**

您可以存储任何类型的值在动态数据类型变量中。这些变量的类型检查是在运行时发生的。

动态类型与对象类型相似，但是对象类型变量的类型检查是在编译时发生的，而动态类型变量的类型检查是在运行时发生的。

**字符串（String）类型**

`字符串（String）类型` 允许您给变量分配任何字符串值。字符串（String）类型是 System.String 类的别名。它是从对象（Object）类型派生的。字符串（String）类型的值可以通过两种形式进行分配：引号和 @引号。

C# string 字符串的前面可以加 @（称作"逐字字符串"）将转义字符（\）当作普通字符对待，比如：

@ 字符串中可以任意换行，换行符及缩进空格都计算在字符串长度之内。

**指针类型（Pointer types）**

指针类型变量存储另一种类型的内存地址。C# 中的指针与 C 或 C++ 中的指针有相同的功能。但是属于“不安全的代码”。

类型转换从根本上说是类型铸造，或者说是把数据从一种类型转换为另一种类型。在 C# 中，类型铸造有两种形式：

* **隐式类型转换**-这些转换是 C# 默认的以安全方式进行的转换, 不会导致数据丢失。例如，从小的整数类型转换为大的整数类型，从派生类转换为基类。
* **显式类型转换**-显式类型转换，即强制类型转换。显式转换需要强制转换运算符，而且强制转换会造成数据丢失。

**C#类型转换方法**

C# 提供了下列内置的类型转换方法：

序号|	方法 & 描述
-|-
1|	ToBoolean 如果可能的话，把类型转换为布尔型。
2|	ToByte 把类型转换为字节类型。
3|	ToChar 如果可能的话，把类型转换为单个 Unicode 字符类型。
4|	ToDateTime 把类型（整数或字符串类型）转换为 日期-时间 结构。
5|	ToDecimal 把浮点型或整数类型转换为十进制类型。
6|	ToDouble 把类型转换为双精度浮点型。
7|	ToInt16 把类型转换为 16 位整数类型。
8|	ToInt32 把类型转换为 32 位整数类型。
9|	ToInt64 把类型转换为 64 位整数类型。
10|	ToSbyte 把类型转换为有符号字节类型。
11|	ToSingle 把类型转换为小浮点数类型。
12|	ToString 把类型转换为字符串类型。
13|	ToType 把类型转换为指定类型。
14|	ToUInt16 把类型转换为 16 位无符号整数类型。
15|	ToUInt32 把类型转换为 32 位无符号整数类型。
16|	ToUInt64 把类型转换为 64 位无符号整数类型。

```csharp
namespace TypeConversionApplication
{
    class StringConversion
    {
        static void Main(string[] args)
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();
           
        }
    }
}
```

**C#变量**

一个变量只不过是一个供程序操作的存储区的名字。在 C# 中，每个变量都有一个特定的类型，类型决定了变量的内存大小和布局。范围内的值可以存储在内存中，可以对变量进行一系列操作。

我们已经讨论了各种数据类型。C# 中提供的基本的值类型大致可以分为以下几类：

类型|	举例
-|-
整数类型|	sbyte、byte、short、ushort、int、uint、long、ulong 和 char
浮点型|	float 和 double
十进制类型|	decimal
布尔类型|	true 或 false 值，指定的值
空类型|	可为空值的数据类型

C# 允许定义其他值类型的变量，比如 `enum`，也允许定义引用类型变量，比如 `class`。

**C# 中的变量定义**

```
<data_type> <variable_list> = value;
```

在这里，data_type 必须是一个有效的 C# 数据类型，可以是 char、int、float、double 或其他用户自定义的数据类型。variable_list 可以由一个或多个用逗号分隔的标识符名称组成。

一些有效的变量定义如下所示：

```csharp
int i, j, k;
char c, ch;
float f, salary;
double d = 123f;
```

可以在变量定义时进行初始化：

**C# 中的 Lvalues 和 Rvalues**

C# 中的两种表达式：

* **lvalue**-lvalue 表达式可以出现在赋值语句的左边或右边。
* **rvalue**-rvalue 表达式可以出现在赋值语句的右边，不能出现在赋值语句的左边。

**C# 常量**

常量是固定值，程序执行期间不会改变。常量可以是任何基本数据类型，比如整数常量、浮点常量、字符常量或者字符串常量，还有枚举常量。

常量可以被当作常规的变量，只是它们的值在定义后不能被修改。

**整数常量**

整数常量可以是十进制、八进制或十六进制的常量。前缀指定基数：0x 或 0X 表示十六进制，0 表示八进制，没有前缀则表示十进制。

整数常量也可以有后缀，可以是 U 和 L 的组合，其中，U 和 L 分别表示 unsigned 和 long。后缀可以是大写或者小写，多个后缀以任意顺序进行组合。

这里有一些整数常量的实例：

```
212         /* 合法 */
215u        /* 合法 */
0xFeeL      /* 合法 */
078         /* 非法：8 不是一个八进制数字 */
032UU       /* 非法：不能重复后缀 */
```

以下是各种类型的整数常量的实例：

```
85         /* 十进制 */
0213       /* 八进制 */
0x4b       /* 十六进制 */
30         /* int */
30u        /* 无符号 int */
30l        /* long */
30ul       /* 无符号 long */
```

**浮点常量**

```lua
3.14159       /* 合法 */
314159E-5L    /* 合法 */
510E          /* 非法：不完全指数 */
210f          /* 非法：没有小数或指数 */
.e55          /* 非法：缺少整数或小数 */
```

**字符常量**

字符常量是括在单引号里，例如，'x'，且可存储在一个简单的字符类型变量中。一个字符常量可以是一个普通字符（例如 'x'）、一个转义序列（例如 '\t'）或者一个通用字符（例如 '\u02C0'）。

在 C# 中有一些特定的字符，当它们的前面带有反斜杠时有特殊的意义，可用于表示换行符（\n）或制表符 tab（\t）。在这里，列出一些转义序列码：

转义序列|	含义
-|-
`\\`|	\ 字符
`\'`|	' 字符
`\"`|	" 字符
`\?`|	? 字符
`\a`|	Alert 或 bell
`\b`|	退格键（Backspace）
`\f`|	换页符（Form feed）
`\n`|	换行符（Newline）
`\r`|	回车
`\t`|	水平制表符 tab
`\v`|	垂直制表符 tab
`\ooo`|	一到三位的八进制数
`\xhh`|	一个或多个数字的十六进制数

**字符串常量**

字符串常量是括在双引号 `""` 里，或者是括在 `@""` 里。字符串常量包含的字符与字符常量相似，可以是：普通字符、转义序列和通用字符

使用字符串常量时，可以把一个很长的行拆成多个行，可以使用空格分隔各个部分。

这里是一些字符串常量的实例。下面所列的各种形式表示相同的字符串。

```csharp
string a = "hello, world";                  // hello, world
string b = @"hello, world";               // hello, world
string c = "hello \t world";               // hello     world
string d = @"hello \t world";               // hello \t world
string e = "Joe said \"Hello\" to me";      // Joe said "Hello" to me
string f = @"Joe said ""Hello"" to me";   // Joe said "Hello" to me
string g = "\\\\server\\share\\file.txt";   // \\server\share\file.txt
string h = @"\\server\share\file.txt";      // \\server\share\file.txt
string i = "one\r\ntwo\r\nthree";
string j = @"one
two
three";
```

**定义常量**

常量是使用 const 关键字来定义的 。定义一个常量的语法如下：

```csharp
using System;

public class ConstTest
{
    class SampleClass
    {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public SampleClass(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    static void Main()
    {
        SampleClass mC = new SampleClass(11, 22);
        Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);
        Console.WriteLine("c1 = {0}, c2 = {1}",
                          SampleClass.c1, SampleClass.c2);
    }
}
```

**C#运算符**

运算符是一种告诉编译器执行特定的数学或逻辑操作的符号。C# 有丰富的内置运算符，分类如下：

* **算术运算符**

运算符|	描述|	实例
-|-|-
`+`|	把两个操作数相加|	A + B 将得到 30
`-`|	从第一个操作数中减去第二个操作数|	A - B 将得到 -10
`*`|	把两个操作数相乘|	A * B 将得到 200
`/`|	分子除以分母|	B / A 将得到 2
`%`|	取模运算符，整除后的余数|	B % A 将得到 0
`++`|	自增运算符，整数值增加 1|	A++ 将得到 11
`--`|	自减运算符，整数值减少 1|	A-- 将得到 9

```csharp
using System;

namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 21;
            int b = 10;
            int c;

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
            Console.ReadLine();
        }
    }
}
```

1. `c = a++`: 先将 a 赋值给 c，再对 a 进行自增运算。
2. `c = ++a`: 先将 a 进行自增运算，再将 a 赋值给 c 。
3. `c = a--`: 先将 a 赋值给 c，再对 a 进行自减运算。
4. `c = --a`: 先将 a 进行自减运算，再将 a 赋值给 c 。

* **关系运算符**

运算符|	描述|	实例
-|-|-
`==`|	检查两个操作数的值是否相等，如果相等则条件为真。|	(A == B) 不为真。
`!=`|	检查两个操作数的值是否相等，如果不相等则条件为真。|	(A != B) 为真。
`>`|	检查左操作数的值是否大于右操作数的值，如果是则条件为真。|	(A > B) 不为真。
`<`|	检查左操作数的值是否小于右操作数的值，如果是则条件为真。|	(A < B) 为真。
`>=`|	检查左操作数的值是否大于或等于右操作数的值，如果是则条件为真。|	(A >= B) 不为真。
`<=`|	检查左操作数的值是否小于或等于右操作数的值，如果是则条件为真。|	(A <= B) 为真。

```csharp
using System;

class Program
{
  static void Main(string[] args)
  {
      int a = 21;
      int b = 10;
     
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
  }
}
```

* **逻辑运算符**

运算符|	描述|	实例
-|-|-
`&&`|	称为逻辑与运算符。如果两个操作数都非零，则条件为真。|	`(A && B)` 为假。
`||`|	称为逻辑或运算符。如果两个操作数中有任意一个非零，则条件为真。|	`(A || B)` 为真。
`!`|	称为逻辑非运算符。用来逆转操作数的逻辑状态。如果条件为真则逻辑非运算符将使其为假。|	`!(A && B)` 为真。

```csharp
using System;

namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;
           
            if (a && b)
            {
               Console.WriteLine("Line 1 - 条件为真");
            }
            if (a || b)
            {
                Console.WriteLine("Line 2 - 条件为真");
            }
            /* 改变 a 和 b 的值 */
            a = false;
            b = true;
            if (a && b)
            {
                Console.WriteLine("Line 3 - 条件为真");
            }
            else
            {
                Console.WriteLine("Line 3 - 条件不为真");
            }
            if (!(a && b))
            {
                Console.WriteLine("Line 4 - 条件为真");
            }
            Console.ReadLine();
        }
    }
}
```

* **位运算符**

`p`|	`q`|	`p & q`	|`p | q`|	`p ^ q`
-|-|-|-|-
0|	0|	0|	0|	0
0|	1|	0|	1|	1
1|	1|	1|	1|	0
1|	0|	0|	1|	1


运算符|	描述|	实例
-|-|-
`&`|	如果同时存在于两个操作数中，二进制 AND 运算符复制一位到结果中。|	(A & B) 将得到 12，即为 0000 1100
`|`|	如果存在于任一操作数中，二进制 OR 运算符复制一位到结果中。|	(A | B) 将得到 61，即为 0011 1101
`^`|	如果存在于其中一个操作数中但不同时存在于两个操作数中，二进制异或运算符复制一位到结果中。|	(A ^ B) 将得到 49，即为 0011 0001
`~`|	按位取反运算符是一元运算符，具有"翻转"位效果，即0变成1，1变成0，包括符号位。|	(~A ) 将得到 -61，即为 1100 0011，一个有符号二进制数的补码形式。
`<<`|	二进制左移运算符。左操作数的值向左移动右操作数指定的位数。|	A << 2 将得到 240，即为 1111 0000
`>>`|	二进制右移运算符。左操作数的值向右移动右操作数指定的位数。|	A >> 2 将得到 15，即为 0000 1111

```csharp
using System;
namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 60;            /* 60 = 0011 1100 */  
            int b = 13;            /* 13 = 0000 1101 */
            int c = 0;          

             c = a & b;           /* 12 = 0000 1100 */
             Console.WriteLine("Line 1 - c 的值是 {0}", c );

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
            Console.ReadLine();
        }
    }
}
```

* **赋值运算符**

运算符|	描述|	实例
-|-|-
`=`| 简单的赋值运算符，把右边操作数的值赋给左边操作数|	C = A + B 将把 A + B 的值赋给 C
`+=`|	加且赋值运算符，把右边操作数加上左边操作数的结果赋值给左边操作数|	C += A 相当于 C = C + A
`-=`|	减且赋值运算符，把左边操作数减去右边操作数的结果赋值给左边操作数|	C -= A 相当于 C = C - A
`*=`|	乘且赋值运算符，把右边操作数乘以左边操作数的结果赋值给左边操作数|	C *= A 相当于 C = C * A
`/=`|	除且赋值运算符，把左边操作数除以右边操作数的结果赋值给左边操作数|	C /= A 相当于 C = C / A
`%=`|	求模且赋值运算符，求两个操作数的模赋值给左边操作数|	C %= A 相当于 C = C % A
`<<=`|	左移且赋值运算符|	C <<= 2 等同于 C = C << 2
`>>=`|	右移且赋值运算符|	C >>= 2 等同于 C = C >> 2
`&=`|	按位与且赋值运算符|	C &= 2 等同于 C = C & 2
`^=`|	按位异或且赋值运算符|	C ^= 2 等同于 C = C ^ 2
`|=`|	按位或且赋值运算符|	C |= 2 等同于 C = C | 2

```csharp
using System;

namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 21;
            int c;

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
            Console.ReadLine();
        }
    }
}
```

* **其他运算符**

运算符|	描述|	实例
-|-|-
`sizeof()`|	返回数据类型的大小。|	sizeof(int)，将返回 4.
`typeof()`|	返回 class 的类型。|	typeof(StreamReader);
`&`|	返回变量的地址。|	`&a`; 将得到变量的实际地址。
`*`|	变量的指针。|	`*a`; 将指向一个变量。
`? :`|	条件表达式|	如果条件为真 ? 则为 X : 否则为 Y
`is`|	判断对象是否为某一类型。|	If( Ford is Car) // 检查 Ford 是否是 Car 类的一个对象。
`as`|	强制转换，即使转换失败也不会抛出异常。|	Object obj = new StringReader("Hello"); StringReader r = obj as StringReader;

```csharp
using System;

namespace OperatorsAppl
{
   
   class Program
   {
      static void Main(string[] args)
      {
         
         /* sizeof 运算符的实例 */
         Console.WriteLine("int 的大小是 {0}", sizeof(int));
         Console.WriteLine("short 的大小是 {0}", sizeof(short));
         Console.WriteLine("double 的大小是 {0}", sizeof(double));
         
         /* 三元运算符的实例 */
         int a, b;
         a = 10;
         b = (a == 1) ? 20 : 30;
         Console.WriteLine("b 的值是 {0}", b);

         b = (a == 10) ? 20 : 30;
         Console.WriteLine("b 的值是 {0}", b);
         Console.ReadLine();
      }
   }
}
```

**C# 中的运算符优先级**

运算符的优先级确定表达式中项的组合。这会影响到一个表达式如何计算。某些运算符比其他运算符有更高的优先级，例如，乘除运算符具有比加减运算符更高的优先级。

例如 x = 7 + 3 * 2，在这里，x 被赋值为 13，而不是 20，因为运算符 * 具有比 + 更高的优先级，所以首先计算乘法 3*2，然后再加上 7。

下表将按运算符优先级从高到低列出各个运算符，具有较高优先级的运算符出现在表格的上面，具有较低优先级的运算符出现在表格的下面。在表达式中，较高优先级的运算符会优先被计算。

类别| 	运算符| 	结合性 
-|-|-
后缀| 	`() [] -> . ++ - -` | 	从左到右 
一元|	`+ - ! ~ ++ - - (type)* & sizeof` |	从右到左 
乘除| 	`* / %` |	从左到右 
加减| 	`+ -` |	从左到右 
移位|	`<< >>` |	从左到右 
关系| 	`< <= > >=` |	从左到右 
相等| 	`== !=` |	从左到右 
位与 AND| 	`&` |	从左到右 
位异或 XOR| 	`^` |	从左到右 
位或 OR| 	`|` |	从左到右 
逻辑与 AND| 	`&&` |	从左到右 
逻辑或 OR| 	`||` |	从左到右 
条件| 	`?:` |	从右到左 
赋值| 	`= += -= *= /= %=>>= <<= &= ^= |=` |	从右到左 
逗号| 	`,` |	从左到右 

```csharp
using System;

namespace OperatorsAppl
{
   
   class Program
   {
      static void Main(string[] args)
      {
         int a = 20;
         int b = 10;
         int c = 15;
         int d = 5;
         int e;
         e = (a + b) * c / d;     // ( 30 * 15 ) / 5
         Console.WriteLine("(a + b) * c / d 的值是 {0}", e);

         e = ((a + b) * c) / d;   // (30 * 15 ) / 5
         Console.WriteLine("((a + b) * c) / d 的值是 {0}", e);

         e = (a + b) * (c / d);   // (30) * (15/5)
         Console.WriteLine("(a + b) * (c / d) 的值是 {0}", e);

         e = a + (b * c) / d;    //  20 + (150/5)
         Console.WriteLine("a + (b * c) / d 的值是 {0}", e);
         Console.ReadLine();
      }
   }
}
```

**C#判断**

判断结构要求程序员指定一个或多个要评估或测试的条件，以及条件为真时要执行的语句（必需的）和条件为假时要执行的语句（可选的）。

**判断语句**

语句|	描述
-|-
if 语句|	一个 if 语句 由一个布尔表达式后跟一个或多个语句组成。
if...else 语句|	一个 if 语句 后可跟一个可选的 else 语句，else 语句在布尔表达式为假时执行。
嵌套 if 语句|	您可以在一个 if 或 else if 语句内使用另一个 if 或 else if 语句。
switch 语句|	一个 switch 语句允许测试一个变量等于多个值时的情况。
嵌套 switch 语句|	您可以在一个 switch 语句内使用另一个 switch 语句。

**? : 运算符**

```csharp
namespace jiecheng
{
    class jiecheng
    {
        public int Jc(int num)
        {
            
            return num > 0 ? num *Jc(num - 1):1;  //如果num>0则返回num *Jc(num - 1)，否则返回1
        }
    }

    class excutejiecheng
    {
        static void Main(string[] args)
        {
            jiecheng n = new jiecheng();
            int result = n.Jc(Convert.ToInt16(Console.ReadLine()));
            Console.WriteLine("result is {0}",result);
            Console.ReadKey();
        }
    }
}
```

**C# 循环**

有的时候，可能需要多次执行同一块代码。一般情况下，语句是顺序执行的：函数中的第一个语句先执行，接着是第二个语句，依此类推。

编程语言提供了允许更为复杂的执行路径的多种控制结构。

循环语句允许我们多次执行一个语句或语句组，下面是大多数编程语言中循环语句的一般形式：

**循环类型**

循环类型|	描述
-|-
`while 循环`|	当给定条件为真时，重复语句或语句组。它会在执行循环主体之前测试条件。
`for/foreach 循环`|	多次执行一个语句序列，简化管理循环变量的代码。
`do...while 循环`| 除了它是在循环主体结尾测试条件外，其他与 while 语句类似。
`嵌套循环`|	您可以在 while、for 或 do..while 循环内使用一个或多个循环。

**循环控制语句**

循环控制语句更改执行的正常序列。当执行离开一个范围时，所有在该范围中创建的自动对象都会被销毁。

控制语句|	描述
-|-
`break 语句`|	终止 loop 或 switch 语句，程序流将继续执行紧接着 loop 或 switch 的下一条语句。
`continue 语句`|	引起循环跳过主体的剩余部分，立即重新开始测试条件。

**C#封装**

`封装` 被定义为"把一个或多个项目封闭在一个物理的或者逻辑的包中"。在面向对象程序设计方法论中，封装是为了防止对实现细节的访问。

抽象和封装是面向对象程序设计的相关特性。抽象允许相关信息可视化，封装则使开发者实现所需级别的抽象。

C# 封装根据具体的需要，设置使用者的访问权限，并通过 `访问修饰符` 来实现。

一个 `访问修饰符` 定义了一个类成员的范围和可见性。C# 支持的访问修饰符如下所示：

* **public**：所有对象都可以访问；
* **private**：对象本身在对象内部可以访问；
* **protected**：只有该类对象及其子类对象可以访问
* **internal**：同一个程序集的对象可以访问；
* **protected internal**：访问限于当前程序集或派生自包含类的类型。

```csharp
using System;

namespace RectangleApplication
{
    class Rectangle
    {
        //成员变量
        internal double length;
        internal double width;
       
        double GetArea()
        {
            return length * width;
        }
       public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }//end class Rectangle    
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
```

**C#方法Method**

一个方法是把一些相关的语句组织在一起，用来执行一个任务的语句块。每一个 C# 程序至少有一个带有 Main 方法的类。

* 定义方法
* 调用方法

**C# 中定义方法**

```csharp
<Access Specifier> <Return Type> <Method Name>(Parameter List)
{
   Method Body
}
```

* **Access Specifier**：访问修饰符，这个决定了变量或方法对于另一个类的可见性。
* **Return type**：返回类型，一个方法可以返回一个值。返回类型是方法返回的值的数据类型。如果方法不返回任何值，则返回类型为 void。
* **Method name**：方法名称，是一个唯一的标识符，且是大小写敏感的。它不能与类中声明的其他标识符相同。
* **Parameter list**：参数列表，使用圆括号括起来，该参数是用来传递和接收方法的数据。参数列表是指方法的参数类型、顺序和数量。参数是可选的，也就是说，一个方法可能不包含参数。
* **Method body**：方法主体，包含了完成任务所需的指令集。

```csharp
class NumberManipulator
{
   public int FindMax(int num1, int num2)
   {
      /* 局部变量声明 */
      int result;

      if (num1 > num2)
         result = num1;
      else
         result = num2;

      return result;
   }
}
```

**C#中调用方法**

```csharp
using System;

namespace CalculatorApplication
{
   class NumberManipulator
   {
      public int FindMax(int num1, int num2)
      {
         /* 局部变量声明 */
         int result;

         if (num1 > num2)
            result = num1;
         else
            result = num2;

         return result;
      }
      static void Main(string[] args)
      {
         /* 局部变量定义 */
         int a = 100;
         int b = 200;
         int ret;
         NumberManipulator n = new NumberManipulator();

         //调用 FindMax 方法
         ret = n.FindMax(a, b);
         Console.WriteLine("最大值是： {0}", ret );
         Console.ReadLine();
      }
   }
}
```

**递归方法调用**

```csharp
using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int factorial(int num)
        {
            /* 局部变量定义 */
            int result;

            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }
   
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            //调用 factorial 方法
            Console.WriteLine("6 的阶乘是： {0}", n.factorial(6));
            Console.WriteLine("7 的阶乘是： {0}", n.factorial(7));
            Console.WriteLine("8 的阶乘是： {0}", n.factorial(8));
            Console.ReadLine();

        }
    }
}
```

**参数传递**

当调用带有参数的方法时，您需要向方法传递参数。在 C# 中，有三种向方法传递参数的方式：

方式|	描述
-|-
值参数|	这种方式复制参数的实际值给函数的形式参数，实参和形参使用的是两个不同内存中的值。在这种情况下，当形参的值发生改变时，不会影响实参的值，从而保证了实参数据的安全。
引用参数|	这种方式复制参数的内存位置的引用给形式参数。这意味着，当形参的值发生改变时，同时也改变实参的值。
输出参数|	这种方式可以返回多个值。

**按值传递参数**

这是参数传递的默认方式。在这种方式下，当调用一个方法时，会为每个值参数创建一个新的存储位置。

实际参数的值会复制给形参，实参和形参使用的是两个不同内存中的值。所以，当形参的值发生改变时，不会影响实参的值，从而保证了实参数据的安全。下面的实例演示了这个概念：

```csharp
using System;
namespace CalculatorApplication
{
   class NumberManipulator
   {
      public void swap(int x, int y)
      {
         int temp;
         
         temp = x; /* 保存 x 的值 */
         x = y;    /* 把 y 赋值给 x */
         y = temp; /* 把 temp 赋值给 y */
      }
     
      static void Main(string[] args)
      {
         NumberManipulator n = new NumberManipulator();
         /* 局部变量定义 */
         int a = 100;
         int b = 200;
         
         Console.WriteLine("在交换之前，a 的值： {0}", a);
         Console.WriteLine("在交换之前，b 的值： {0}", b);
         
         /* 调用函数来交换值 */
         n.swap(a, b);
         
         Console.WriteLine("在交换之后，a 的值： {0}", a);
         Console.WriteLine("在交换之后，b 的值： {0}", b);
         
         Console.ReadLine();
      }
   }
}
```

**按引用传递参数**

引用参数是一个对变量的`内存位置的引用`。当按引用传递参数时，与值参数不同的是，它不会为这些参数创建一个新的存储位置。引用参数表示与提供给方法的实际参数具有相同的内存位置。

在 C# 中，使用 ref 关键字声明引用参数。下面的实例演示了这点：

```csharp
using System;
namespace CalculatorApplication
{
   class NumberManipulator
   {
      public void swap(ref int x, ref int y)
      {
         int temp;

         temp = x; /* 保存 x 的值 */
         x = y;    /* 把 y 赋值给 x */
         y = temp; /* 把 temp 赋值给 y */
       }
   
      static void Main(string[] args)
      {
         NumberManipulator n = new NumberManipulator();
         /* 局部变量定义 */
         int a = 100;
         int b = 200;

         Console.WriteLine("在交换之前，a 的值： {0}", a);
         Console.WriteLine("在交换之前，b 的值： {0}", b);

         /* 调用函数来交换值 */
         n.swap(ref a, ref b);

         Console.WriteLine("在交换之后，a 的值： {0}", a);
         Console.WriteLine("在交换之后，b 的值： {0}", b);
 
         Console.ReadLine();

      }
   }
}
```

**按输出传递参数**

return 语句可用于只从函数中返回一个值。但是，可以使用 `输出参数` 来从函数中返回两个值。输出参数会把方法输出的数据赋给自己，其他方面与引用参数相似。

```csharp
using System;

namespace CalculatorApplication
{
   class NumberManipulator
   {
      public void getValue(out int x )
      {
         int temp = 5;
         x = temp;
      }
   
      static void Main(string[] args)
      {
         NumberManipulator n = new NumberManipulator();
         /* 局部变量定义 */
         int a = 100;
         
         Console.WriteLine("在方法调用之前，a 的值： {0}", a);
         
         /* 调用函数来获取值 */
         n.getValue(out a);

         Console.WriteLine("在方法调用之后，a 的值： {0}", a);
         Console.ReadLine();

      }
   }
}
```

提供给输出参数的变量不需要赋值。当需要从一个参数没有指定初始值的方法中返回值时，输出参数特别有用。请看下面的实例，来理解这一点：

```csharp
using System;

namespace CalculatorApplication
{
   class NumberManipulator
   {
      public void getValues(out int x, out int y )
      {
          Console.WriteLine("请输入第一个值： ");
          x = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("请输入第二个值： ");
          y = Convert.ToInt32(Console.ReadLine());
      }
   
      static void Main(string[] args)
      {
         NumberManipulator n = new NumberManipulator();
         /* 局部变量定义 */
         int a , b;
         
         /* 调用函数来获取值 */
         n.getValues(out a, out b);

         Console.WriteLine("在方法调用之后，a 的值： {0}", a);
         Console.WriteLine("在方法调用之后，b 的值： {0}", b);
         Console.ReadLine();
      }
   }
}
```


