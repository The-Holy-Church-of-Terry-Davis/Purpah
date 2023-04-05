using Purpah.Shared.Types;
using Microsoft.AspNetCore.Mvc;

namespace Purpah.Backend.Controllers;

public class UserController
{
    [Route("/api/users/getuserbyid")]
    [HttpGet]
    public static User GetUserById(Guid uuid) { return new(Guid.NewGuid(), "", new Guid[1], new Guid[1]); }

    [Route("/api/users/changeuser")]
    [HttpPost]
    public static User? GetUserById(Guid id, UserChangeInfo inf) 
    {  
        User tryfind = GetUserById(id);
        if(tryfind != null)
        {
            User newusr = new User(tryfind.uuid, inf.username, tryfind.servers, tryfind.friends);
            /*
                Do some database magic!
            */
            return newusr;
        }

        return tryfind;
    }
}