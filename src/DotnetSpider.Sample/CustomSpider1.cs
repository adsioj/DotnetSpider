﻿using DotnetSpider.Core;
using System;

namespace DotnetSpider.Sample
{
	[TaskName("CustomSpider1")]
	public class CustomSpider1 : AppBase
	{
		protected override void Execute(params string[] arguments)
		{
			Console.WriteLine("hello");
		}
	}
}

