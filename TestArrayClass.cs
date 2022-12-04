using System;
using System.Diagnostics;

namespace CSharpStudy
{
    public class TestArrayClass
    {
        public TestArrayClass()
        {
            // 数组长度固定
            
        }

        public void Declare()
        {
            // 一维数组
            string[] lan;
            // C# 3.0后类型可省略
            lan = new[] { "C#", "lua" };
            // new 和 类型可选
            string[] lan2 = {"C#", "lua"};
            // 声明后在其他地方赋值需要用new
            lan2 = new string[9];

            // 不提供初始值就必须指定数组大小。大小不一定为常量，可以在运行时计算的变量。
            // 如果指定大小，必须跟初始化的元素数量匹配。

            // 未赋值，每个元素都为默认值，default(string) null
            string[] lan3 = new string[2];
            Console.WriteLine($"一维数组:{lan[0]}-{lan2.Length}-{lan3.Length}");
            Debug.Assert(lan[0] == "C#");

            // 二维数组，矩形数组
            int[,] cells;
            // 每一维的大小必须一样
            cells = new int[2,3] {
                {1,2,3 },
                {4,5,6 }
            };
            Console.WriteLine($"二维数组[0,2]:{cells[0,2]}");
            Debug.Assert(cells[0, 2] == 3);
            // 多维数组的Length 属性返回总的元素数
            Debug.Assert(cells.Length == 6);

            // 交错数组，由数组构成的数组。各个数组不需要大小一样
            int[][] jagged = {
                new int[] {1,2,3 },
                new int[] { 4,5},
                new int[]{ 6},
            };
            Console.WriteLine($"交错数组：[1][1] = {jagged[1][1]}");
            Debug.Assert(jagged[1][1] == 5);
            // 交错数组的 Length属性返回外围大小
            Debug.Assert(jagged.Length == 3);

            // 数组的 Clear 方法不删除数组元素，只是将每个元素设为默认值
            // 通过 GetLength(0) 方法来指定获取哪一维的大小
            // 通过 Rank 属性来获取数组维数
        }
    }
}

