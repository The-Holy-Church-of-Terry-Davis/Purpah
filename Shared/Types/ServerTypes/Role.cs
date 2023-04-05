namespace Purpah.Shared.Types.ServerTypes;

public record Role(Guid id, string name, Permission[] permissions, long hexcolor);