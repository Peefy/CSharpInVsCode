
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

函数是一系列执行指定任务的语句。类的成员函数是在类内声明的。举例的类 Rectangle 包含了三个成员函数： AcceptDetails、GetArea 和 Display。

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

关键字是 C# 编译器预定义的保留字。这些关键字不能用作标识符，但是，如果想使用这些关键字作为标识符，可以在关键字前面加上 @ 字符作为前缀。

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

值类型直接包含数据。比如 int、char、float，它们分别存储数字、字符、浮点数。当声明一个 int 类型时，系统分配内存来存储值。

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

可以存储任何类型的值在动态数据类型变量中。这些变量的类型检查是在运行时发生的。

动态类型与对象类型相似，但是对象类型变量的类型检查是在编译时发生的，而动态类型变量的类型检查是在运行时发生的。

**字符串（String）类型**

`字符串（String）类型` 允许给变量分配任何字符串值。字符串（String）类型是 System.String 类的别名。它是从对象（Object）类型派生的。字符串（String）类型的值可以通过两种形式进行分配：引号和 @引号。

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

已经讨论了各种数据类型。C# 中提供的基本的值类型大致可以分为以下几类：

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
嵌套 if 语句|	可以在一个 if 或 else if 语句内使用另一个 if 或 else if 语句。
switch 语句|	一个 switch 语句允许测试一个变量等于多个值时的情况。
嵌套 switch 语句|	可以在一个 switch 语句内使用另一个 switch 语句。

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

循环语句允许多次执行一个语句或语句组，下面是大多数编程语言中循环语句的一般形式：

**循环类型**

循环类型|	描述
-|-
`while 循环`|	当给定条件为真时，重复语句或语句组。它会在执行循环主体之前测试条件。
`for/foreach 循环`|	多次执行一个语句序列，简化管理循环变量的代码。
`do...while 循环`| 除了它是在循环主体结尾测试条件外，其他与 while 语句类似。
`嵌套循环`|	可以在 while、for 或 do..while 循环内使用一个或多个循环。

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

当调用带有参数的方法时，需要向方法传递参数。在 C# 中，有三种向方法传递参数的方式：

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

**C# 可空类型（Nullable）**

`?` : 单问号用于对 int,double,bool 等无法直接赋值为 null 的数据类型进行 null 的赋值，意思是这个数据类型是 NullAble 类型的。

`??` : 双问号 可用于判断一个变量在为 null 时返回一个指定的值。

C# 提供了一个特殊的数据类型，nullable 类型（可空类型），可空类型可以表示其基础值类型正常范围内的值，再加上一个 null 值。

例如，Nullable< Int32 >，读作"可空的 Int32"，可以被赋值为 -2,147,483,648 到 2,147,483,647 之间的任意值，也可以被赋值为 null 值。类似的，Nullable< bool > 变量可以被赋值为 true 或 false 或 null。

在处理数据库和其他包含可能未赋值的元素的数据类型时，将 null 赋值给数值类型或布尔型的功能特别有用。例如，数据库中的布尔型字段可以存储值 true 或 false，或者，该字段也可以未定义。

声明一个 nullable 类型（可空类型）的语法如下

```csharp
using System;
namespace CalculatorApplication
{
   class NullablesAtShow
   {
      static void Main(string[] args)
      {
         int? num1 = null;
         int? num2 = 45;
         double? num3 = new double?();
         double? num4 = 3.14157;
         
         bool? boolval = new bool?();

         // 显示值
         
         Console.WriteLine("显示可空类型的值： {0}, {1}, {2}, {3}",
                            num1, num2, num3, num4);
         Console.WriteLine("一个可空的布尔值： {0}", boolval);
         Console.ReadLine();

      }
   }
}
```

**Null 合并运算符（ ?? ）**

Null 合并运算符用于定义可空类型和引用类型的默认值。Null 合并运算符为类型转换定义了一个预设值，以防可空类型的值为 Null。Null 合并运算符把操作数类型隐式转换为另一个可空（或不可空）的值类型的操作数的类型。

如果第一个操作数的值为 null，则运算符返回第二个操作数的值，否则返回第一个操作数的值。下面的实例演示了这点：

```csharp
using System;
namespace CalculatorApplication
{
   class NullablesAtShow
   {
         
      static void Main(string[] args)
      {
         
         double? num1 = null;
         double? num2 = 3.14157;
         double num3;
         num3 = num1 ?? 5.34;      // num1 如果为空值则返回 5.34
         Console.WriteLine("num3 的值： {0}", num3);
         num3 = num2 ?? 5.34;
         Console.WriteLine("num3 的值： {0}", num3);
         Console.ReadLine();

      }
   }
}
```

**C# 数组（Array）**

数组是一个存储相同类型元素的固定大小的顺序集合。数组是用来存储数据的集合，通常认为数组是一个同一类型变量的集合。

声明数组变量并不是声明 number0、number1、...、number99 一个个单独的变量，而是声明一个就像 numbers 这样的变量，然后使用 `numbers[0]`、`numbers[1]`、...、`numbers[99]` 来表示一个个单独的变量。数组中某个指定的元素是通过索引来访问的。

所有的数组都是由连续的内存位置组成的。最低的地址对应第一个元素，最高的地址对应最后一个元素。

**声明数组**

在 C# 中声明一个数组，可以使用下面的语法：

```csharp
datatype[] arrayName;
```

* datatype 用于指定被存储在数组中的元素的类型。
* [ ] 指定数组的秩（维度）。秩指定数组的大小。
* arrayName 指定数组的名称。

**初始化数组**

声明一个数组不会在内存中初始化数组。当初始化数组变量时，可以赋值给数组。

数组是一个引用类型，所以需要使用 new 关键字来创建数组的实例。

例如：

```csharp
double[] balance = new double[10];
```

**赋值给数组**

可以通过使用索引号赋值给一个单独的数组元素，比如：

```csharp
double[] balance = new double[10];
balance[0] = 4500.0;
```

**访问数组元素**

元素是通过带索引的数组名称来访问的。这是通过把元素的索引放置在数组名称后的方括号中来实现的。例如：

```csharp
double salary = balance[9];
```

```csharp
using System;
namespace ArrayApplication
{
   class MyArray
   {
      static void Main(string[] args)
      {
         int []  n = new int[10]; /* n 是一个带有 10 个整数的数组 */
         int i,j;


         /* 初始化数组 n 中的元素 */        
         for ( i = 0; i < 10; i++ )
         {
            n[ i ] = i + 100;
         }

         /* 输出每个数组元素的值 */
         for (j = 0; j < 10; j++ )
         {
            Console.WriteLine("Element[{0}] = {1}", j, n[j]);
         }
         Console.ReadKey();
      }
   }
}
```

**使用 foreach 循环**

使用一个 for 循环来访问每个数组元素。也可以使用一个 foreach 语句来遍历数组。

```csharp
using System;

namespace ArrayApplication
{
   class MyArray
   {
      static void Main(string[] args)
      {
         int []  n = new int[10]; /* n 是一个带有 10 个整数的数组 */


         /* 初始化数组 n 中的元素 */        
         for ( int i = 0; i < 10; i++ )
         {
            n[i] = i + 100;
         }

         /* 输出每个数组元素的值 */
         foreach (int j in n )
         {
            int i = j-100;
            Console.WriteLine("Element[{0}] = {1}", i, j);
         }
         Console.ReadKey();
      }
   }
}
```

**C# 数组细节**

概念|	描述
-|-
多维数组|	C# 支持多维数组。多维数组最简单的形式是二维数组。
交错数组|	C# 支持交错数组，即数组的数组。
传递数组给函数|	可以通过指定不带索引的数组名称来给函数传递一个指向数组的指针。
参数数组|	这通常用于传递未知数量的参数给函数。
Array 类|	在 System 命名空间中定义，是所有数组的基类，并提供了各种用于数组的属性和方法。

**C# 字符串（String）**

可以使用字符数组来表示字符串，但是，更常见的做法是使用 string 关键字来声明一个字符串变量。string 关键字是 System.String 类的别名。

**创建 String 对象**

* 通过给 String 变量指定一个字符串
* 通过使用 String 类构造函数
* 通过使用字符串串联运算符（ + ）
* 通过检索属性或调用一个返回字符串的方法
* 通过格式化方法来转换一个值或对象为它的字符串表示形式

```csharp
using System;

namespace StringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           //字符串，字符串连接
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //通过使用 string 构造函数
            char[] letters = { 'H', 'e', 'l', 'l','o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            //方法返回字符串
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //用于转化值的格式化方法
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}",
            waiting);
            Console.WriteLine("Message: {0}", chat);
            Console.ReadKey() ;
        }
    }
}
```

**String类的属性**

序号|	属性名称 & 描述
1|	Chars 在当前 String 对象中获取 Char 对象的指定位置。
2|	Length 在当前的 String 对象中获取字符数。

**String类的方法**

序号|	方法名称 & 描述
-|-
1|	public static int Compare( string strA, string strB ) 比较两个指定的 string 对象，并返回一个表示它们在排列顺序中相对位置的整数。该方法区分大小写。
2|	public static int Compare( string strA, string strB, bool ignoreCase ) 比较两个指定的 string 对象，并返回一个表示它们在排列顺序中相对位置的整数。但是，如果布尔参数为真时，该方法不区分大小写。
3|	public static string Concat( string str0, string str1 ) 连接两个 string 对象。
4|	public static string Concat( string str0, string str1, string str2 ) 连接三个 string 对象。
5|	public static string Concat( string str0, string str1, string str2, string str3 ) 连接四个 string 对象。
6|	public bool Contains( string value ) 返回一个表示指定 string 对象是否出现在字符串中的值。
7|	public static string Copy( string str ) 创建一个与指定字符串具有相同值的新的 String 对象。
8|	public void CopyTo( int sourceIndex, char[] destination, int destinationIndex, int count ) 从 string 对象的指定位置开始复制指定数量的字符到 Unicode 字符数组中的指定位置。
9|	public bool EndsWith( string value ) 判断 string 对象的结尾是否匹配指定的字符串。
10|	public bool Equals( string value ) 判断当前的 string 对象是否与指定的 string 对象具有相同的值。
11|	public static bool Equals( string a, string b ) 判断两个指定的 string 对象是否具有相同的值。
12|	public static string Format( string format, Object arg0 ) 把指定字符串中一个或多个格式项替换为指定对象的字符串表示形式。
13|	public int IndexOf( char value ) 返回指定 Unicode 字符在当前字符串中第一次出现的索引，索引从 0 开始。
14|	public int IndexOf( string value ) 返回指定字符串在该实例中第一次出现的索引，索引从 0 开始。
15|	public int IndexOf( char value, int startIndex ) 返回指定 Unicode 字符从该字符串中指定字符位置开始搜索第一次出现的索引，索引从 0 开始。
16|	public int IndexOf( string value, int startIndex ) 返回指定字符串从该实例中指定字符位置开始搜索第一次出现的索引，索引从 0 开始。
17|	public int IndexOfAny( char[] anyOf ) 返回某一个指定的 Unicode 字符数组中任意字符在该实例中第一次出现的索引，索引从 0 开始。
18|	public int IndexOfAny( char[] anyOf, int startIndex ) 返回某一个指定的 Unicode 字符数组中任意字符从该实例中指定字符位置开始搜索第一次出现的索引，索引从 0 开始。
19|	public string Insert( int startIndex, string value ) 返回一个新的字符串，其中，指定的字符串被插入在当前 string 对象的指定索引位置。
20|	public static bool IsNullOrEmpty( string value ) 指示指定的字符串是否为 null 或者是否为一个空的字符串。
21|	public static string Join( string separator, string[] value ) 连接一个字符串数组中的所有元素，使用指定的分隔符分隔每个元素。
22|	public static string Join( string separator, string[] value, int startIndex, int count ) 连接接一个字符串数组中的指定位置开始的指定元素，使用指定的分隔符分隔每个元素。
23|	public int LastIndexOf( char value ) 返回指定 Unicode 字符在当前 string 对象中最后一次出现的索引位置，索引从 0 开始。
24|	public int LastIndexOf( string value ) 返回指定字符串在当前 string 对象中最后一次出现的索引位置，索引从 0 开始。
25|	public string Remove( int startIndex ) 移除当前实例中的所有字符，从指定位置开始，一直到最后一个位置为止，并返回字符串。
26|	public string Remove( int startIndex, int count ) 从当前字符串的指定位置开始移除指定数量的字符，并返回字符串。
27|	public string Replace( char oldChar, char newChar ) 把当前 string 对象中，所有指定的 Unicode 字符替换为另一个指定的 Unicode 字符，并返回新的字符串。
28|	public string Replace( string oldValue, string newValue ) 把当前 string 对象中，所有指定的字符串替换为另一个指定的字符串，并返回新的字符串。
29|	public string[] Split( params char[] separator ) 返回一个字符串数组，包含当前的 string 对象中的子字符串，子字符串是使用指定的 Unicode 字符数组中的元素进行分隔的。
30|	public string[] Split( char[] separator, int count ) 返回一个字符串数组，包含当前的 string 对象中的子字符串，子字符串是使用指定的 Unicode 字符数组中的元素进行分隔的。int 参数指定要返回的子字符串的最大数目。
31|	public bool StartsWith( string value ) 判断字符串实例的开头是否匹配指定的字符串。
32|	public char[] ToCharArray() 返回一个带有当前 string 对象中所有字符的 Unicode 字符数组。
33|	public char[] ToCharArray( int startIndex, int length ) 返回一个带有当前 string 对象中所有字符的 Unicode 字符数组，从指定的索引开始，直到指定的长度为止。
34|	public string ToLower() 把字符串转换为小写并返回。
35|	public string ToUpper() 把字符串转换为大写并返回。
36|	public string Trim() 移除当前 String 对象中的所有前导空白字符和后置空白字符。

```csharp
using System;

namespace StringApplication
{
   class StringProg
   {
      static void Main(string[] args)
      {
         string str1 = "This is test";
         string str2 = "This is text";

         if (String.Compare(str1, str2) == 0)
         {
            Console.WriteLine(str1 + " and " + str2 +  " are equal.");
         }
         else
         {
            Console.WriteLine(str1 + " and " + str2 + " are not equal.");
         }
         Console.ReadKey() ;
      }
   }
}
```

**C# string.Format格式化日期**

```csharp
DateTime dt = new DateTime(2017,4,1,13,16,32,108);
string.Format("{0:y yy yyy yyyy}",dt); //17 17 2017 2017
string.Format("{0:M MM MMM MMMM}", dt);//4  04 四月 四月
string.Format("{0:d dd ddd dddd}", dt);//1  01 周六 星期六
string.Format("{0:t tt}", dt);//下 下午
string.Format("{0:H HH}", dt);//13 13
string.Format("{0:h hh}", dt);//1  01
string.Format("{0:m mm}", dt);//16 16
string.Format("{0:s ss}", dt);//32 32
string.Format("{0:F FF FFF FFFF FFFFF FFFFFF FFFFFFF}", dt);//1 1  108 108  108   108    108
string.Format("{0:f ff fff ffff fffff ffffff fffffff}", dt);//1 10 108 1080 10800 108000 1080000
string.Format("{0:z zz zzz}", dt);//+8 +08 +08:00

string.Format("{0:yyyy/MM/dd HH:mm:ss.fff}",dt);　　//2017/04/01 13:16:32.108
string.Format("{0:yyyy/MM/dd dddd}", dt);　　　　　　//2017/04/01 星期六
string.Format("{0:yyyy/MM/dd dddd tt hh:mm}", dt); //2017/04/01 星期六 下午 01:16
string.Format("{0:yyyyMMdd}", dt);　　　　　　　　　//20170401
string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", dt);　//2017-04-01 13:16:32.108
```

**C# 结构体（Struct）**

在 C# 中，结构体是值类型数据结构。它使得一个单一变量可以存储各种数据类型的相关数据。struct 关键字用于创建结构体。

**定义结构体**

为了定义一个结构体，必须使用 struct 语句。struct 语句为程序定义了一个带有多个成员的新的数据类型。

```csharp
struct Books
{
   public string title;
   public string author;
   public string subject;
   public int book_id;
};  

using System;
using System.Text;
     
struct Books
{
   public string title;
   public string author;
   public string subject;
   public int book_id;
};  

public class testStructure
{
   public static void Main(string[] args)
   {

      Books Book1;        /* 声明 Book1，类型为 Book */
      Books Book2;        /* 声明 Book2，类型为 Book */

      /* book 1 详述 */
      Book1.title = "C Programming";
      Book1.author = "Nuha Ali";
      Book1.subject = "C Programming Tutorial";
      Book1.book_id = 6495407;

      /* book 2 详述 */
      Book2.title = "Telecom Billing";
      Book2.author = "Zara Ali";
      Book2.subject =  "Telecom Billing Tutorial";
      Book2.book_id = 6495700;

      /* 打印 Book1 信息 */
      Console.WriteLine( "Book 1 title : {0}", Book1.title);
      Console.WriteLine("Book 1 author : {0}", Book1.author);
      Console.WriteLine("Book 1 subject : {0}", Book1.subject);
      Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

      /* 打印 Book2 信息 */
      Console.WriteLine("Book 2 title : {0}", Book2.title);
      Console.WriteLine("Book 2 author : {0}", Book2.author);
      Console.WriteLine("Book 2 subject : {0}", Book2.subject);
      Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);      

      Console.ReadKey();

   }
}
```

**C# 结构的特点**

C# 中的结构与传统的 C 或 C++ 中的结构不同。C# 中的结构有以下特点：

* 结构可带有方法、字段、索引、属性、运算符方法和事件。
* 结构可定义构造函数，但不能定义析构函数。但是，不能为结构定义无参构造函数。无参构造函数(默认)是自动定义的，且不能被改变。
* 与类不同，结构不能继承其他的结构或类。
* 结构不能作为其他结构或类的基础结构。
* 结构可实现一个或多个接口。
* 结构成员不能指定为 abstract、virtual 或 protected。
* 当使用 New 操作符创建一个结构对象时，会调用适当的构造函数来创建结构。与类不同，结构可以不使用 New 操作符即可被实例化。
* 如果不使用 New 操作符，只有在所有的字段都被初始化之后，字段才被赋值，对象才被使用。

**C#类和结构的区别**

* 类是引用类型，结构是值类型。
* 结构不支持继承。
* 结构不能声明默认的构造函数。

```csharp
using System;
using System.Text;
     
struct Books
{
   private string title;
   private string author;
   private string subject;
   private int book_id;
   public void getValues(string t, string a, string s, int id)
   {
      title = t;
      author = a;
      subject = s;
      book_id =id;
   }
   public void display()
   {
      Console.WriteLine("Title : {0}", title);
      Console.WriteLine("Author : {0}", author);
      Console.WriteLine("Subject : {0}", subject);
      Console.WriteLine("Book_id :{0}", book_id);
   }

};  

public class testStructure
{
   public static void Main(string[] args)
   {

      Books Book1 = new Books(); /* 声明 Book1，类型为 Book */
      Books Book2 = new Books(); /* 声明 Book2，类型为 Book */

      /* book 1 详述 */
      Book1.getValues("C Programming",
      "Nuha Ali", "C Programming Tutorial",6495407);

      /* book 2 详述 */
      Book2.getValues("Telecom Billing",
      "Zara Ali", "Telecom Billing Tutorial", 6495700);

      /* 打印 Book1 信息 */
      Book1.display();

      /* 打印 Book2 信息 */
      Book2.display();

      Console.ReadKey();

   }
}
```

**C# 枚举（Enum）**

枚举是一组命名整型常量。枚举类型是使用 enum 关键字声明的。

C# 枚举是值类型。换句话说，枚举包含自己的值，且不能继承或传递继承。

```csharp
using System;

public class EnumTest
{
    enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    static void Main()
    {
        int x = (int)Day.Sun;
        int y = (int)Day.Fri;
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Fri = {0}", y);
    }
}
```

**C# 类（Class）**

当定义一个类时，定义了一个数据类型的蓝图。这实际上并没有定义任何的数据，但它定义了类的名称意味着什么，也就是说，类的对象由什么组成及在这个对象上可执行什么操作。对象是类的实例。构成类的方法和变量成为类的成员。

**类的定义**

类的定义是以关键字 `class` 开始，后跟类的名称。类的主体，包含在一对花括号内。下面是类定义的一般形式：

```csharp
<access specifier> class  class_name
{
    // member variables
    <access specifier> <data type> variable1;
    <access specifier> <data type> variable2;
    ...
    <access specifier> <data type> variableN;
    // member methods
    <access specifier> <return type> method1(parameter_list)
    {
        // method body
    }
    <access specifier> <return type> method2(parameter_list)
    {
        // method body
    }
    ...
    <access specifier> <return type> methodN(parameter_list)
    {
        // method body
    }
}
```

*注意：*

* 访问标识符 `<access specifier>` 指定了对类及其成员的访问规则。如果没有指定，则使用默认的访问标识符。类的默认访问标识符是 internal，成员的默认访问标识符是 private。
* 数据类型 `<data type>` 指定了变量的类型，返回类型 `<return type>` 指定了返回的方法返回的数据类型。
* 如果要访问类的成员，要使用点（`.`）运算符。
* 点运算符链接了对象的名称和成员的名称。

```csharp
using System;
namespace BoxApplication
{
    class Box
    {
       public double length;   // 长度
       public double breadth;  // 宽度
       public double height;   // 高度
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();        // 声明 Box1，类型为 Box
            Box Box2 = new Box();        // 声明 Box2，类型为 Box
            double volume = 0.0;         // 体积

            // Box1 详述
            Box1.height = 5.0;
            Box1.length = 6.0;
            Box1.breadth = 7.0;

            // Box2 详述
            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;
           
            // Box1 的体积
            volume = Box1.height * Box1.length * Box1.breadth;
            Console.WriteLine("Box1 的体积： {0}",  volume);

            // Box2 的体积
            volume = Box2.height * Box2.length * Box2.breadth;
            Console.WriteLine("Box2 的体积： {0}", volume);
            Console.ReadKey();
        }
    }
}
```

**成员函数和封装**

类的成员函数是一个在类定义中有它的定义或原型的函数，就像其他变量一样。作为类的一个成员，它能在类的任何对象上操作，且能访问该对象的类的所有成员。

成员变量是对象的属性（从设计角度），且它们保持私有来实现封装。这些变量只能使用公共成员函数来访问。

让使用上面的概念来设置和获取一个类中不同的类成员的值：

```csharp
using System;
namespace BoxApplication
{
    class Box
    {
       private double length;   // 长度
       private double breadth;  // 宽度
       private double height;   // 高度
       public void setLength( double len )
       {
            length = len;
       }

       public void setBreadth( double bre )
       {
            breadth = bre;
       }

       public void setHeight( double hei )
       {
            height = hei;
       }
       public double getVolume()
       {
           return length * breadth * height;
       }
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();        // 声明 Box1，类型为 Box
            Box Box2 = new Box();                // 声明 Box2，类型为 Box
            double volume;                               // 体积


            // Box1 详述
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // Box2 详述
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);
       
            // Box1 的体积
            volume = Box1.getVolume();
            Console.WriteLine("Box1 的体积： {0}" ,volume);

            // Box2 的体积
            volume = Box2.getVolume();
            Console.WriteLine("Box2 的体积： {0}", volume);
           
            Console.ReadKey();
        }
    }
}
```

**C# 中的构造函数**

类的 构造函数 是类的一个特殊的成员函数，当创建类的新对象时执行。

构造函数的名称与类的名称完全相同，它没有任何返回类型。

下面的实例说明了构造函数的概念：

```csharp
using System;
namespace LineApplication
{
   class Line
   {
      private double length;   // 线条的长度
      public Line()
      {
         Console.WriteLine("对象已创建");
      }

      public void setLength( double len )
      {
         length = len;
      }
      public double getLength()
      {
         return length;
      }

      static void Main(string[] args)
      {
         Line line = new Line();    
         // 设置线条长度
         line.setLength(6.0);
         Console.WriteLine("线条的长度： {0}", line.getLength());
         Console.ReadKey();
      }
   }
}
```

`默认的构造函数`没有任何参数。但是如果需要一个带有参数的构造函数可以有参数，这种构造函数叫做`参数化构造函数`。这种技术可以帮助在创建对象的同时给对象赋初始值，具体请看下面实例：

```csharp
using System;
namespace LineApplication
{
   class Line
   {
      private double length;   // 线条的长度
      public Line(double len)  // 参数化构造函数
      {
         Console.WriteLine("对象已创建，length = {0}", len);
         length = len;
      }

      public void setLength( double len )
      {
         length = len;
      }
      public double getLength()
      {
         return length;
      }

      static void Main(string[] args)
      {
         Line line = new Line(10.0);
         Console.WriteLine("线条的长度： {0}", line.getLength());
         // 设置线条长度
         line.setLength(6.0);
         Console.WriteLine("线条的长度： {0}", line.getLength());
         Console.ReadKey();
      }
   }
}
```

**C# 中的析构函数**

类的 析构函数 是类的一个特殊的成员函数，当类的对象超出范围时执行。

析构函数的名称是在类的名称前加上一个波浪形（~）作为前缀，它不返回值，也不带任何参数。

析构函数用于在结束程序（比如关闭文件、释放内存等）之前释放资源。析构函数不能继承或重载。

下面的实例说明了析构函数的概念：

```csharp
using System;
namespace LineApplication
{
   class Line
   {
      private double length;   // 线条的长度
      public Line()  // 构造函数
      {
         Console.WriteLine("对象已创建");
      }
      ~Line() //析构函数
      {
         Console.WriteLine("对象已删除");
      }

      public void setLength( double len )
      {
         length = len;
      }
      public double getLength()
      {
         return length;
      }

      static void Main(string[] args)
      {
         Line line = new Line();
         // 设置线条长度
         line.setLength(6.0);
         Console.WriteLine("线条的长度： {0}", line.getLength());          
      }
   }
}
```

**C# 类的静态成员**

可以使用 static 关键字把类成员定义为静态的。当声明一个类成员为静态时，意味着无论有多少个类的对象被创建，只会有一个该静态成员的副本。

关键字 static 意味着类中只有一个该成员的实例。静态变量用于定义常量，因为它们的值可以通过直接调用类而不需要创建类的实例来获取。静态变量可在成员函数或类的定义外部进行初始化。也可以在类的定义内部初始化静态变量。

下面的实例演示了静态变量的用法：

```csharp
using System;
namespace StaticVarApplication
{
    class StaticVar
    {
       public static int num;
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }
    class StaticTester
    {
        static void Main(string[] args)
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();        
            Console.WriteLine("s1 的变量 num： {0}", s1.getNum());
            Console.WriteLine("s2 的变量 num： {0}", s2.getNum());
            Console.ReadKey();
        }
    }
}
```

也可以把一个`成员函数`声明为 `static`。这样的函数只能访问静态变量。静态函数在对象被创建之前就已经存在。下面的实例演示了`静态函数`的用法：

```cs
using System;
namespace StaticVarApplication
{
    class StaticVar
    {
       public static int num;
        public void count()
        {
            num++;
        }
        public static int getNum()
        {
            return num;
        }
    }
    class StaticTester
    {
        static void Main(string[] args)
        {
            StaticVar s = new StaticVar();
            s.count();
            s.count();
            s.count();                  
            Console.WriteLine("变量 num： {0}", StaticVar.getNum());
            Console.ReadKey();
        }
    }
}
```

**C# 继承**

继承是面向对象程序设计中最重要的概念之一。继承允许根据一个类来定义另一个类，这使得创建和维护应用程序变得更容易。同时也有利于重用代码和节省开发时间。

当创建一个类时，程序员不需要完全重新编写新的数据成员和成员函数，只需要设计一个新的类，继承了已有的类的成员即可。这个已有的类被称为的基类，这个新的类被称为派生类。

继承的思想实现了 属于（IS-A） 关系。例如，哺乳动物 属于（IS-A） 动物，狗 属于（IS-A） 哺乳动物，因此狗 属于（IS-A） 动物。

**基类和派生类**

一个类可以派生自多个类或接口，这意味着它可以从多个基类或接口继承数据和函数。

C# 中创建派生类的语法如下：

```cs
<访问修饰符符> class <基类>
{
 ...
}
class <派生类> : <基类>
{
 ...
}
```

```cs
using System;
namespace InheritanceApplication
{
   class Shape
   {
      public void setWidth(int w)
      {
         width = w;
      }
      public void setHeight(int h)
      {
         height = h;
      }
      protected int width;
      protected int height;
   }

   // 派生类
   class Rectangle: Shape
   {
      public int getArea()
      {
         return (width * height);
      }
   }
   
   class RectangleTester
   {
      static void Main(string[] args)
      {
         Rectangle Rect = new Rectangle();

         Rect.setWidth(5);
         Rect.setHeight(7);

         // 打印对象的面积
         Console.WriteLine("总面积： {0}",  Rect.getArea());
         Console.ReadKey();
      }
   }
}
```

**基类的初始化**

派生类继承了基类的成员变量和成员方法。因此父类对象应在子类对象创建之前被创建。可以在成员初始化列表中进行父类的初始化。

```cs
using System;
namespace RectangleApplication
{
   class Rectangle
   {
      // 成员变量
      protected double length;
      protected double width;
      public Rectangle(double l, double w)
      {
         length = l;
         width = w;
      }
      public double GetArea()
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
   class Tabletop : Rectangle
   {
      private double cost;
      public Tabletop(double l, double w) : base(l, w)
      { }
      public double GetCost()
      {
         double cost;
         cost = GetArea() * 70;
         return cost;
      }
      public void Display()
      {
         base.Display();
         Console.WriteLine("成本： {0}", GetCost());
      }
   }
   class ExecuteRectangle
   {
      static void Main(string[] args)
      {
         Tabletop t = new Tabletop(4.5, 7.5);
         t.Display();
         Console.ReadLine();
      }
   }
}
```

**C# 多重继承**

多重继承指的是一个类别可以同时从多于一个父类继承行为与特征的功能。与单一继承相对，单一继承指一个类别只可以继承自一个父类。

C# 不支持多重继承。但是，可以使用接口来实现多重继承。下面的程序演示了这点：

```cs
using System;
namespace InheritanceApplication
{
   class Shape
   {
      public void setWidth(int w)
      {
         width = w;
      }
      public void setHeight(int h)
      {
         height = h;
      }
      protected int width;
      protected int height;
   }

   // 基类 PaintCost
   public interface PaintCost
   {
      int getCost(int area);

   }
   // 派生类
   class Rectangle : Shape, PaintCost
   {
      public int getArea()
      {
         return (width * height);
      }
      public int getCost(int area)
      {
         return area * 70;
      }
   }
   class RectangleTester
   {
      static void Main(string[] args)
      {
         Rectangle Rect = new Rectangle();
         int area;
         Rect.setWidth(5);
         Rect.setHeight(7);
         area = Rect.getArea();
         // 打印对象的面积
         Console.WriteLine("总面积： {0}",  Rect.getArea());
         Console.WriteLine("油漆总成本： ${0}" , Rect.getCost(area));
         Console.ReadKey();
      }
   }
}
```

**C#多态性**

多态是同一个行为具有多个不同表现形式或形态的能力。

多态性意味着有多重形式。在面向对象编程范式中，多态性往往表现为"一个接口，多个功能"。

多态性可以是静态的或动态的。在静态多态性中，函数的响应是在编译时发生的。在动态多态性中，函数的响应是在运行时发生的。

在 C# 中，每个类型都是多态的，因为包括用户定义类型在内的所有类型都继承自 Object。

多态就是同一个接口，使用不同的实例而执行不同操作，如图所示：

**静态多态性**

在编译时，函数和对象的连接机制被称为早期绑定，也被称为静态绑定。C# 提供了两种技术来实现静态多态性。分别为：

* **函数重载**

可以在同一个范围内对相同的函数名有多个定义。函数的定义必须彼此不同，可以是参数列表中的参数类型不同，也可以是参数个数不同。不能重载只有返回类型不同的函数声明。

```cs
using System;
namespace PolymorphismApplication
{
    public class TestData  
    {  
        public int Add(int a, int b, int c)  
        {  
            return a + b + c;  
        }  
        public int Add(int a, int b)  
        {  
            return a + b;  
        }  
    }  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            TestData dataClass = new TestData();
            int add1 = dataClass.Add(1, 2);  
            int add2 = dataClass.Add(1, 2, 3);

            Console.WriteLine("add1 :" + add1);
            Console.WriteLine("add2 :" + add2);  
        }  
    }  
}
```

```cs
using System;
namespace PolymorphismApplication
{
   class Printdata
   {
      void print(int i)
      {
         Console.WriteLine("输出整型: {0}", i );
      }

      void print(double f)
      {
         Console.WriteLine("输出浮点型: {0}" , f);
      }

      void print(string s)
      {
         Console.WriteLine("输出字符串: {0}", s);
      }
      static void Main(string[] args)
      {
         Printdata p = new Printdata();
         // 调用 print 来打印整数
         p.print(1);
         // 调用 print 来打印浮点数
         p.print(1.23);
         // 调用 print 来打印字符串
         p.print("Hello Runoob");
         Console.ReadKey();
      }
   }
}
```

* **运算符重载**

**动态多态性**

C# 允许使用关键字 `abstract` 创建抽象类，用于提供接口的部分类的实现。当一个派生类继承自该抽象类时，实现即完成。抽象类包含抽象方法，抽象方法可被派生类实现。派生类具有更专业的功能。

请注意，下面是有关抽象类的一些规则：

* 不能创建一个抽象类的实例。
* 不能在一个抽象类外部声明一个抽象方法。
* 通过在类定义前面放置关键字 sealed，可以将类声明为密封类。当一个类被声明为 sealed 时，它不能被继承。抽象类不能被声明为 sealed。

```cs
using System;
namespace PolymorphismApplication
{
   abstract class Shape
   {
       abstract public int area();
   }
   class Rectangle:  Shape
   {
      private int length;
      private int width;
      public Rectangle( int a=0, int b=0)
      {
         length = a;
         width = b;
      }
      public override int area ()
      {
         Console.WriteLine("Rectangle 类的面积：");
         return (width * length);
      }
   }

   class RectangleTester
   {
      static void Main(string[] args)
      {
         Rectangle r = new Rectangle(10, 7);
         double a = r.area();
         Console.WriteLine("面积： {0}",a);
         Console.ReadKey();
      }
   }
}
```

当有一个定义在类中的函数需要在继承类中实现时，可以使用虚方法。

虚方法是使用关键字 virtual 声明的。

虚方法可以在不同的继承类中有不同的实现。

对虚方法的调用是在运行时发生的。

动态多态性是通过 抽象类 和 虚方法 实现的。

以下实例创建了 Shape 基类，并创建派生类 Circle、 Rectangle、Triangle， Shape 类提供一个名为 Draw 的虚拟方法，在每个派生类中重写该方法以绘制该类的指定形状。

```cs
using System;
using System.Collections.Generic;

public class Shape
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Height { get; set; }
    public int Width { get; set; }
   
    // 虚方法
    public virtual void Draw()
    {
        Console.WriteLine("执行基类的画图任务");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("画一个圆形");
        base.Draw();
    }
}
class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("画一个长方形");
        base.Draw();
    }
}
class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("画一个三角形");
        base.Draw();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 创建一个 List<Shape> 对象，并向该对象添加 Circle、Triangle 和 Rectangle
        var shapes = new List<Shape>
        {
            new Rectangle(),
            new Triangle(),
            new Circle()
        };

        // 使用 foreach 循环对该列表的派生类进行循环访问，并对其中的每个 Shape 对象调用 Draw 方法
        foreach (var shape in shapes)
        {
            shape.Draw();
        }

        Console.WriteLine("按下任意键退出。");
        Console.ReadKey();
    }
}
```

```cs
using System;
namespace PolymorphismApplication
{
   class Shape
   {
      protected int width, height;
      public Shape( int a=0, int b=0)
      {
         width = a;
         height = b;
      }
      public virtual int area()
      {
         Console.WriteLine("父类的面积：");
         return 0;
      }
   }
   class Rectangle: Shape
   {
      public Rectangle( int a=0, int b=0): base(a, b)
      {

      }
      public override int area ()
      {
         Console.WriteLine("Rectangle 类的面积：");
         return (width * height);
      }
   }
   class Triangle: Shape
   {
      public Triangle(int a = 0, int b = 0): base(a, b)
      {
     
      }
      public override int area()
      {
         Console.WriteLine("Triangle 类的面积：");
         return (width * height / 2);
      }
   }
   class Caller
   {
      public void CallArea(Shape sh)
      {
         int a;
         a = sh.area();
         Console.WriteLine("面积： {0}", a);
      }
   }  
   class Tester
   {
     
      static void Main(string[] args)
      {
         Caller c = new Caller();
         Rectangle r = new Rectangle(10, 7);
         Triangle t = new Triangle(10, 5);
         c.CallArea(r);
         c.CallArea(t);
         Console.ReadKey();
      }
   }
}
```

**C# 运算符重载**

可以重定义或重载 C# 中内置的运算符。因此，程序员也可以使用用户自定义类型的运算符。重载运算符是具有特殊名称的函数，是通过关键字 `operator` 后跟运算符的符号来定义的。与其他函数一样，重载运算符有返回类型和参数列表。

```cs
public static Box operator+ (Box b, Box c)
{
   Box box = new Box();
   box.length = b.length + c.length;
   box.breadth = b.breadth + c.breadth;
   box.height = b.height + c.height;
   return box;
}
```

**运算符重载的实现**

```cs
using System;

namespace OperatorOvlApplication
{
   class Box
   {
      private double length;      // 长度
      private double breadth;     // 宽度
      private double height;      // 高度

      public double getVolume()
      {
         return length * breadth * height;
      }
      public void setLength( double len )
      {
         length = len;
      }

      public void setBreadth( double bre )
      {
         breadth = bre;
      }

      public void setHeight( double hei )
      {
         height = hei;
      }
      // 重载 + 运算符来把两个 Box 对象相加
      public static Box operator+ (Box b, Box c)
      {
         Box box = new Box();
         box.length = b.length + c.length;
         box.breadth = b.breadth + c.breadth;
         box.height = b.height + c.height;
         return box;
      }

   }

   class Tester
   {
      static void Main(string[] args)
      {
         Box Box1 = new Box();         // 声明 Box1，类型为 Box
         Box Box2 = new Box();         // 声明 Box2，类型为 Box
         Box Box3 = new Box();         // 声明 Box3，类型为 Box
         double volume = 0.0;          // 体积

         // Box1 详述
         Box1.setLength(6.0);
         Box1.setBreadth(7.0);
         Box1.setHeight(5.0);

         // Box2 详述
         Box2.setLength(12.0);
         Box2.setBreadth(13.0);
         Box2.setHeight(10.0);

         // Box1 的体积
         volume = Box1.getVolume();
         Console.WriteLine("Box1 的体积： {0}", volume);

         // Box2 的体积
         volume = Box2.getVolume();
         Console.WriteLine("Box2 的体积： {0}", volume);

         // 把两个对象相加
         Box3 = Box1 + Box2;

         // Box3 的体积
         volume = Box3.getVolume();
         Console.WriteLine("Box3 的体积： {0}", volume);
         Console.ReadKey();
      }
   }
}
```

**可重载和不可重载运算符**

运算符|描述
-|-
`+, -, !, ~, ++, --`|	这些一元运算符只有一个操作数，且可以被重载。
`+, -, *, /, %`|	这些二元运算符带有两个操作数，且可以被重载。
`==, !=, <, >, <=, >=`|	这些比较运算符可以被重载。
`&&, ||`|	这些条件逻辑运算符不能被直接重载。
`+=, -=, *=, /=, %=`|	这些赋值运算符不能被重载。
`=, ., ?:, ->, new, is, sizeof, typeof`|	这些运算符不能被重载。

```cs
using System;

namespace OperatorOvlApplication
{
    class Box
    {
       private double length;      // 长度
       private double breadth;     // 宽度
       private double height;      // 高度
     
       public double getVolume()
       {
         return length * breadth * height;
       }
      public void setLength( double len )
      {
          length = len;
      }

      public void setBreadth( double bre )
      {
          breadth = bre;
      }

      public void setHeight( double hei )
      {
          height = hei;
      }
      // 重载 + 运算符来把两个 Box 对象相加
      public static Box operator+ (Box b, Box c)
      {
          Box box = new Box();
          box.length = b.length + c.length;
          box.breadth = b.breadth + c.breadth;
          box.height = b.height + c.height;
          return box;
      }
     
      public static bool operator == (Box lhs, Box rhs)
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
   
   class Tester
   {
      static void Main(string[] args)
      {
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

        Console.ReadKey();
      }
    }
}
```

**C#接口（Interface）**

接口定义了所有类继承接口时应遵循的语法合同。接口定义了语法合同 "是什么" 部分，派生类定义了语法合同 "怎么做" 部分。

接口定义了属性、方法和事件，这些都是接口的成员。接口只包含了成员的声明。成员的定义是派生类的责任。接口提供了派生类应遵循的标准结构。

接口使得实现接口的类或结构在形式上保持一致。

抽象类在某种程度上与接口类似，但是，它们大多只是用在当只有少数方法由基类声明由派生类实现时。

**定义接口**

```cs
using System;

interface IMyInterface
{
   // 接口成员
   void MethodToImplement();
}

class InterfaceImplementer : IMyInterface
{
    static void Main()
    {
        InterfaceImplementer iImp = new InterfaceImplementer();
        iImp.MethodToImplement();
    }

    public void MethodToImplement()
    {
        Console.WriteLine("MethodToImplement() called.");
    }
}
```

**接口继承: InterfaceInheritance.cs**

```cs
using System;

interface IParentInterface
{
    void ParentInterfaceMethod();
}

interface IMyInterface : IParentInterface
{
    void MethodToImplement();
}

class InterfaceImplementer : IMyInterface
{
    static void Main()
    {
        InterfaceImplementer iImp = new InterfaceImplementer();
        iImp.MethodToImplement();
        iImp.ParentInterfaceMethod();
    }

    public void MethodToImplement()
    {
        Console.WriteLine("MethodToImplement() called.");
    }

    public void ParentInterfaceMethod()
    {
        Console.WriteLine("ParentInterfaceMethod() called.");
    }
}
```

*注意：*

* 接口方法不能用public abstract等修饰。接口内不能有字段变量，构造函数。
* 接口内可以定义属性（有get和set的方法）。如string color { get ; set ; }这种。
* 实现接口时，必须和接口的格式一致。
* 必须实现接口的所有方法。

接口的定义是指定一组函数成员而不实现成员的引用类型，其它类型和接口可以继承接口。定义还是很好理解的，但是没有反映特点，接口主要有以下特点：

* (1)通过接口可以实现多重继承，C# 接口的成员不能有 public、protected、internal、private 等修饰符。原因很简单，接口里面的方法都需要由外面接口实现去实现方法体，那么其修饰符必然是 public。C# 接口中的成员默认是 public 的，java 中是可以加 public 的。
* (2)接口成员不能有 new、static、abstract、override、virtual 修饰符。有一点要注意，当一个接口实现一个接口，这2个接口中有相同的方法时，可用 new 关键字隐藏父接口中的方法。
* (3)接口中只包含成员的签名，接口没有构造函数，所有不能直接使用 new 对接口进行实例化。接口中只能包含方法、属性、事件和索引的组合。接口一旦被实现，实现类必须实现接口中的所有成员，除非实现类本身是抽象类。
* (4)C# 是单继承，接口是解决 C# 里面类可以同时继承多个基类的问题。

**C# 命名空间（Namespace）**

命名空间的设计目的是提供一种让一组名称与其他名称分隔开的方式。在一个命名空间中声明的类的名称与另一个命名空间中声明的相同的类的名称不冲突。

```cs
using System;
namespace first_space
{
   class namespace_cl
   {
      public void func()
      {
         Console.WriteLine("Inside first_space");
      }
   }
}
namespace second_space
{
   class namespace_cl
   {
      public void func()
      {
         Console.WriteLine("Inside second_space");
      }
   }
}  
class TestClass
{
   static void Main(string[] args)
   {
      first_space.namespace_cl fc = new first_space.namespace_cl();
      second_space.namespace_cl sc = new second_space.namespace_cl();
      fc.func();
      sc.func();
      Console.ReadKey();
   }
}
```

**using 关键字**

using 关键字表明程序使用的是给定命名空间中的名称。例如，在程序中使用 System 命名空间，其中定义了类 Console。可以只写：

```cs
using System;
using first_space;
using second_space;

namespace first_space
{
   class abc
   {
      public void func()
      {
         Console.WriteLine("Inside first_space");
      }
   }
}
namespace second_space
{
   class efg
   {
      public void func()
      {
         Console.WriteLine("Inside second_space");
      }
   }
}  
class TestClass
{
   static void Main(string[] args)
   {
      abc fc = new abc();
      efg sc = new efg();
      fc.func();
      sc.func();
      Console.ReadKey();
   }
}
```

**嵌套命名空间**

```cs
namespace namespace_name1 
{
   // 代码声明
   namespace namespace_name2 
   {
     // 代码声明
   }
}
```

```cs
using System;
using SomeNameSpace;
using SomeNameSpace.Nested;

namespace SomeNameSpace
{
    public class MyClass
    {
        static void Main()
        {
            Console.WriteLine("In SomeNameSpace");
            Nested.NestedNameSpaceClass.SayHello();
        }
    }

    // 内嵌命名空间
    namespace Nested  
    {
        public class NestedNameSpaceClass
        {
            public static void SayHello()
            {
                Console.WriteLine("In Nested");
            }
        }
    }
}
```

**C#预处理器指令**

预处理器指令指导编译器在实际编译开始之前对信息进行预处理。

所有的预处理器指令都是以 # 开始。且在一行上，只有空白字符可以出现在预处理器指令之前。预处理器指令不是语句，所以它们不以分号（;）结束。

C# 编译器没有一个单独的预处理器，但是，指令被处理时就像是有一个单独的预处理器一样。在 C# 中，预处理器指令用于在条件编译中起作用。与 C 和 C++ 不同的是，它们不是用来创建宏。一个预处理器指令必须是该行上的唯一指令。

**C# 预处理器指令列表**

预处理器指令|	描述
-|-
`#define`|	它用于定义一系列成为符号的字符。
`#undef`|	它用于取消定义符号。
`#if`|	它用于测试符号是否为真。
`#else`|	它用于创建复合条件指令，与 #if 一起使用。
`#elif`|	它用于创建复合条件指令。
`#endif`|	指定一个条件指令的结束。
`#line`|	它可以让修改编译器的行数以及（可选地）输出错误和警告的文件名。
`#error`|	它允许从代码的指定位置生成一个错误。
`#warning`|	它允许从代码的指定位置生成一级警告。
`#region`|	它可以让在使用 Visual Studio Code Editor 的大纲特性时，指定一个可展开或折叠的代码块。
`#endregion`|	它标识着 #region 块的结束。

**#define 预处理器**

#define 预处理器指令创建符号常量。

#define 允许定义一个符号，这样，通过使用符号作为传递给 #if 指令的表达式，表达式将返回 true。它的语法如下：

```cs
#define PI
using System;
namespace PreprocessorDAppl
{
   class Program
   {
      static void Main(string[] args)
      {
         #if (PI)
            Console.WriteLine("PI is defined");
         #else
            Console.WriteLine("PI is not defined");
         #endif
         Console.ReadKey();
      }
   }
}
```

**条件指令**

可以使用 #if 指令来创建一个条件指令。条件指令用于测试符号是否为真。如果为真，编译器会执行 #if 和下一个指令之间的代码。

条件指令的语法：

```cs
#if symbol [operator symbol]...
```

symbol 是要测试的符号名称。也可以使用 true 和 false，或在符号前放置否定运算符。

常见运算符有：

* == (等于)
* != (不等于)
* && (与)
* || (或)

也可以用括号把符号和运算符进行分组。条件指令用于在调试版本或编译指定配置时编译代码。一个以 `#if` 指令开始的条件指令，必须显示地以一个 `#endif` 指令终止。

```cs
#define DEBUG
#define VC_V10
using System;
public class TestClass
{
   public static void Main()
   {

      #if (DEBUG && !VC_V10)
         Console.WriteLine("DEBUG is defined");
      #elif (!DEBUG && VC_V10)
         Console.WriteLine("VC_V10 is defined");
      #elif (DEBUG && VC_V10)
         Console.WriteLine("DEBUG and VC_V10 are defined");
      #else
         Console.WriteLine("DEBUG and VC_V10 are not defined");
      #endif
      Console.ReadKey();
   }
}
```

在程序调试和运行上有重要的作用。比如预处理器指令可以禁止编译器编译代码的某一部分，如果计划发布两个版本的代码，即基本版本和有更多功能的企业版本，就可以使用这些预处理器指令来控制。在编译软件的基本版本时，使用预处理器指令还可以禁止编译器编译于额外功能相关的代码。另外，在编写提供调试信息的代码时，也可以使用预处理器指令进行控制。总的来说和普通的控制语句（if等）功能类似，方便在于预处理器指令包含的未执行部分是不需要编译的。

**#warning 和 #error**

当编译器遇到它们时，会分别产生警告或错误。如果编译器遇到 #warning 指令，会给用户显示 #warning 指令后面的文本，之后编译继续进行。如果编译器遇到 #error 指令，就会给用户显示后面的文本，作为一条编译错误消息，然后会立即退出编译。使用这两条指令可以检查 #define 语句是不是做错了什么事，使用 #warning 语句可以提醒自己执行某个操作。

```cs
#if DEBUG && RELEASE  
#error "You've defined DEBUG and RELEASE simultaneously!"  
#endif  
#warning "Don't forget to remove this line before the boss tests the code!"  
Console.WriteLine("*I hate this job.*");
```

**#region 和 #endregion**

#region 和 #endregion 指令用于把一段代码标记为有给定名称的一个块，如下所示:

```cs
#region Member Field Declarations
int x;
double d;
Currency balance;
#endregion
```

**#line**

#line 指令可以用于改变编译器在警告和错误信息中显示的文件名和行号信息，不常用。

如果编写代码时，在把代码发送给编译器前，要使用某些软件包改变输入的代码，就可以使用这个指令，因为这意味着编译器报告的行号或文件名与文件中的行号或编辑的文件名不匹配。#line指令可以用于还原这种匹配。也可以使用语法#line default把行号还原为默认的行号：

```cs
#line 164 "Core.cs" // 在文件的第 164 行
// Core.cs, before the intermediate
// package mangles it.
// later on
#line default // 恢复默认行号
```

**#pragma**

#pragma 指令可以抑制或还原指定的编译警告。与命令行选项不同，#pragma 指令可以在类或方法级别执行，对抑制警告的内容和抑制的时间进行更精细的控制。如下：

```cs
#pragma warning disable 169    // 取消编号 169 的警告（字段未使用的警告）
public class MyClass
{
    int neverUsedField;       // 编译整个 MyClass 类时不会发出警告
}
#pragma warning restore 169   // 恢复编号 169 的警告
```

**C# 正则表达式**

**正则表达式** 是一种匹配输入文本的模式。.Net 框架提供了允许这种匹配的正则表达式引擎。模式由一个或多个字符、运算符和结构组成。

**定义正则表达式**

下面列出了用于定义正则表达式的各种类别的字符、运算符和结构。

* 字符转义
* 字符类
* 定位点
* 分组构造
* 限定符
* 反向引用构造
* 备用构造
* 替换
* 杂项构造

**字符转义**

正则表达式中的反斜杠字符（\）指示其后跟的字符是特殊字符，或应按原义解释该字符。

下表列出了转义字符：

转义字符|	描述|	模式|	匹配
-|-|-|-
`\a`|	与报警 (bell) 符 \u0007 匹配。|	`\a`|	"Warning!" + '\u0007' 中的 "\u0007"
`\b`|	在字符类中，与退格键 \u0008 匹配。|	`[\b]{3,}` |	"\b\b\b\b" 中的 "\b\b\b\b"
`\t`|	与制表符 \u0009 匹配。|	`(\w+)\t`|	"Name\tAddr\t" 中的 "Name\t" 和 "Addr\t"
`\r`|	与回车符 \u000D 匹配。（\r 与换行符 \n 不是等效的。）|	`\r\n(\w+)`|	"\r\Hello\nWorld." 中的 "\r\nHello"
`\v`|	与垂直制表符 \u000B 匹配。|	`[\v]{2,}` |	"\v\v\v" 中的 "\v\v\v"
`\f`|	与换页符 \u000C 匹配。|	`[\f]{2,}`  |	"\f\f\f" 中的 "\f\f\f"
`\n`|	与换行符 \u000A 匹配。|	`\r\n(\w+)`  |	"\r\Hello\nWorld." 中的 "\r\nHello"
`\e`|	与转义符 \u001B 匹配。|	`\e` |	"\x001B" 中的 "\x001B"
`\ nnn`|	使用八进制表示形式指定一个字符（nnn 由二到三位数字组成）。|	`\w\040\w` |	"a bc d" 中的 "a b" 和 "c d"
`\x nn`|	使用十六进制表示形式指定字符（nn 恰好由两位数字组成）。|	`\w\x20\w` |	"a bc d" 中的 "a b" 和 "c d"
`\c X \c x`|	匹配 X 或 x 指定的 ASCII 控件字符，其中 X 或 x 是控件字符的字母。|	`\cC`|	"\x0003" 中的 "\x0003" (Ctrl-C)
`\u nnnn`|	使用十六进制表示形式匹配一个 Unicode 字符（由 nnnn 表示的四位数）。|	`\w\u0020\w` |	"a bc d" 中的 "a b" 和 "c d"
`\` |	在后面带有不识别的转义字符时，与该字符匹配。|	`\d+[\+-x\*]\d+\d+[\+-x\*\d+`|	`"(2+2) * 3*9" 中的 "2+2" 和 "3*9"`

**字符类**

字符类与一组字符中的任何一个字符匹配。

下表列出了字符类：

字符类|	描述|	模式|	匹配
-|-|-|-
`[character_group]` |	匹配 character_group 中的任何单个字符。 默认情况下，匹配区分大小写。|	`[mn]` | "mat" 中的 "m"，"moon" 中的 "m" 和 "n"
`[^character_group]` |	非：与不在 character_group 中的任何单个字符匹配。 默认情况下，character_group 中的字符区分大小写。|	`[^aei]` |	"avail" 中的 "v" 和 "l"
`[ first - last ]` |	字符范围：与从 first 到 last 的范围中的任何单个字符匹配。|	`[b-d]`|	`[b-d]`irds 可以匹配 Birds、 Cirds、 Dirds
`.` |	通配符：与除 \n 之外的任何单个字符匹配。若要匹配原意句点字符（. 或 \u002E），必须在该字符前面加上转义符 `(\.)`。 |	`a.e` |	"have" 中的 "ave"， "mate" 中的 "ate"
`\p{ name }` |	与 name 指定的 Unicode 通用类别或命名块中的任何单个字符匹配。|	`\p{Lu}` |	"City Lights" 中的 "C" 和 "L"
`\P{ name }` |	与不在 name 指定的 Unicode 通用类别或命名块中的任何单个字符匹配。	| `\P{Lu}` |	"City" 中的 "i"、 "t" 和 "y"
`\w` |	与任何单词字符匹配。|	`\w` |	"Room#1" 中的 "R"、 "o"、 "m" 和 "1"
`\W` |	与任何非单词字符匹配。|	`\W` | "Room#1" 中的 "#"
`\s` |	与任何空白字符匹配。|	`\w\s` |	"ID A1.3" 中的 "D "
`\S` |	与任何非空白字符匹配。|	`\s\S` |	"int __ctr" 中的 " _"
`\d` |	与任何十进制数字匹配。|	`\d` |	"4 = IV" 中的 "4"
`\D` |	匹配不是十进制数的任意字符。|	`\D` |	"4 = IV" 中的 " "、 "="、 " "、 "I" 和 "V"

**定位点**

定位点或原子零宽度断言会使匹配成功或失败，具体取决于字符串中的当前位置，但它们不会使引擎在字符串中前进或使用字符。

下表列出了定位点：

断言|	描述|	模式|	匹配
-|-|-|-
`^`|	匹配必须从字符串或一行的开头开始。|	`^\d{3}` |	"567-777-" 中的 "567"
`$`| 匹配必须出现在字符串的末尾或出现在行或字符串末尾的 \n 之前。|	`-\d{4}$`|	"8-12-2012" 中的 "-2012"
`\A`|	匹配必须出现在字符串的开头。|	`\A\w{4}` |	"Code-007-" 中的 "Code"
`\Z`|	匹配必须出现在字符串的末尾或出现在字符串末尾的 \n 之前。 |	`-\d{3}\Z` |	"Bond-901-007" 中的 "-007"
`\z`|	匹配必须出现在字符串的末尾。|	`-\d{3}\z` |	"-901-333" 中的 "-333"
`\G`|	匹配必须出现在上一个匹配结束的地方。|	`\G\(\d\)` |	`"(1)(3)(5)[7](9)" 中的 "(1)"、 "(3)" 和 "(5)"`
`\b`|	匹配一个单词边界，也就是指单词和空格间的位置。|	`er\b` |	匹配"never"中的"er"，但不能匹配"verb"中的"er"。
`\B`|	匹配非单词边界。|	`er\B` |	匹配"verb"中的"er"，但不能匹配"never"中的"er"。

**分组构造**

分组构造描述了正则表达式的子表达式，通常用于捕获输入字符串的子字符串。

分组构造|	描述|	模式|	匹配
-|-|-|-
`( subexpression )`|	捕获匹配的子表达式并将其分配到一个从零开始的序号中。|	`(\w)\1` |	"deep" 中的 "ee"
`(?< name >subexpression)` |	将匹配的子表达式捕获到一个命名组中。|	`(?< double>\w)\k< double>`|	"deep" 中的 "ee"
`(?< name1 -name2 >subexpression)` |	定义平衡组定义。|	`(((?'Open'\()[^\(\)]*)+((?'Close-Open'\))[^\(\)]*)+)*(?(Open)(?!))$`|	`"3+2^((1-3)*(3-1))"` 中的 `"((1-3)*(3-1))"`
`(?: subexpression)`|	定义非捕获组。|	`Write(?:Line)?` |	"Console.WriteLine()" 中的 "WriteLine"
`(?imnsx-imnsx:subexpression)`|	应用或禁用 subexpression 中指定的选项。|	`A\d{2}(?i:\w+)\b`|	"A12xl A12XL a12xl" 中的 "A12xl" 和 "A12XL"
`(?= subexpression)`|	零宽度正预测先行断言。|	`\w+(?=\.)`|	"He is. The dog ran. The sun is out." 中的 "is"、 "ran" 和 "out"
`(?! subexpression)`|	零宽度负预测先行断言。|	`\b(?!un)\w+\b`|	"unsure sure unity used" 中的 "sure" 和 "used"
`(?<=subexpression)`|	零宽度正回顾后发断言。|	`(?<=19)\d{2}\b` |	"1851 1999 1950 1905 2003" 中的 "99"、"50"和 "05"
`(?<! subexpression)`|	零宽度负回顾后发断言。|	`(?<!wo)man\b` |	"Hi woman Hi man" 中的 "man"
`(?> subexpression)` |	非回溯（也称为"贪婪"）子表达式。|	`[13579](?>A+B+)` |	"1ABB 3ABBC 5AB 5AC" 中的 "1ABB"、 "3ABB" 和 "5AB"

```cs
using System;
using System.Text.RegularExpressions;

public class Example
{
   public static void Main()
   {
      string input = "1851 1999 1950 1905 2003";
      string pattern = @"(?<=19)\d{2}\b";

      foreach (Match match in Regex.Matches(input, pattern))
         Console.WriteLine(match.Value);
   }
}
```

**限定符**

限定符指定在输入字符串中必须存在上一个元素（可以是字符、组或字符类）的多少个实例才能出现匹配项。 限定符包括下表中列出的语言元素。

下表列出了限定符：

限定符|	描述|	模式|	匹配
-|-|-|-
`*`|	匹配上一个元素零次或多次。|	`\d*\.\d` |	".0"、 "19.9"、 "219.9"
`+`|	匹配上一个元素一次或多次。|	`"be+"` |	"been" 中的 "bee"， "bent" 中的 "be"
`?`|	匹配上一个元素零次或一次。|	`"rai?n"` |	"ran"、 "rain"
`{ n }`|	匹配上一个元素恰好 n 次。|	`",\d{3}"` |	"1,043.6" 中的 ",043"， "9,876,543,210" 中的 ",876"、 ",543" 和 ",210"
`{ n ,}`|	匹配上一个元素至少 n 次。|	`"\d{2,}"` |	"166"、 "29"、 "1930"
`{ n , m }`|	匹配上一个元素至少 n 次，但不多于 m 次。|	`"\d{3,5}"` |	"166"， "17668"， "193024" 中的 "19302"
`*?`|	匹配上一个元素零次或多次，但次数尽可能少。|	`\d*?\.\d` |	".0"、 "19.9"、 "219.9"
`+?`|	匹配上一个元素一次或多次，但次数尽可能少。 |	`"be+?"` |	"been" 中的 "be"， "bent" 中的 "be"
`??`|	匹配上一个元素零次或一次，但次数尽可能少。|	`"rai??n"` |	"ran"、 "rain"
`{ n }?`|	匹配前导元素恰好 n 次。|	`",\d{3}?"` |	"1,043.6" 中的 ",043"， "9,876,543,210" 中的 ",876"、 ",543" 和 ",210"
`{ n ,}?`|	匹配上一个元素至少 n 次，但次数尽可能少。|	`"\d{2,}?"` |	"166"、 "29" 和 "1930"
`{ n , m }?`|	匹配上一个元素的次数介于 n 和 m 之间，但次数尽可能少。|	`"\d{3,5}?"` |	"166"， "17668"， "193024" 中的 "193" 和 "024"

**反向引用构造**

反向引用允许在同一正则表达式中随后标识以前匹配的子表达式。

下表列出了反向引用构造：

反向引用构造|	描述|	模式|	匹配
-|-|-|-
`\ number`|	反向引用。 匹配编号子表达式的值。|	`(\w)\1` |	"seek" 中的 "ee"
`\k< name >`|	命名反向引用。 匹配命名表达式的值。|	`(?< char>\w)\k< char>` |	"seek" 中的 "ee"

**备用构造**

备用构造用于修改正则表达式以启用 either/or 匹配。

下表列出了备用构造：

备用构造|	描述|	模式|	匹配
-|-|-|-
`|` |	匹配以竖线 `(|)` 字符分隔的任何一个元素。 |	`th(e|is|at)` |	"this is the day. " 中的 "the" 和 "this"
`(?( expression )yes | no )` |	如果正则表达式模式由 expression 匹配指定，则匹配 yes；否则匹配可选的 no 部分。 expression 被解释为零宽度断言。 |	`(?(A)A\d{2}\b|\b\d{3}\b)` |	"A10 C103 910" 中的 "A10" 和 "910"
`(?( name )yes | no )` |	如果 name 或已命名或已编号的捕获组具有匹配，则匹配 yes；否则匹配可选的 no。 |	`(?< quoted>")?(?(quoted).+?"|\S+\s)` |	"Dogs.jpg "Yiska playing.jpg"" 中的 Dogs.jpg 和 "Yiska playing.jpg"

**替换**

替换是替换模式中使用的正则表达式。

下表列出了用于替换的字符：

字符|	描述|	模式|	替换模式|	输入字符串|	结果字符串
-|-|-|-|-|-
`$number`|	替换按组 number 匹配的子字符串。|	`\b(\w+)(\s)(\w+)\b` |	$3$2$1 |	`"one two"` |	`"two one"`
`${name}`|	替换按命名组 name 匹配的子字符串。|	`\b(?< word1>\w+)(\s)(?< word2>\w+)\b` |	${word2} ${word1} |	"one two" |	"two one"
`$$`	|替换字符"$"。 |	`\b(\d+)\s?USD` |	`$$$1` |	"103 USD" |	"$103"
`$&`	|替换整个匹配项的一个副本。|	`(\$*(\d*(\.+\d+)?){1})`	| `**$&` |	`"$1.30"`	 | `"**$1.30**"`
$\`	|替换匹配前的输入字符串的所有文本。|	`B+` |	$\` |	"AABBCC" |	"AAAACC"
`$'`|	替换匹配后的输入字符串的所有文本。| `B+`	 | `$'` |	"AABBCC" |	"AACCCC"
`$+`|	替换最后捕获的组。|	`B+(C+)` | `$+` |	"AABBCCDD" |	"AACCDD"
`$_`|	替换整个输入字符串。 |	`B+` |	`$_`	| "AABBCC"	| "AAAABBCCCC"

**杂项结构**

构造|	描述|	实例
-|-|-
`(?imnsx-imnsx)` |	在模式中间对诸如不区分大小写这样的选项进行设置或禁用。|	\bA(?i)b\w+\b 匹配 "ABA Able Act" 中的 "ABA" 和 "Able"
`(?#注释)` |	内联注释。该注释在第一个右括号处终止。|	\bA(?#匹配以A开头的单词)\w+\b
`# [行尾]` |	该注释以非转义的 # 开头，并继续到行的结尾。 |	(?x)\bA\w+\b#匹配以 A 开头的单词

**Regex类**

Regex 类用于表示一个正则表达式。

下表列出了 Regex 类中一些常用的方法：

序号|	方法 & 描述
-|-
1|	public bool IsMatch( string input ) 指示 Regex 构造函数中指定的正则表达式是否在指定的输入字符串中找到匹配项。
2|	public bool IsMatch( string input, int startat ) 指示 Regex 构造函数中指定的正则表达式是否在指定的输入字符串中找到匹配项，从字符串中指定的开始位置开始。
3|	public static bool IsMatch( string input, string pattern ) 指示指定的正则表达式是否在指定的输入字符串中找到匹配项。
4|	public MatchCollection Matches( string input ) 在指定的输入字符串中搜索正则表达式的所有匹配项。
5|	public string Replace( string input, string replacement ) 在指定的输入字符串中，把所有匹配正则表达式模式的所有匹配的字符串替换为指定的替换字符串。
6|	public string[] Split( string input ) 把输入字符串分割为子字符串数组，根据在 Regex 构造函数中指定的正则表达式模式定义的位置进行分割。

```cs
using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
   class Program
   {
      private static void showMatch(string text, string expr)
      {
         Console.WriteLine("The Expression: " + expr);
         MatchCollection mc = Regex.Matches(text, expr);
         foreach (Match m in mc)
         {
            Console.WriteLine(m);
         }
      }
      static void Main(string[] args)
      {
         string str = "A Thousand Splendid Suns";

         Console.WriteLine("Matching words that start with 'S': ");
         showMatch(str, @"\bS\S*");
         Console.ReadKey();
      }
   }
}
```

```cs
using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
   class Program
   {
      private static void showMatch(string text, string expr)
      {
         Console.WriteLine("The Expression: " + expr);
         MatchCollection mc = Regex.Matches(text, expr);
         foreach (Match m in mc)
         {
            Console.WriteLine(m);
         }
      }
      static void Main(string[] args)
      {
         string str = "make maze and manage to measure it";

         Console.WriteLine("Matching words start with 'm' and ends with 'e':");
         showMatch(str, @"\bm\S*e\b");
         Console.ReadKey();
      }
   }
}
```

```cs
using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
   class Program
   {
      static void Main(string[] args)
      {
         string input = "Hello   World   ";
         string pattern = "\\s+";
         string replacement = " ";
         Regex rgx = new Regex(pattern);
         string result = rgx.Replace(input, replacement);

         Console.WriteLine("Original String: {0}", input);
         Console.WriteLine("Replacement String: {0}", result);    
         Console.ReadKey();
      }
   }
}
```

**C# 异常处理**

异常是在程序执行期间出现的问题。C# 中的异常是对程序运行时出现的特殊情况的一种响应，比如尝试除以零。

异常提供了一种把程序控制权从某个部分转移到另一个部分的方式。C# 异常处理时建立在四个关键词之上的：`try`、`catch`、`finally` 和 `throw`。

* **try**：一个 try 块标识了一个将被激活的特定的异常的代码块。后跟一个或多个 catch 块。
* **catch**：程序通过异常处理程序捕获异常。catch 关键字表示异常的捕获。
* **finally**：finally 块用于执行给定的语句，不管异常是否被抛出都会执行。例如，如果打开一个文件，不管是否出现异常文件都要被关闭。
* **throw**：当问题出现时，程序抛出一个异常。使用 throw 关键字来完成。

**C# 中的异常类**

C# 异常是使用类来表示的。

异常类|	描述
-|-
System.IO.IOException|	处理 I/O 错误。
System.IndexOutOfRangeException|	处理当方法指向超出范围的数组索引时生成的错误。
System.ArrayTypeMismatchException|	处理当数组类型不匹配时生成的错误。
System.NullReferenceException|	处理当依从一个空对象时生成的错误。
System.DivideByZeroException|	处理当除以零时生成的错误。
System.InvalidCastException|	处理在类型转换期间生成的错误。
System.OutOfMemoryException|	处理空闲内存不足生成的错误。
System.StackOverflowException|	处理栈溢出生成的错误。

```cs
using System;
namespace ErrorHandlingApplication
{
    class DivNumbers
    {
        int result;
        DivNumbers()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }

        }
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.division(25, 0);
            Console.ReadKey();
        }
    }
}
```

**创建用户自定义异常**

```cs
using System;
namespace UserDefinedException
{
   class TestTemperature
   {
      static void Main(string[] args)
      {
         Temperature temp = new Temperature();
         try
         {
            temp.showTemp();
         }
         catch(TempIsZeroException e)
         {
            Console.WriteLine("TempIsZeroException: {0}", e.Message);
         }
         Console.ReadKey();
      }
   }
}
public class TempIsZeroException: ApplicationException
{
   public TempIsZeroException(string message): base(message)
   {
   }
}
public class Temperature
{
   int temperature = 0;
   public void showTemp()
   {
      if(temperature == 0)
      {
         throw (new TempIsZeroException("Zero Temperature found"));
      }
      else
      {
         Console.WriteLine("Temperature: {0}", temperature);
      }
   }
}
```

**C# 文件的输入与输出**

一个 文件 是一个存储在磁盘中带有指定名称和目录路径的数据集合。当打开文件进行读写时，它变成一个 流。

从根本上说，流是通过通信路径传递的字节序列。有两个主要的流：输入流 和 输出流。输入流用于从文件读取数据（读操作），输出流用于向文件写入数据（写操作）。

**C# I/O类**

System.IO 命名空间有各种不同的类，用于执行各种文件操作，如创建和删除文件、读取或写入文件，关闭文件等。

下表列出了一些 System.IO 命名空间中常用的非抽象类：

I/O 类|	描述
-|-
BinaryReader|	从二进制流读取原始数据。
BinaryWriter|	以二进制格式写入原始数据。
BufferedStream|	字节流的临时存储。
Directory|	有助于操作目录结构。
DirectoryInfo|	用于对目录执行操作。
DriveInfo|	提供驱动器的信息。
File|	有助于处理文件。
FileInfo|	用于对文件执行操作。
FileStream|	用于文件中任何位置的读写。
MemoryStream|	用于随机访问存储在内存中的数据流。
Path|	对路径信息执行操作。
StreamReader|	用于从字节流中读取字符。
StreamWriter|	用于向一个流中写入字符。
StringReader|	用于读取字符串缓冲区。
StringWriter|	用于写入字符串缓冲区。

**FileStream 类**

System.IO 命名空间中的 FileStream 类有助于文件的读写与关闭。该类派生自抽象类 Stream。

需要创建一个 FileStream 对象来创建一个新的文件，或打开一个已有的文件。创建 FileStream 对象的语法如下：

```cs
using System;
using System.IO;

namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream F = new FileStream("test.dat",
            FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;

            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();
        }
    }
}
```

**C# 特性（Attribute）**

`特性（Attribute）`是用于在运行时传递程序中各种元素（比如类、方法、结构、枚举、组件等）的行为信息的声明性标签。可以通过使用特性向程序添加声明性信息。一个声明性标签是通过放置在它所应用的元素前面的方括号（[ ]）来描述的。

`特性（Attribute）`用于添加元数据，如编译器指令和注释、描述、方法、类等其他信息。.Net 框架提供了两种类型的特性：预定义特性和自定义特性。

**规定特性（Attribute）**

规定特性（Attribute）的语法如下：

特性（Attribute）的名称和值是在方括号内规定的，放置在它所应用的元素之前。positional_parameters 规定必需的信息，name_parameter 规定可选的信息。

**预定义特性（Attribute）**

预定义特性 AttributeUsage 描述了如何使用一个自定义特性类。它规定了特性可应用到的项目的类型。

规定该特性的语法如下：

```cs
[AttributeUsage(
   validon,
   AllowMultiple=allowmultiple,
   Inherited=inherited
)]
```

其中：

* 参数 validon 规定特性可被放置的语言元素。它是枚举器 AttributeTargets 的值的组合。默认值是 AttributeTargets.All。
* 参数 allowmultiple（可选的）为该特性的 AllowMultiple 属性（property）提供一个布尔值。如果为 true，则该特性是多用的。默认值是 false（单用的）。
* 参数 inherited（可选的）为该特性的 Inherited 属性（property）提供一个布尔值。如果为 true，则该特性可被派生类继承。默认值是 false（不被继承）。

**Conditional**

这个预定义特性标记了一个条件方法，其执行依赖于指定的预处理标识符。

它会引起方法调用的条件编译，取决于指定的值，比如 Debug 或 Trace。例如，当调试代码时显示变量的值。

规定该特性的语法如下：

```cs
#define DEBUG
using System;
using System.Diagnostics;
public class Myclass
{
    [Conditional("DEBUG")]
    public static void Message(string msg)
    {
        Console.WriteLine(msg);
    }
}
class Test
{
    static void function1()
    {
        Myclass.Message("In Function 1.");
        function2();
    }
    static void function2()
    {
        Myclass.Message("In Function 2.");
    }
    public static void Main()
    {
        Myclass.Message("In Main function.");
        function1();
        Console.ReadKey();
    }
}
```

**Obsolete**

这个预定义特性标记了不应被使用的程序实体。它可以让通知编译器丢弃某个特定的目标元素。例如，当一个新方法被用在一个类中，但是仍然想要保持类中的旧方法，可以通过显示一个应该使用新方法，而不是旧方法的消息，来把它标记为 obsolete（过时的）。

规定该特性的语法如下：

```cs
[Obsolete(
   message
)]
[Obsolete(
   message,
   iserror
)]
```

其中：

* 参数 message，是一个字符串，描述项目为什么过时以及该替代使用什么。
* 参数 iserror，是一个布尔值。如果该值为 true，编译器应把该项目的使用当作一个错误。默认值是 false（编译器生成一个警告）。

```cs
using System;
public class MyClass
{
   [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
   static void OldMethod()
   {
      Console.WriteLine("It is the old method");
   }
   static void NewMethod()
   {
      Console.WriteLine("It is the new method");
   }
   public static void Main()
   {
      OldMethod();
   }
}
```

**创建自定义特性（Attribute）**

.Net 框架允许创建自定义特性，用于存储声明性的信息，且可在运行时被检索。该信息根据设计标准和应用程序需要，可与任何目标元素相关。

创建并使用自定义特性包含四个步骤：

* 声明自定义特性
* 构建自定义特性
* 在目标程序元素上应用自定义特性
* 通过反射访问特性

最后一个步骤包含编写一个简单的程序来读取元数据以便查找各种符号。元数据是用于描述其他数据的数据和信息。该程序应使用反射来在运行时访问特性。将在下一章详细讨论这点。

**声明自定义特性**

```cs
// 一个自定义特性 BugFix 被赋给类及其成员
[AttributeUsage(AttributeTargets.Class |
AttributeTargets.Constructor |
AttributeTargets.Field |
AttributeTargets.Method |
AttributeTargets.Property,
AllowMultiple = true)]

public class DeBugInfo : System.Attribute
```

**构建自定义特性**

让构建一个名为 DeBugInfo 的自定义特性，该特性将存储调试程序获得的信息。它存储下面的信息：

* bug 的代码编号
* 辨认该 bug 的开发人员名字
* 最后一次审查该代码的日期
* 一个存储了开发人员标记的字符串消息

的 DeBugInfo 类将带有三个用于存储前三个信息的私有属性（property）和一个用于存储消息的公有属性（property）。所以 bug 编号、开发人员名字和审查日期将是 DeBugInfo 类的必需的定位（ positional）参数，消息将是一个可选的命名（named）参数。

每个特性必须至少有一个构造函数。必需的定位（ positional）参数应通过构造函数传递。下面的代码演示了 DeBugInfo 类：

```cs
// 一个自定义特性 BugFix 被赋给类及其成员
[AttributeUsage(AttributeTargets.Class |
AttributeTargets.Constructor |
AttributeTargets.Field |
AttributeTargets.Method |
AttributeTargets.Property,
AllowMultiple = true)]

public class DeBugInfo : System.Attribute
{
  private int bugNo;
  private string developer;
  private string lastReview;
  public string message;

  public DeBugInfo(int bg, string dev, string d)
  {
      this.bugNo = bg;
      this.developer = dev;
      this.lastReview = d;
  }

  public int BugNo
  {
      get
      {
          return bugNo;
      }
  }
  public string Developer
  {
      get
      {
          return developer;
      }
  }
  public string LastReview
  {
      get
      {
          return lastReview;
      }
  }
  public string Message
  {
      get
      {
          return message;
      }
      set
      {
          message = value;
      }
  }
}
```

**应用自定义特性**

```cs
[DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
[DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
class Rectangle
{
  // 成员变量
  protected double length;
  protected double width;
  public Rectangle(double l, double w)
  {
      length = l;
      width = w;
  }
  [DeBugInfo(55, "Zara Ali", "19/10/2012",
  Message = "Return type mismatch")]
  public double GetArea()
  {
      return length * width;
  }
  [DeBugInfo(56, "Zara Ali", "19/10/2012")]
  public void Display()
  {
      Console.WriteLine("Length: {0}", length);
      Console.WriteLine("Width: {0}", width);
      Console.WriteLine("Area: {0}", GetArea());
  }
}
```

利用 Conditional 属性，程序员可以定义条件方法。Conditional 属性通过测试条件编译符号来确定适用的条件。当运行到一个条件方法调用时，是否执行该调用，要根据出现该调用时是否已定义了此符号来确定。如果定义了此符号，则执行该调用；否则省略该调用（包括对调用的参数的计算）。使用Conditional是封闭#if和#endif内部方法的替代方法，它更整洁，更别致、减少了出错的机会。

**条件方法要受到以下限制**

* 条件方法必须是类声明或结构声明中的方法。如果在接口声明中的方法上指定Conditional属性，将出现编译时错误。
* 条件方法必须具有返回类型。
* 不能用override修饰符标记条件方法。但是，可以用virtual修饰符标记条件方法。此类方法的重写方法隐含为有条件的方法，而且不能用Conditional属性显式标记。
* 条件方法不能是接口方法的实现。否则将发生编译时错误。
* 如果条件方法用在“委托创建表达式”中，也会发生编译时错误

这里需要注意的是：如果创建一个没有定义任何条件的方法，那么默认只要调用就总是会执行此方法，如果想通过条件来判断执行，那么该方法上必须至少包含一个conditional特性所定义的条件，它才会响应定义的条件

**C# 反射（Reflection）**

反射指程序可以访问、检测和修改它本身状态或行为的一种能力。

程序集包含模块，而模块包含类型，类型又包含成员。反射则提供了封装程序集、模块和类型的对象。

可以使用反射动态地创建类型的实例，将类型绑定到现有对象，或从现有对象中获取类型。然后，可以调用类型的方法或访问其字段和属性。

**优缺点**

优点：

* 1、反射提高了程序的灵活性和扩展性。
* 2、降低耦合性，提高自适应能力。
* 3、它允许程序创建和控制任何类的对象，无需提前硬编码目标类。

缺点：

* 1、性能问题：使用反射基本上是一种解释操作，用于字段和方法接入时要远慢于直接代码。因此反射机制主要应用在对灵活性和拓展性要求很高的系统框架上，普通程序不建议使用。
* 2、使用反射会模糊程序内部逻辑；程序员希望在源代码中看到程序的逻辑，反射却绕过了源代码的技术，因而会带来维护的问题，反射代码比相应的直接代码更复杂。

**反射（Reflection）的用途**

反射（Reflection）有下列用途：

* 它允许在运行时查看特性（attribute）信息。
* 它允许审查集合中的各种类型，以及实例化这些类型。
* 它允许延迟绑定的方法和属性（property）。
* 它允许在运行时创建新类型，然后使用这些类型执行一些任务。

**查看元数据**

已经在上面的章节中提到过，使用反射（Reflection）可以查看特性（attribute）信息。

System.Reflection 类的 MemberInfo 对象需要被初始化，用于发现与类相关的特性（attribute）。为了做到这点，可以定义目标类的一个对象，如下：

```cs
using System;

[AttributeUsage(AttributeTargets.All)]
public class HelpAttribute : System.Attribute
{
   public readonly string Url;

   public string Topic  // Topic 是一个命名（named）参数
   {
      get
      {
         return topic;
      }
      set
      {

         topic = value;
      }
   }

   public HelpAttribute(string url)  // url 是一个定位（positional）参数
   {
      this.Url = url;
   }

   private string topic;
}
[HelpAttribute("Information on the class MyClass")]
class MyClass
{
}

namespace AttributeAppl
{
   class Program
   {
      static void Main(string[] args)
      {
         System.Reflection.MemberInfo info = typeof(MyClass);
         object[] attributes = info.GetCustomAttributes(true);
         for (int i = 0; i < attributes.Length; i++)
         {
            System.Console.WriteLine(attributes[i]);
         }
         Console.ReadKey();

      }
   }
}
```

```cs
using System;
using System.Reflection;
namespace BugFixApplication
{
   // 一个自定义特性 BugFix 被赋给类及其成员
   [AttributeUsage(AttributeTargets.Class |
   AttributeTargets.Constructor |
   AttributeTargets.Field |
   AttributeTargets.Method |
   AttributeTargets.Property,
   AllowMultiple = true)]

   public class DeBugInfo : System.Attribute
   {
      private int bugNo;
      private string developer;
      private string lastReview;
      public string message;

      public DeBugInfo(int bg, string dev, string d)
      {
         this.bugNo = bg;
         this.developer = dev;
         this.lastReview = d;
      }

      public int BugNo
      {
         get
         {
            return bugNo;
         }
      }
      public string Developer
      {
         get
         {
            return developer;
         }
      }
      public string LastReview
      {
         get
         {
            return lastReview;
         }
      }
      public string Message
      {
         get
         {
            return message;
         }
         set
         {
            message = value;
         }
      }
   }
   [DeBugInfo(45, "Zara Ali", "12/8/2012",
        Message = "Return type mismatch")]
   [DeBugInfo(49, "Nuha Ali", "10/10/2012",
        Message = "Unused variable")]
   class Rectangle
   {
      // 成员变量
      protected double length;
      protected double width;
      public Rectangle(double l, double w)
      {
         length = l;
         width = w;
      }
      [DeBugInfo(55, "Zara Ali", "19/10/2012",
           Message = "Return type mismatch")]
      public double GetArea()
      {
         return length * width;
      }
      [DeBugInfo(56, "Zara Ali", "19/10/2012")]
      public void Display()
      {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle  
   
   class ExecuteRectangle
   {
      static void Main(string[] args)
      {
         Rectangle r = new Rectangle(4.5, 7.5);
         r.Display();
         Type type = typeof(Rectangle);
         // 遍历 Rectangle 类的特性
         foreach (Object attributes in type.GetCustomAttributes(false))
         {
            DeBugInfo dbi = (DeBugInfo)attributes;
            if (null != dbi)
            {
               Console.WriteLine("Bug no: {0}", dbi.BugNo);
               Console.WriteLine("Developer: {0}", dbi.Developer);
               Console.WriteLine("Last Reviewed: {0}",
                                        dbi.LastReview);
               Console.WriteLine("Remarks: {0}", dbi.Message);
            }
         }
         
         // 遍历方法特性
         foreach (MethodInfo m in type.GetMethods())
         {
            foreach (Attribute a in m.GetCustomAttributes(true))
            {
               DeBugInfo dbi = (DeBugInfo)a;
               if (null != dbi)
               {
                  Console.WriteLine("Bug no: {0}, for Method: {1}",
                                                dbi.BugNo, m.Name);
                  Console.WriteLine("Developer: {0}", dbi.Developer);
                  Console.WriteLine("Last Reviewed: {0}",
                                                dbi.LastReview);
                  Console.WriteLine("Remarks: {0}", dbi.Message);
               }
            }
         }
         Console.ReadLine();
      }
   }
}
```

**C# 属性（Property）**

属性（Property） 是类（class）、结构（structure）和接口（interface）的命名（named）成员。类或结构中的成员变量或方法称为 域（Field）。属性（Property）是域（Field）的扩展，且可使用相同的语法来访问。它们使用 访问器（accessors） 让私有域的值可被读写或操作。

属性（Property）不会确定存储位置。相反，它们具有可读写或计算它们值的 访问器（accessors）。

例如，有一个名为 Student 的类，带有 age、name 和 code 的私有域。不能在类的范围以外直接访问这些域，但是可以拥有访问这些私有域的属性。

**访问器（Accessors）**

属性（Property）的访问器（accessor）包含有助于获取（读取或计算）或设置（写入）属性的可执行语句。访问器（accessor）声明可包含一个 get 访问器、一个 set 访问器，或者同时包含二者。例如：

```cs
// 声明类型为 string 的 Code 属性
public string Code
{
   get
   {
      return code;
   }
   set
   {
      code = value;
   }
}

// 声明类型为 string 的 Name 属性
public string Name
{
   get
   {
     return name;
   }
   set
   {
     name = value;
   }
}

// 声明类型为 int 的 Age 属性
public int Age
{
   get
   {
      return age;
   }
   set
   {
      age = value;
   }
}
```

```cs
using System;
namespace runoob
{
   class Student
   {

      private string code = "N.A";
      private string name = "not known";
      private int age = 0;

      // 声明类型为 string 的 Code 属性
      public string Code
      {
         get
         {
            return code;
         }
         set
         {
            code = value;
         }
      }
   
      // 声明类型为 string 的 Name 属性
      public string Name
      {
         get
         {
            return name;
         }
         set
         {
            name = value;
         }
      }

      // 声明类型为 int 的 Age 属性
      public int Age
      {
         get
         {
            return age;
         }
         set
         {
            age = value;
         }
      }
      public override string ToString()
      {
         return "Code = " + Code +", Name = " + Name + ", Age = " + Age;
      }
    }
    class ExampleDemo
    {
      public static void Main()
      {
         // 创建一个新的 Student 对象
         Student s = new Student();
           
         // 设置 student 的 code、name 和 age
         s.Code = "001";
         s.Name = "Zara";
         s.Age = 9;
         Console.WriteLine("Student Info: {0}", s);
         // 增加年龄
         s.Age += 1;
         Console.WriteLine("Student Info: {0}", s);
         Console.ReadKey();
       }
   }
}
```

**抽象属性（Abstract Properties）**

```cs
using System;
namespace runoob
{
   public abstract class Person
   {
      public abstract string Name
      {
         get;
         set;
      }
      public abstract int Age
      {
         get;
         set;
      }
   }
   class Student : Person
   {

      private string code = "N.A";
      private string name = "N.A";
      private int age = 0;

      // 声明类型为 string 的 Code 属性
      public string Code
      {
         get
         {
            return code;
         }
         set
         {
            code = value;
         }
      }
   
      // 声明类型为 string 的 Name 属性
      public override string Name
      {
         get
         {
            return name;
         }
         set
         {
            name = value;
         }
      }

      // 声明类型为 int 的 Age 属性
      public override int Age
      {
         get
         {
            return age;
         }
         set
         {
            age = value;
         }
      }
      public override string ToString()
      {
         return "Code = " + Code +", Name = " + Name + ", Age = " + Age;
      }
   }
   class ExampleDemo
   {
      public static void Main()
      {
         // 创建一个新的 Student 对象
         Student s = new Student();
           
         // 设置 student 的 code、name 和 age
         s.Code = "001";
         s.Name = "Zara";
         s.Age = 9;
         Console.WriteLine("Student Info:- {0}", s);
         // 增加年龄
         s.Age += 1;
         Console.WriteLine("Student Info:- {0}", s);
         Console.ReadKey();
       }
   }
}
```

```cs
using System;
namespace Demo.cs
{
    class Program
    {
        public abstract class Person
        {
            public abstract string Name { get; set; }
            public abstract int Age { get; set; }
        }
        public class Student : Person
        {
            public string Code { get; set; } = "N.A";
            public override string Name { get; set; } = "N.A";
            public override int Age { get; set; } = 0;
            public override string ToString()
            {
                return $"Code:{Code},Name:{Name},Age:{Age}";
            }
        }

        static void Main(string[] args)
        {
            var s = new Student()
            {
                Code = "001",
                Name = "Zara",
                Age = 10
            };
            System.Console.WriteLine($"Student Info:={s}");

            s.Age++;
            System.Console.WriteLine($"Student Info:={s}");
        }
    }
}
```

**C# 索引器（Indexer）**

索引器（Indexer） 允许一个对象可以像数组一样被索引。当为类定义一个索引器时，该类的行为就会像一个 虚拟数组（virtual array） 一样。可以使用数组访问运算符（[ ]）来访问该类的实例。

**索引器（Indexer）的用途**

索引器的行为的声明在某种程度上类似于属性（property）。就像属性（property），可使用 get 和 set 访问器来定义索引器。但是，属性返回或设置一个特定的数据成员，而索引器返回或设置对象实例的一个特定值。换句话说，它把实例数据分为更小的部分，并索引每个部分，获取或设置每个部分。

定义一个属性（property）包括提供属性名称。索引器定义的时候不带有名称，但带有 this 关键字，它指向对象实例。下面的实例演示了这个概念：

```cs
using System;
namespace IndexerApplication
{
   class IndexedNames
   {
      private string[] namelist = new string[size];
      static public int size = 10;
      public IndexedNames()
      {
         for (int i = 0; i < size; i++)
         namelist[i] = "N. A.";
      }
      public string this[int index]
      {
         get
         {
            string tmp;

            if( index >= 0 && index <= size-1 )
            {
               tmp = namelist[index];
            }
            else
            {
               tmp = "";
            }

            return ( tmp );
         }
         set
         {
            if( index >= 0 && index <= size-1 )
            {
               namelist[index] = value;
            }
         }
      }

      static void Main(string[] args)
      {
         IndexedNames names = new IndexedNames();
         names[0] = "Zara";
         names[1] = "Riz";
         names[2] = "Nuha";
         names[3] = "Asif";
         names[4] = "Davinder";
         names[5] = "Sunil";
         names[6] = "Rubic";
         for ( int i = 0; i < IndexedNames.size; i++ )
         {
            Console.WriteLine(names[i]);
         }
         Console.ReadKey();
      }
   }
}
```

**重载索引器（Indexer）**

索引器（Indexer）可被重载。索引器声明的时候也可带有多个参数，且每个参数可以是不同的类型。没有必要让索引器必须是整型的。C# 允许索引器可以是其他类型，例如，字符串类型。

下面的实例演示了重载索引器：

```cs
using System;
namespace IndexerApplication
{
   class IndexedNames
   {
      private string[] namelist = new string[size];
      static public int size = 10;
      public IndexedNames()
      {
         for (int i = 0; i < size; i++)
         {
          namelist[i] = "N. A.";
         }
      }
      public string this[int index]
      {
         get
         {
            string tmp;

            if( index >= 0 && index <= size-1 )
            {
               tmp = namelist[index];
            }
            else
            {
               tmp = "";
            }

            return ( tmp );
         }
         set
         {
            if( index >= 0 && index <= size-1 )
            {
               namelist[index] = value;
            }
         }
      }
      public int this[string name]
      {
         get
         {
            int index = 0;
            while(index < size)
            {
               if (namelist[index] == name)
               {
                return index;
               }
               index++;
            }
            return index;
         }

      }

      static void Main(string[] args)
      {
         IndexedNames names = new IndexedNames();
         names[0] = "Zara";
         names[1] = "Riz";
         names[2] = "Nuha";
         names[3] = "Asif";
         names[4] = "Davinder";
         names[5] = "Sunil";
         names[6] = "Rubic";
         // 使用带有 int 参数的第一个索引器
         for (int i = 0; i < IndexedNames.size; i++)
         {
            Console.WriteLine(names[i]);
         }
         // 使用带有 string 参数的第二个索引器
         Console.WriteLine(names["Nuha"]);
         Console.ReadKey();
      }
   }
}
```

```cs
public class IndexedNames
{
  private string[] nameList;
  public int size;
  public IndexedNames(int size)
  {
    this.size = size;
    nameList = new string[size];
    for(int i = 0;i < size; i++)
    {
      nameList[i]="N. A.";
    }
  }
  public string this[int index]
  {
    get
    {
      string temp;
      if(index>=0 && index<size)
      {
        temp = nameList[index];
      }
      else
      {
        temp = "";
      }
      return temp;
    }
    set
    {
      if(index>=0 && index<size)
      {
        nameList[index] = value;
      }
    }
  }
}
static void Main(string[] args)
{
   IndexedNames index = new IndexedNames(5);
   index[0] = "Zara";
   index[1] = "Riz";
   index[2] = "Nuha";
   index[3] = "Asif";
   index[4] = "Davinder";
   for (int i = 0; i < index.size; i++)
   {
      Console.WriteLine(index[i]);
   }
   Console.ReadKey();
}
```

**C# 委托（Delegate）**

C# 中的委托（Delegate）类似于 C 或 C++ 中函数的指针。委托（Delegate） 是存有对某个方法的引用的一种引用类型变量。引用可在运行时被改变。

委托（Delegate）特别用于实现事件和回调方法。所有的委托（Delegate）都派生自 System.Delegate 类。

**声明委托（Delegate）**

委托声明决定了可由该委托引用的方法。委托可指向一个与其具有相同标签的方法。

**实例化委托（Delegate）**

一旦声明了委托类型，委托对象必须使用 new 关键字来创建，且与一个特定的方法有关。当创建委托时，传递到 new 语句的参数就像方法调用一样书写，但是不带有参数。例如：

```cs
public delegate void printString(string s);
...
printString ps1 = new printString(WriteToScreen);
printString ps2 = new printString(WriteToFile);
```

```cs
using System;

delegate int NumberChanger(int n);
namespace DelegateAppl
{
   class TestDelegate
   {
      static int num = 10;
      public static int AddNum(int p)
      {
         num += p;
         return num;
      }

      public static int MultNum(int q)
      {
         num *= q;
         return num;
      }
      public static int getNum()
      {
         return num;
      }

      static void Main(string[] args)
      {
         // 创建委托实例
         NumberChanger nc1 = new NumberChanger(AddNum);
         NumberChanger nc2 = new NumberChanger(MultNum);
         // 使用委托对象调用方法
         nc1(25);
         Console.WriteLine("Value of Num: {0}", getNum());
         nc2(5);
         Console.WriteLine("Value of Num: {0}", getNum());
         Console.ReadKey();
      }
   }
}
```

**委托的多播（Multicasting of a Delegate）**

委托对象可使用 "+" 运算符进行合并。一个合并委托调用它所合并的两个委托。只有相同类型的委托可被合并。"-" 运算符可用于从合并的委托中移除组件委托。

使用委托的这个有用的特点，可以创建一个委托被调用时要调用的方法的调用列表。这被称为委托的 多播（multicasting），也叫组播。下面的程序演示了委托的多播：

```cs
using System;

delegate int NumberChanger(int n);
namespace DelegateAppl
{
   class TestDelegate
   {
      static int num = 10;
      public static int AddNum(int p)
      {
         num += p;
         return num;
      }

      public static int MultNum(int q)
      {
         num *= q;
         return num;
      }
      public static int getNum()
      {
         return num;
      }

      static void Main(string[] args)
      {
         // 创建委托实例
         NumberChanger nc;
         NumberChanger nc1 = new NumberChanger(AddNum);
         NumberChanger nc2 = new NumberChanger(MultNum);
         nc = nc1;
         nc += nc2;
         // 调用多播
         nc(5);
         Console.WriteLine("Value of Num: {0}", getNum());
         Console.ReadKey();
      }
   }
}
```

**委托（Delegate）的用途**

下面的实例演示了委托的用法。委托 printString 可用于引用带有一个字符串作为输入的方法，并不返回任何东西。

```cs
using System;
using System.IO;

namespace DelegateAppl
{
   class PrintString
   {
      static FileStream fs;
      static StreamWriter sw;
      // 委托声明
      public delegate void printString(string s);

      // 该方法打印到控制台
      public static void WriteToScreen(string str)
      {
         Console.WriteLine("The String is: {0}", str);
      }
      // 该方法打印到文件
      public static void WriteToFile(string s)
      {
         fs = new FileStream("c:\\message.txt", FileMode.Append, FileAccess.Write);
         sw = new StreamWriter(fs);
         sw.WriteLine(s);
         sw.Flush();
         sw.Close();
         fs.Close();
      }
      // 该方法把委托作为参数，并使用它调用方法
      public static void sendString(printString ps)
      {
         ps("Hello World");
      }
      static void Main(string[] args)
      {
         printString ps1 = new printString(WriteToScreen);
         printString ps2 = new printString(WriteToFile);
         sendString(ps1);
         sendString(ps2);
         Console.ReadKey();
      }
   }
}
```

**C# 事件（Event）**

`事件(Event)` 基本上说是一个用户操作，如按键、点击、鼠标移动等等，或者是一些提示信息，如系统生成的通知。应用程序需要在事件发生时响应事件。例如，中断。

C# 中使用事件机制实现线程间的通信。

**通过事件使用委托**

事件在类中声明且生成，且通过使用同一个类或其他类中的委托与事件处理程序关联。包含事件的类用于发布事件。这被称为 `发布器（publisher） 类`。其他接受该事件的类被称为 `订阅器（subscriber） 类`。事件使用 发布-订阅（publisher-subscriber） 模型。

`发布器（publisher）` 是一个包含事件和委托定义的对象。事件和委托之间的联系也定义在这个对象中。发布器（publisher）类的对象调用这个事件，并通知其他的对象。

`订阅器（subscriber）` 是一个接受事件并提供事件处理程序的对象。在发布器（publisher）类中的委托调用订阅器（subscriber）类中的方法（事件处理程序）。

**声明事件（Event）**

```cs
using System;
namespace SimpleEvent
{
  using System;
  /***********发布器类***********/
  public class EventTest
  {
    private int value;

    public delegate void NumManipulationHandler();


    public event NumManipulationHandler ChangeNum;
    protected virtual void OnNumChanged()
    {
      if ( ChangeNum != null )
      {
        ChangeNum(); /* 事件被触发 */
      }else {
        Console.WriteLine( "event not fire" );
        Console.ReadKey(); /* 回车继续 */
      }
    }


    public EventTest()
    {
      int n = 5;
      SetValue( n );
    }


    public void SetValue( int n )
    {
      if ( value != n )
      {
        value = n;
        OnNumChanged();
      }
    }
  }


  /***********订阅器类***********/

  public class subscribEvent
  {
    public void printf()
    {
      Console.WriteLine( "event fire" );
      Console.ReadKey(); /* 回车继续 */
    }
  }

  /***********触发***********/
  public class MainClass
  {
    public static void Main()
    {
      EventTest e = new EventTest(); /* 实例化对象,第一次没有触发事件 */
      subscribEvent v = new subscribEvent(); /* 实例化对象 */
      e.ChangeNum += new EventTest.NumManipulationHandler( v.printf ); /* 注册 */
      e.SetValue( 7 );
      e.SetValue( 11 );
    }
  }
}
```

```cs
using System;
using System.IO;

namespace BoilerEventAppl
{

   // boiler 类
   class Boiler
   {
      private int temp;
      private int pressure;
      public Boiler(int t, int p)
      {
         temp = t;
         pressure = p;
      }

      public int getTemp()
      {
         return temp;
      }
      public int getPressure()
      {
         return pressure;
      }
   }
   // 事件发布器
   class DelegateBoilerEvent
   {
      public delegate void BoilerLogHandler(string status);

      // 基于上面的委托定义事件
      public event BoilerLogHandler BoilerEventLog;

      public void LogProcess()
      {
         string remarks = "O. K";
         Boiler b = new Boiler(100, 12);
         int t = b.getTemp();
         int p = b.getPressure();
         if(t > 150 || t < 80 || p < 12 || p > 15)
         {
            remarks = "Need Maintenance";
         }
         OnBoilerEventLog("Logging Info:\n");
         OnBoilerEventLog("Temparature " + t + "\nPressure: " + p);
         OnBoilerEventLog("\nMessage: " + remarks);
      }

      protected void OnBoilerEventLog(string message)
      {
         if (BoilerEventLog != null)
         {
            BoilerEventLog(message);
         }
      }
   }
   // 该类保留写入日志文件的条款
   class BoilerInfoLogger
   {
      FileStream fs;
      StreamWriter sw;
      public BoilerInfoLogger(string filename)
      {
         fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
         sw = new StreamWriter(fs);
      }
      public void Logger(string info)
      {
         sw.WriteLine(info);
      }
      public void Close()
      {
         sw.Close();
         fs.Close();
      }
   }
   // 事件订阅器
   public class RecordBoilerInfo
   {
      static void Logger(string info)
      {
         Console.WriteLine(info);
      }//end of Logger

      static void Main(string[] args)
      {
         BoilerInfoLogger filelog = new BoilerInfoLogger("e:\\boiler.txt");
         DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();
         boilerEvent.BoilerEventLog += new
         DelegateBoilerEvent.BoilerLogHandler(Logger);
         boilerEvent.BoilerEventLog += new
         DelegateBoilerEvent.BoilerLogHandler(filelog.Logger);
         boilerEvent.LogProcess();
         Console.ReadLine();
         filelog.Close();
      }//end of main

   }//end of RecordBoilerInfo
}
```

**C# 集合（Collection）**

集合（Collection）类是专门用于数据存储和检索的类。这些类提供了对栈（stack）、队列（queue）、列表（list）和哈希表（hash table）的支持。大多数集合类实现了相同的接口。

集合（Collection）类服务于不同的目的，如为元素动态分配内存，基于索引访问列表项等等。这些类创建 Object 类的对象的集合。在 C# 中，Object 类是所有数据类型的基类。

类|	描述和用法
-|-
动态数组（ArrayList）|	它代表了可被单独索引的对象的有序集合。它基本上可以替代一个数组。但是，与数组不同的是，可以使用索引在指定的位置添加和移除项目，动态数组会自动重新调整它的大小。它也允许在列表中进行动态内存分配、增加、搜索、排序各项。
哈希表（Hashtable）|	它使用键来访问集合中的元素。当使用键访问元素时，则使用哈希表，而且可以识别一个有用的键值。哈希表中的每一项都有一个键/值对。键用于访问集合中的项目。
排序列表（SortedList）|	它可以使用键和索引来访问列表中的项。排序列表是数组和哈希表的组合。它包含一个可使用键或索引访问各项的列表。如果使用索引访问各项，则它是一个动态数组（ArrayList），如果使用键访问各项，则它是一个哈希表（Hashtable）。集合中的各项总是按键值排序。
堆栈（Stack）|	它代表了一个后进先出的对象集合。当需要对各项进行后进先出的访问时，则使用堆栈。当在列表中添加一项，称为推入元素，当从列表中移除一项时，称为弹出元素。
队列（Queue）|	它代表了一个先进先出的对象集合。当需要对各项进行先进先出的访问时，则使用队列。当在列表中添加一项，称为入队，当从列表中移除一项时，称为出队。
点阵列（BitArray）|	它代表了一个使用值 1 和 0 来表示的二进制数组。当需要存储位，但是事先不知道位数时，则使用点阵列。可以使用整型索引从点阵列集合中访问各项，索引从零开始。

**C# 泛型（Generic）**

**泛型（Generic）** 允许延迟编写类或方法中的编程元素的数据类型的规范，直到实际在程序中使用它的时候。换句话说，泛型允许编写一个可以与任何数据类型一起工作的类或方法。

可以通过数据类型的替代参数编写类或方法的规范。当编译器遇到类的构造函数或方法的函数调用时，它会生成代码来处理指定的数据类型。下面这个简单的实例将有助于理解这个概念：

```cs
using System;
using System.Collections.Generic;

namespace GenericApplication
{
    public class MyGenericArray<T>
    {
        private T[] array;
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }
           
    class Tester
    {
        static void Main(string[] args)
        {
            // 声明一个整型数组
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            // 设置值
            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c*5);
            }
            // 获取值
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.getItem(c) + " ");
            }
            Console.WriteLine();
            // 声明一个字符数组
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);
            // 设置值
            for (int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c+97));
            }
            // 获取值
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getItem(c) + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
```

**泛型（Generic）的特性**

使用泛型是一种增强程序功能的技术，具体表现在以下几个方面：

* 它有助于最大限度地重用代码、保护类型的安全以及提高性能。
* 可以创建泛型集合类。.NET 框架类库在 System.Collections.Generic 命名空间中包含了一些新的泛型集合类。可以使用这些泛型集合类来替代 System.Collections 中的集合类。
* 可以创建自己的泛型接口、泛型类、泛型方法、泛型事件和泛型委托。
* 可以对泛型类进行约束以访问特定数据类型的方法。
* 关于泛型数据类型中使用的类型的信息可在运行时通过使用反射获取。

**泛型（Generic）方法**

```cs
using System;
using System.Collections.Generic;

namespace GenericMethodAppl
{
    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        static void Main(string[] args)
        {
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            // 在交换之前显示值
            Console.WriteLine("Int values before calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values before calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            // 调用 swap
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);

            // 在交换之后显示值
            Console.WriteLine("Int values after calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);
            Console.ReadKey();
        }
    }
}
```

**泛型（Generic）委托**

通过类型参数定义泛型委托。例如：

```cs
delegate T NumberChanger<T>(T n);
```

```cs
using System;
using System.Collections.Generic;

delegate T NumberChanger<T>(T n);
namespace GenericDelegateAppl
{
    class TestDelegate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            // 创建委托实例
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);
            // 使用委托对象调用方法
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
```

在声明泛型方法/泛型类的时候，可以给泛型加上一定的约束来满足我们特定的一些条件。

```cs
using System;
using System.Web.Caching;

namespace Demo.CacheManager
{
   public class CacheHelper<T> where T:new()
   {
      
   }
}
```

泛型限定条件：

* T：结构（类型参数必须是值类型。可以指定除 Nullable 以外的任何值类型）
* T：类 （类型参数必须是引用类型，包括任何类、接口、委托或数组类型）
* T：new() （类型参数必须具有无参数的公共构造函数。当与其他约束一起使用时new() 约束必须最后指定）
* T：<基类名> 类型参数必须是指定的基类或派生自指定的基类
* T：<接口名称> 类型参数必须是指定的接口或实现指定的接口。可以指定多个接口约束。约束接口也可以是泛型的。
* T：U

```cs
using System;
using System.Web.Caching;

namespace Xy.CacheManager
{
  public class CacheHelper<T>
  {
      //获取缓存实体
      public static T Get(Cache cache,string cacheKey)
      {
        //....缓存操作
      } 
      //插入缓存
      public static void Set(Cache cache T tEntity,string cacheKey)
      {
        //....缓存操作
      }
  }
}
```

**C# 匿名方法**

我们已经提到过，委托是用于引用与其具有相同标签的方法。换句话说，您可以使用委托对象调用可由委托引用的方法。

匿名方法（Anonymous methods） 提供了一种传递代码块作为委托参数的技术。匿名方法是没有名称只有主体的方法。

在匿名方法中您不需要指定返回类型，它是从方法主体内的 return 语句推断的。

*编写匿名方法的语法*-匿名方法是通过使用 delegate 关键字创建委托实例来声明的。例如：

```cs
delegate void NumberChanger(int n);

NumberChanger nc = delegate(int x)
{
    Console.WriteLine("Anonymous Method: {0}", x);
};

```

```cs
using System;

delegate void NumberChanger(int n);
namespace DelegateAppl
{
    class TestDelegate
    {
        static int num = 10;
        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method: {0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method: {0}", num);
        }

        static void Main(string[] args)
        {
            // 使用匿名方法创建委托实例
            NumberChanger nc = delegate(int x)
            {
               Console.WriteLine("Anonymous Method: {0}", x);
            };
           
            // 使用匿名方法调用委托
            nc(10);

            // 使用命名方法实例化委托
            nc =  new NumberChanger(AddNum);
           
            // 使用命名方法调用委托
            nc(5);

            // 使用另一个命名方法实例化委托
            nc =  new NumberChanger(MultNum);
           
            // 使用命名方法调用委托
            nc(2);
            Console.ReadKey();
        }
    }
}
```

**C# 不安全代码**

当一个代码块使用 unsafe 修饰符标记时，C# 允许在函数中使用指针变量。不安全代码或非托管代码是指使用了指针变量的代码块。

**指针变量**

**指针** 是值为另一个变量的地址的变量，即，内存位置的直接地址。就像其他变量或常量，您必须在使用指针存储其他变量地址之前声明指针。

指针变量声明的一般形式为：

```cs
type* var-name;
```

实例|	描述
-|-
int* p|	p 是指向整数的指针。
double* p|	p 是指向双精度数的指针。
float* p|	p 是指向浮点数的指针。
int** p|	p 是指向整数的指针的指针。
int*[] p|	p 是指向整数的指针的一维数组。
char* p|	p 是指向字符的指针。
void* p|	p 是指向未知类型的指针。

```cs
using System;
namespace UnsafeCodeApplication
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int var = 20;
            int* p = &var;
            Console.WriteLine("Data is: {0} ",  var);
            Console.WriteLine("Address is: {0}",  (int)p);
            Console.ReadKey();
        }
    }
}
```

**使用指针检索数据值**

```cs
using System;
namespace UnsafeCodeApplication
{
   class Program
   {
      public static void Main()
      {
         unsafe
         {
            int var = 20;
            int* p = &var;
            Console.WriteLine("Data is: {0} " , var);
            Console.WriteLine("Data is: {0} " , p->ToString());
            Console.WriteLine("Address is: {0} " , (int)p);
         }
         Console.ReadKey();
      }
   }
}
```

**传递指针作为方法的参数**

```cs
using System;
namespace UnsafeCodeApplication
{
   class TestPointer
   {
      public unsafe void swap(int* p, int *q)
      {
         int temp = *p;
         *p = *q;
         *q = temp;
      }

      public unsafe static void Main()
      {
         TestPointer p = new TestPointer();
         int var1 = 10;
         int var2 = 20;
         int* x = &var1;
         int* y = &var2;
         
         Console.WriteLine("Before Swap: var1:{0}, var2: {1}", var1, var2);
         p.swap(x, y);

         Console.WriteLine("After Swap: var1:{0}, var2: {1}", var1, var2);
         Console.ReadKey();
      }
   }
}
```

**使用指针访问数组元素**

在 C# 中，数组名称和一个指向与数组数据具有相同数据类型的指针是不同的变量类型。例如，int *p 和 int[] p 是不同的类型。可以增加指针变量 p，因为它在内存中不是固定的，但是数组地址在内存中是固定的，所以您不能增加数组 p。

因此，如果您需要使用指针变量访问数组数据，可以像我们通常在 C 或 C++ 中所做的那样，使用 fixed 关键字来固定指针。

下面的实例演示了这点：

```cs
using System;
namespace UnsafeCodeApplication
{
   class TestPointer
   {
      public unsafe static void Main()
      {
         int[]  list = {10, 100, 200};
         fixed(int *ptr = list)

         /* 显示指针中数组地址 */
         for ( int i = 0; i < 3; i++)
         {
            Console.WriteLine("Address of list[{0}]={1}",i,(int)(ptr + i));
            Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
         }
         Console.ReadKey();
      }
   }
}
```

**编译不安全代码**

为了编译不安全代码，您必须切换到命令行编译器指定 /unsafe 命令行。

例如，为了编译包含不安全代码的名为 prog1.cs 的程序，需在命令行中输入命令：

```cs
csc /unsafe prog1.cs
```

**stackalloc**

在unsafe不安全环境中，我们可以通过stackalloc在堆栈上分配内存，因为在堆栈上分配的内存不受内存管理器管理，因此其相应的指针不需要固定。

**C# 多线程**

线程 被定义为程序的执行路径。每个线程都定义了一个独特的控制流。如果您的应用程序涉及到复杂的和耗时的操作，那么设置不同的线程执行路径往往是有益的，每个线程执行特定的工作。

线程是轻量级进程。一个使用线程的常见实例是现代操作系统中并行编程的实现。使用线程节省了 CPU 周期的浪费，同时提高了应用程序的效率。

到目前为止我们编写的程序是一个单线程作为应用程序的运行实例的单一的过程运行的。但是，这样子应用程序同时只能执行一个任务。为了同时执行多个任务，它可以被划分为更小的线程。

**线程生命周期**

线程生命周期开始于 System.Threading.Thread 类的对象被创建时，结束于线程被终止或完成执行时。

下面列出了线程生命周期中的各种状态：

* 未启动状态：当线程实例被创建但 Start 方法未被调用时的状况。
* 就绪状态：当线程准备好运行并等待 CPU 周期时的状况。
* 不可运行状态：下面的几种情况下线程是不可运行的：
1. 已经调用 Sleep 方法
2. 已经调用 Wait 方法
3. 通过 I/O 操作阻塞
* 死亡状态：当线程已完成执行或已中止时的状况。

**主线程**

在 C# 中，System.Threading.Thread 类用于线程的工作。它允许创建并访问多线程应用程序中的单个线程。进程中第一个被执行的线程称为主线程。

当 C# 程序开始执行时，主线程自动创建。使用 Thread 类创建的线程被主线程的子线程调用。您可以使用 Thread 类的 CurrentThread 属性访问线程。

下面的程序演示了主线程的执行：

```cs
using System;
using System.Threading;

namespace MultithreadingApplication
{
    class MainThreadProgram
    {
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
            Console.WriteLine("This is {0}", th.Name);
            Console.ReadKey();
        }
    }
}
```

**Thread 类常用的属性和方法**

属性|	描述
-|-
CurrentContext|	获取线程正在其中执行的当前上下文。
CurrentCulture|	获取或设置当前线程的区域性。
CurrentPrincipal|	获取或设置线程的当前负责人（对基于角色的安全性而言）。
CurrentThread|	获取当前正在运行的线程。
CurrentUICulture|	获取或设置资源管理器使用的当前区域性以便在运行时查找区域性特定的资源。
ExecutionContext|	获取一个 ExecutionContext 对象，该对象包含有关当前线程的各种上下文的信息。
IsAlive|	获取一个值，该值指示当前线程的执行状态。
IsBackground|	获取或设置一个值，该值指示某个线程是否为后台线程。
IsThreadPoolThread|	获取一个值，该值指示线程是否属于托管线程池。
ManagedThreadId|	获取当前托管线程的唯一标识符。
Name|	获取或设置线程的名称。
Priority|	获取或设置一个值，该值指示线程的调度优先级。
ThreadState|	获取一个值，该值包含当前线程的状态。

下表列出了 Thread 类的一些常用的 方法：

序号|	方法名 & 描述
-|-
1|	public void Abort() 在调用此方法的线程上引发 ThreadAbortException，以开始终止此线程的过程。调用此方法通常会终止线程。
2|	public static LocalDataStoreSlot AllocateDataSlot() 在所有的线程上分配未命名的数据槽。为了获得更好的性能，请改用以 ThreadStaticAttribute 属性标记的字段。
3|	public static LocalDataStoreSlot AllocateNamedDataSlot( string name) 在所有线程上分配已命名的数据槽。为了获得更好的性能，请改用以 ThreadStaticAttribute 属性标记的字段。
4|	public static void BeginCriticalRegion() 通知主机执行将要进入一个代码区域，在该代码区域内线程中止或未经处理的异常的影响可能会危害应用程序域中的其他任务。
5|	public static void BeginThreadAffinity() 通知主机托管代码将要执行依赖于当前物理操作系统线程的标识的指令。
6|	public static void EndCriticalRegion() 通知主机执行将要进入一个代码区域，在该代码区域内线程中止或未经处理的异常仅影响当前任务。
7|	public static void EndThreadAffinity() 通知主机托管代码已执行完依赖于当前物理操作系统线程的标识的指令。
8|	public static void FreeNamedDataSlot(string name) 为进程中的所有线程消除名称与槽之间的关联。为了获得更好的性能，请改用以 ThreadStaticAttribute 属性标记的字段。
9|	public static Object GetData( LocalDataStoreSlot slot ) 在当前线程的当前域中从当前线程上指定的槽中检索值。为了获得更好的性能，请改用以 ThreadStaticAttribute 属性标记的字段。
10|	public static AppDomain GetDomain() 返回当前线程正在其中运行的当前域。
11|	public static AppDomain GetDomainID() 返回唯一的应用程序域标识符。
12|	public static LocalDataStoreSlot GetNamedDataSlot( string name ) 查找已命名的数据槽。为了获得更好的性能，请改用以 ThreadStaticAttribute 属性标记的字段。
13|	public void Interrupt() 中断处于 WaitSleepJoin 线程状态的线程。
14|	public void Join() 在继续执行标准的 COM 和 SendMessage 消息泵处理期间，阻塞调用线程，直到某个线程终止为止。此方法有不同的重载形式。
15|	public static void MemoryBarrier() 按如下方式同步内存存取：执行当前线程的处理器在对指令重新排序时，不能采用先执行 MemoryBarrier 调用之后的内存存取，再执行 MemoryBarrier 调用之前的内存存取的方式。
16|	public static void ResetAbort() 取消为当前线程请求的 Abort。
17|	public static void SetData( LocalDataStoreSlot slot, Object data ) 在当前正在运行的线程上为此线程的当前域在指定槽中设置数据。为了获得更好的性能，请改用以 ThreadStaticAttribute 属性标记的字段。
18|	public void Start() 开始一个线程。
19|	public static void Sleep( int millisecondsTimeout ) 让线程暂停一段时间。
20|	public static void SpinWait( int iterations ) 导致线程等待由 iterations 参数定义的时间量。
21|	public static byte VolatileRead( ref byte address ) public static double VolatileRead( ref double address ) public static int VolatileRead( ref int address ) public static Object VolatileRead( ref Object address ) 读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。此方法有不同的重载形式。这里只给出了一些形式。
22|	public static void VolatileWrite( ref byte address, byte value ) public static void VolatileWrite( ref double address, double value ) public static void VolatileWrite( ref int address, int value ) public static void VolatileWrite( ref Object address, Object value ) 立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。此方法有不同的重载形式。这里只给出了一些形式。
23|	public static bool Yield() 导致调用线程执行准备好在当前处理器上运行的另一个线程。由操作系统选择要执行的线程。


