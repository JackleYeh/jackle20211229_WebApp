using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jackle20211229_WebApp.Controllers
{
    public class LineChatController : ApiController
    {
        public List<int> Get()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            return list;
        }
    }
}
