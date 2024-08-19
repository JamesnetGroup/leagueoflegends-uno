using System.Reflection;

namespace Jamesnet.Core;

public static class YamlConverter
{
    public static IEnumerable<IReadOnlyDictionary<string, string>> Parse(string content)
    {
        return ParseYamlContent(content);
    }

    public static IEnumerable<IReadOnlyDictionary<string, string>> ParseFile(string filePath)
    {
        string content = File.ReadAllText(filePath);
        return Parse(content);
    }

    public static IEnumerable<IReadOnlyDictionary<string, string>> ParseResource(Assembly assembly, string resourcePath)
    {
        using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
        using (StreamReader reader = new StreamReader(stream))
        {
            string content = reader.ReadToEnd();
            return Parse(content);
        }
    }

    private static IEnumerable<IReadOnlyDictionary<string, string>> ParseYamlContent(string content)
    {
        var lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None)
            .Where(line => !string.IsNullOrWhiteSpace(line) && !line.TrimStart().StartsWith("#"));
        return lines
            .Where(line => line.TrimStart().StartsWith("-"))
            .Select(line => lines.SkipWhile(l => l != line).TakeWhile(l => !l.TrimStart().StartsWith("-") || l == line))
            .Select(group => group
                .Where(l => l.Contains(':'))
                .ToDictionary(
                    kvp => kvp.Split(':')[0].Trim().TrimStart('-', ' '), // Remove leading '-' and spaces
                    kvp => kvp.Split(new[] { ':' }, 2)[1].Trim()
                )
            )
            .Select(dict => dict as IReadOnlyDictionary<string, string>);
    }
}
