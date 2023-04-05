namespace Purpah.Shared.Types;

public record User(Guid uuid, string username, Guid[] servers, Guid[] friends);
public record UserChangeInfo(Guid uuid, string username);