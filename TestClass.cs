using System;
namespace CSharpStudy
{
    // 抽象类在类的基础上增加了抽象相关的特性，其他跟类一样，可声明
    // 字段、属性、方法、静态字段、静态属性、静态方法、虚属性、虚方法、抽象属性、抽象方法
    // 抽象成员不能声明为私有，不能有实现
    public abstract class IAbsTestClass {
        // 抽象成员必须放在重新类中

        // 抽象属性不能有初始值，不能有实现
        public abstract string AbsPFiled { get; set; }
        // 抽象方法不能有实现
        public abstract string GetAbsPFiled();

    }
    // static/abstract/sealed/partial
    public class TestClass
    {
        // 类成员默认访问修饰符为 private
        public static int kId = 1;
        public static int GetKID() => kId;
        // 静态构造函数不显示调用，在首次访问类是自动调用。
        // 将雷总的静态数据初始化为特定值
        // 不要在静态函数中抛出异常
        static TestClass() {
            // 静态函数中的赋值优先于声明时的赋值。
            kId = 2;
        }
        // 静态属性
        public static int NextId { get; private set; } = 42;

        private string ClassField = "声明时设置字段初始值";
        public string Field { get; set; } = "自动实现的属性";
        public string PpField { get; private set; }
        public readonly string ReadonlyFeild = "Readonly字段";
        public const string ConstField = "Const字段";
        // 有 private set 的属性，可在类内任何方法内赋值、修改值。
        // readonly字段只能在构造函数中赋值。
        // const 字面值的类型

        // 实例方法：表达式主体方法 
        public string GetFieldName() => ClassField;

        // 无参构造函数就是默认构造函数
        // 构造函数可以重载，只要参数数量和类型不同。
        public TestClass()
        {
            // 最终生效的是构造函数内赋的值，它会覆盖声明时的初始值。
            ClassField = "构造函数内赋值";
        }
        // 解构函数，把封装好的项拆分为它的各个组成部分。
        //public void Deconstruct() { }

        private class NestedClass
        {
            // 嵌套类能访问包容类的任何成员，其中包括私有成员。反之，包容类不能访问嵌套类的私有成员
        }

        // 分部方法
        // partial void OnFieldChange();

        // 自定义转化 explicit显示转换
        //public static implicit operator OtherType() { }

        public virtual string Name { get; set; } = "虚属性";
        public virtual string GetName() => "虚方法";



    }
    // 单继承
    // 调用虚方法会将虚方法的调用调度给派生的最远的类型。
    public class DriTestClass : TestClass {
        // 派生类重写基类的虚属性
        public override string Name {
            get => base.Name;
            set => base.Name = value;
        }
        // 派生类可选择不重写基类虚方法/属性
        //public override string GetName() => base.GetName();

        // 调用基类的哪个构造函数
        //public DriTestClass(string name) : base(name) { }
    }
}

