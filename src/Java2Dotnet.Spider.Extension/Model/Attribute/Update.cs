using System;

namespace Java2Dotnet.Spider.Extension.Model.Attribute
{
	[AttributeUsage(AttributeTargets.Class)]
	public class Update : System.Attribute
	{
		public string[] Columns { get; set; }
	}
}
