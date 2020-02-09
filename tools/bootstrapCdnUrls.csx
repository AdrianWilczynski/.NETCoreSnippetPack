private var bootstrap = "https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css";

private var mdbootstrap = "https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.7.6/css/mdb.min.css";

private var materialDesignForBootstrap = "https://unpkg.com/bootstrap-material-design@4.1.1/dist/css/bootstrap-material-design.min.css";

private var bootswatch = new[]
{
    "cerulean", "cosmo", "cyborg", "darkly", "flatly", "journal", "litera", "lumen", "lux", "materia", "minty", "pulse",
    "sandstone", "simplex", "sketchy", "slate", "solar", "spacelab", "superhero", "united", "yeti"
}.Select(theme => $"https://stackpath.bootstrapcdn.com/bootswatch/4.4.1/{theme}/bootstrap.min.css");

private var hackerThemes = new[]
{
    "bubblegum", "business-tycoon", "charming", "daydream", "executive-suite", "good-news", "growth", "harbor",
    "hello-world", "neon-glow", "pleasant", "retro", "vibrant-sea", "wizardry"
}.Select(theme => $"https://cdn.jsdelivr.net/gh/HackerThemes/theme-machine/dist/{theme}/css/bootstrap4-{theme}.min.css");

private var topHat = new[]
{
    "deeply", "electro", "graymor", "hollar", "lymcha", "mickie", "minco", "monotone", "preptor",
    "skeeblu", "sunset", "wandoo"
}.Select(theme => $"https://themesguide.github.io/top-hat/dist/{theme}/theme.min.css");

private var bootcatchThemes = new[]
{
    "angular-material", "apollo", "bazooka", "blossom", "bulma", "chocolate", "comely",
    "darkly", "epic", "foresty", "framework7-UI", "grace", "hero", "lightly", "material",
    "mayablue", "orangely", "peace", "pensive", "pilly", "shadow", "simply", "slateblue",
    "solitude", "squarely", "supine"
}.Select(theme => $"https://unpkg.com/bootcatch-themes@2.3.0/dist/{theme}/bootstrap.min.css");

private var all = new[] { bootstrap }
    .Append(mdbootstrap)
    .Append(materialDesignForBootstrap)
    .Concat(bootswatch)
    .Concat(hackerThemes)
    .Concat(topHat)
    .Concat(bootcatchThemes);

WriteLine(string.Join(",", all));