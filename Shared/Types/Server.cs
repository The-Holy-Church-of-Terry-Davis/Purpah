using Purpah.Shared.Types.ServerTypes;

namespace Purpah.Shared.Types;

public record Server(Guid id, string name, Guid[] users, Role[] roles, Message[] messages);
public record ServerUser(Guid suuid, User globaluser, Role[] roles, string servername);