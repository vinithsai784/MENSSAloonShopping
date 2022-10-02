using MENSSAloonShopping.Models;
using MVC_Application.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using System.Web.Routing;

namespace MENSSAloonShopping.Controllers
{
    //[EnableCorsAttribute("*","*","*")]
    public class AccountController : ApiController
    {
        private BarbersShopEntities entities = new BarbersShopEntities();
        public static int UserId;
        public AccountController()
        {
            this.entities = new BarbersShopEntities();
        }
        public IEnumerable<User> GetUsers()
        {
            return entities.Users.ToList();
        }
        [System.Web.Http.HttpPost]
        public void Create(User model)
        {
            if (ModelState.IsValid)
            {
                using (entities)
                {
                    ObjectParameter respnseMessage = new ObjectParameter("responseMessage", typeof(string));
                    entities.Users.Add(model);
                    entities.SaveChanges();
                }
            }
            //return BadRequest( ModelState InvalidModelState);

        }
        //[System.Web.Http.Route(Login)]
        [System.Web.Http.Route("Login")]
        //[HttpPost]
        public HttpResponseMessage Login(UserLogin userLogin)
        {
            if (ModelState.IsValid)
            {
                using (entities)
                {
                    var _currentUser = entities.Users.FirstOrDefault(user => user.UserName == userLogin.UserName && user.PassWord == userLogin.PassWord);
                    if (_currentUser != null)
                    {
                        UserId = _currentUser.ID;
                        //TODO: Redirect To Single app Page with this UserId
                        Debug.WriteLine("Success &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
                        //Redirect("https://localhost:44349/api/user/Create");
                        var newUrl = this.Url.Link("DefaultApi", new
                        {
                            Controller = "Account",
                            Action = "Create"
                        });
                        return Request.CreateResponse(HttpStatusCode.Created,
                                             new { Success = true, RedirectUrl = newUrl });
                    }
                    return null;
                }
            }
            return null;
        }

        
      
    }
}