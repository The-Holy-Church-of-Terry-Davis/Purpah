using Purpah.Shared.Types;
using Purpah.Shared.Types.ServerTypes;
using Microsoft.AspNetCore.Mvc;

namespace Purpah.Backend.Controllers;

public class ServerController
{
    [Route("/api/servers/getserverbyid")]
    [HttpGet]
    public static Server GetServerById(Guid id) { return new Server(Guid.NewGuid(), "", new Guid[1], new Role[1], new Message[1]); }
}