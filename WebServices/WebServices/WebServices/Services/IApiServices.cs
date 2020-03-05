using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebServices.Models;

namespace WebServices.Services
{
	public interface IApiServices
	{
		Task<Genre> GetGenre(string id);
	}
}
