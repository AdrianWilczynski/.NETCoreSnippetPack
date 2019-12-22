using System.Text.RegularExpressions;

private var words = File.ReadAllLines(Args[0])
    .Select(l => $"\"{Regex.Match(l, @"\S+").Value}\"");

WriteLine(string.Join(", ", words));