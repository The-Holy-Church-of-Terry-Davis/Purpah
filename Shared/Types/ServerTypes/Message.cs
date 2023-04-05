namespace Purpah.Shared.Types.ServerTypes;

public record Message(Guid messageid, Guid user, Guid server, string content);