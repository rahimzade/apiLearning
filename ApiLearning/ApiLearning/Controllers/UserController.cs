using ApiLearning.model.exam;
using ApiLearning.model.UserList;
using Microsoft.AspNetCore.Mvc;

namespace ApiLearning.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {

        [HttpPost]
        public bool Register(UserInfo user)
        {
            try
            {
                // UsersList UserList = new UsersList();
                //users.Add(user);
                UsersList.users.Add(user);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
       
    }
}

