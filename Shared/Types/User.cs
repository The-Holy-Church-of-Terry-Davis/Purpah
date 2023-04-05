namespace Purpah.Shared.Types;

public record User(Guid uuid, string username, Server[] servers, User[] friends);