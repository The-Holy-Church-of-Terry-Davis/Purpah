using Purpah.Shared.Types;
using Microsoft.AspNetCore.Mvc;

namespace Purpah.Backend.Controllers;

public static class SessionVars
{
    public static List<(Guid, SessionValidationInfo)> sessionIds = new();

    public static bool CheckHash(string hash) { return true; }
    public static bool ContainsSession(Guid id)
    {
        foreach((Guid, SessionValidationInfo) val in sessionIds)
        {
            if(val.Item1 == id)
            {
                return true;
            }
        }

        return false;
    }
}

public class SessionController : ControllerBase
{
    [Route("/api/session/init")]
    [HttpGet]
    public static Guid? InitSession(SessionValidationInfo inf)
    {
        if(UserController.UserExists(inf.userGuid) != false)
        {
            if(SessionVars.CheckHash(inf.hash) != false)
            {
                Guid newsesh = Guid.NewGuid();

                if(SessionVars.sessionIds.Contains((newsesh, inf)))
                {
                    newsesh = Guid.NewGuid();
                    SessionVars.sessionIds.Add((newsesh, inf));
                    return newsesh;
                } else {
                    SessionVars.sessionIds.Add((newsesh, inf));
                    return newsesh;
                }
            }
        }

        return null;
    }
}