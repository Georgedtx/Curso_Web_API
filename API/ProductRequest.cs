public record ProductRequest(
    string code, string name, string Description, int CategoryId, List<string> Tags
    );