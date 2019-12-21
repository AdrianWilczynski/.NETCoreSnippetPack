using System.Runtime.CompilerServices;
using System.Text.Json;

private static string GetSnippetsFolder([CallerFilePath] string callerFilePath = null)
    => Path.Join(Path.GetDirectoryName(callerFilePath), "..", "snippets");

private var count = Directory.GetFiles(GetSnippetsFolder())
    .Sum(f => JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(f)).Count);

WriteLine(count);