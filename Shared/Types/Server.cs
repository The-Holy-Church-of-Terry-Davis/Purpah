using Purpah.Shared.Types.ServerTypes;

namespace Purpah.Shared.Types;

public record Server(Guid id, string name, ServerUser[] users, Role[] roles);
public record ServerUser(Guid suuid, User globaluser, Role[] roles, string servername, Tuple<DateTime, string> messages);