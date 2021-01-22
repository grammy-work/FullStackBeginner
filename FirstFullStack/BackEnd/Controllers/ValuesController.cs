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
			valueInteger = 54; // 一副扑克牌的数目
			return valueInteger;
		}

		[HttpGet]
		[Route("[action]")]
		public decimal GetDecimal()
		{
			decimal valueDecimal;
			valueDecimal = 8848.86m; // 珠穆朗玛峰的最新海拔
			return valueDecimal;
		}
	}
}
