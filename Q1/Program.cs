using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q1 利用Enumerable.Range() 建立一個序列, 值介於 [1, 10]  請利用迴圈列出每一個項目值,確認無誤
			var result = Enumerable.Range(1, 10);
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}
	}
}
