# The 8th On-Hand Practice

标签（空格分隔）： 上机作业
---
> 新建一个15.md，所有答案写在上面，截止日期2017年7月23日24:00
## 选择题：（多选）
1. 观察如下这段代码：选择所有的正确项
```C#
namespace MoreAboutClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Box myBox = new Box();
            Box myOtherBox;
            myBox.Length = 10;
            myOtherBox = myBox;
            myOtherBox.Length = 12;
            Console.WriteLine(myBox.Length);//句1
            Console.WriteLine(myOtherBox.Length);//句2
            Console.WriteLine(myBox);//句3
            Console.ReadLine();
        }
    }
    class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
```

A 执行后程序报错，因为句3中的myBox不含有任何属性；
B 程序没错，可以正常执行
C 执行后，句1和句2分别输出10和12，因为myOtherBox相对于myBox来说复制出了一个新的空间，对myOtherBox中的更改不会影响myBox
D 执行后，句1和句2都会输出12，因为myOtherBox只是复制了myBox中的地址，对于myOtherBox中内容的更改，也就是对有同样地址myBox中内容的更改

----

2. 观察如下这段代码：选择所有的正确项
```C#
namespace MoreAboutClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Box myBox = new Box();
            Box myOtherBox;
            myOtherBox = myBox;
            Console.WriteLine(myBox.Length);//句1
            Console.WriteLine(myOtherBox.Length);//句2
            myBox = null;
            Console.ReadLine();
        }
    }
    class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
```
A 编译器会报错，因为myBox.Length没有任何值，句1、句2无法输出
B 程序可以正常运行，但是介于myBox.Length没有任何值，句1、句2不会输出任何值；
C 程序正常运行，句1、句2都会输出0；
D 这句myBox = null，删除了myBox 中的内容，这样一来myOtherBox也无法使用了；
E 这句myBox = null，只是删除了myBox的地址指向，myOtherBox仍然可以使用

3. 观察如下这段代码段：选择所有的正确项
```C#
  class Box
    {
        public double Length { get; set; }
        public double width { get; set; }//句1
        public double Height { get; set; }
        
        public Box()
        {
            Length = 10;
        }
        public Box(double length, double width, double height)
        {
            Length = length;
            width = width;//句2
            Height = height;
        }
        public static void area()
        {
            Console.WriteLine("area");

        }
    }
```
A 当在Program类中写Box myBox = new Box();后，myBox.Length中的值将自动变为10；

B 当在Program类中写Box myBox = new Box(12,13,14);后,myBox.Length,myBox.width,myBox.Height分别变为12,0,14;

C 程序报错，因为句1与句2都用了小写的width，产生冲突；

D 即使不在Program中声明Box myBox = new Box();也可以直接引用Box.area();

## 简答题：
+ 结合教程，和选择题第三题的代码，谈谈你对Box myBox = new Box();这里Box必须要打括号的看法；
+ 结合教程，和选择题第三题的代码，谈谈你对area方法中static的理解；

