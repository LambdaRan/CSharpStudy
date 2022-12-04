using System;
using System.Diagnostics;
// 元组
namespace CSharpStudy
{
    public class TestTupleClass
    {
        public TestTupleClass()
        {
        }
        public void Declare() {
            // 将元组赋给单独声明的变量
            (string country, string capital, double gdp) = ("coun", "cap", 1.02);
            Console.WriteLine($"{country}-{capital}-{gdp}");

            // 将元组赋给预声明的变量
            string co1;
            string ca1;
            double gd1;
            (co1, ca1, gd1) = ("cou", "cap", 1.1);
            Console.WriteLine($"{co1}-{ca1}-{gd1}");

            // 将元组赋给单独声明和隐式类型的变量
            (var co2, var ca2, var gd2) = ("cou", "cap", 1.2);
            Console.WriteLine($"{co2}-{ca2}-{gd2}");

            // 将元组赋给单独声明和隐式类型的变量，只用一个var
            var (co3, ca3, gd3) = ("cou", "cap", 1.3);
            Console.WriteLine($"{co3}-{ca3}-{gd3}");

            // 声明具名元组，将元组赋值给它，按名字访问数据
            (string co4, string ca4, double gd4) info = ("cou4", "cap4", 1.4);
            Console.WriteLine($"{info.co4}-{info.ca4}-{info.gd4}");

            // 声明包含具名元组项的元组，并将其赋给隐式类型的变量，按名访问元组项
            var info2 = (Name: "cou5", Cap:"ca5", Gdp:1.5);
            Console.WriteLine($"{info2.Name}-{info2.Cap}-{info2.Gdp}");

            // 将元组项未具名的元组赋给隐式类型的变量，通过项目编号访问
            var info3 = ("cou6", "cap6", 1.6);
            Console.WriteLine($"{info3.Item1}-{info3.Item2}-{info3.Item3}");

            // 将含有具名项的元组赋给隐式类型的变量，通过项目编号访问
            // 同上

            // 赋值时使用下划线(_)丢弃元组的一部分，弃元
            (string co7, _, double gd7) = ("cou7", "ca7", 1.7);
            Console.WriteLine($"{co7}-{gd7}");

            // 通过变量和属性名推断元组项名称
            var info4 = (co1, ca1, gd1);
            Console.WriteLine($"{info4.co1}-{info4.ca1}-{info4.gd1}");
        }
    }
}

