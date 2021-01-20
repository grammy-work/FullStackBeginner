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
	}
}
