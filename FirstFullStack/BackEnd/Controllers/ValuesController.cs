using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		[HttpGet]
		[Route("[action]")]
		public dynamic GetValue()
		{
			return 1;
		}

		[HttpGet]
		[Route("[action]")]
		public dynamic GetDynamic()
		{
			dynamic value;
			value = 1;
			return value;
		}

		[HttpGet]
		[Route("[action]")]
		public dynamic GetStringWithDynamic()
		{
			dynamic value;
			value = "abc";
			return value;
		}

		[HttpGet]
		[Route("[action]")]
		public string GetString()
		{
			string value;
			value = "abc";
			return value;
		}

		[HttpGet]
		[Route("[action]")]
		public int GetInteger()
		{
			int valueInteger;
			valueInteger = 54 - 2; // 一副扑克牌的数目，减去两张大小鬼。
			valueInteger = valueInteger / 4; // 把除去大小鬼之后的牌，平均分给四个人，玩锄大地。
			/*
			以上这行可以简写成：
			valueInteger /= 4; 
			意思就是这个变量把自己除以四，再赋值给自己。
			（在C语言中，超过一行的注释可以用斜杠星和星斜杠来形成多行的注释段落。）
			*/
			return valueInteger; // 返回每个人能够分得多少张牌。玩过的人都知道是13张，调试一下对不对。
		}

		[HttpGet]
		[Route("[action]")]
		public decimal GetDecimal()
		{
			decimal valueDecimal;

			// 珠穆朗玛峰的最新海拔
			valueDecimal = 8848.86m;

			// 珠穆朗玛峰平均每一百年上升7厘米，求2046年的时候，珠穆朗玛峰高度是多少？
			valueDecimal += 0.07m * (2046 - 2021) / 100;

			return valueDecimal; // 返回2046年的时候珠穆朗玛峰海拔多高
		}
	}
}
