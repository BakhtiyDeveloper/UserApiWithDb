using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
using UserApiWithDb.Servises.Users;

namespace UserApiWithDb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : RESTFulController
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService; 
        }

        
    }

    





}
