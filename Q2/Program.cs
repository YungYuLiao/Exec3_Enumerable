﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//用Enumerable.Range() 建立一個序列, 值介於 [10, 15] 請利用迴圈列出每一個項目值,確認無誤

			var result = Enumerable.Range(10,6);
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}
	}
}
