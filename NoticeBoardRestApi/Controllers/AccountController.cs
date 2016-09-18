using NoticeBoardDtos.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using User;

namespace NoticeBoardRestApi.Controllers
{
    public class AccountController : ApiController
    {
        public void Index()
        {
            //return View();
        }
        public void Login(Login input)
        {
            new UserLogic().Login(input);
        }
    }
}
