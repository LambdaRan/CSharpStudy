using System;
namespace CSharpStudy
{
    public interface TestInterface
    {
        // public string Field = "接口中不能包含实例字段";
        // 不能有初始值设定
        public string Field { get; set; }
        // protected/private 访问修饰符的属性，
        protected string PField {
            get => "";
            set {
               
            }
        }
        
        public static string SField = "可声明静态成员";
        public static string SPFiled { get; set; } = "静态属性";
        public static string GetSPField() => SPFiled;

        public virtual int PValue {
            get => 1;
            set {
            }
        }
        public virtual int GetPValue() => PValue;

        // 实例方法
        public int GetValue() => 0;
    }
}

