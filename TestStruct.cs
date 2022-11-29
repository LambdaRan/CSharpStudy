using System;
namespace CSharpStudy
{
    // readonly
    public struct TestStruct
    {
        public string Field = "";
        public int value = 42;

        public TestStruct() {
            Field = "1";
            value = 1;
        }
    }

    // 默认类型是int
    // 自动密封，不能被继承
    // 枚举类型到基础类型转换或反过程都要显示转换
    public enum ConnectionState : int {
          eDisconnected, // 默认值0
          eConnecting = 2,
          eConnected = 3,
    }

    // 使用[Flags]定义位标志枚举

}

