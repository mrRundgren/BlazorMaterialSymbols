namespace BlazorMaterialSymbols;

public static class IconExtensions
{
    public static string CssClass(this IconType type) => type switch
    {
        IconType.Sharp => $" material-symbols-sharp",
        IconType.Rounded => $" material-symbols-rounded",
        _ => $"",
    };

    public static string CssClass(this IconFill fill) => fill switch
    {
        IconFill.Solid => $" material-symbols-fill-1",
        _ => $"",
    };

    public static string CssClass(this IconWeight weight) => weight switch
    {
        IconWeight.W100 => $" material-symbols-wght-100",
        IconWeight.W200 => $" material-symbols-wght-200",
        IconWeight.W300 => $" material-symbols-wght-300",
        IconWeight.W500 => $" material-symbols-wght-500",
        IconWeight.W600 => $" material-symbols-wght-600",
        IconWeight.W700 => $" material-symbols-wght-700",
        _ => $"",
    };

    public static string CssClass(this IconGrade grade) => grade switch
    {
        IconGrade.Min => $" material-symbols-grad-min",
        IconGrade.Low => $" material-symbols-grad-low",
        IconGrade.Max => $" material-symbols-grad-max",
        _ => $"",
    };

    public static string CssClass(this IconSize size) => size switch
    {
        IconSize.SM => $" material-symbols-opsz-20",
        IconSize.MD => $" material-symbols-opsz-32",
        IconSize.LG => $" material-symbols-opsz-40",
        IconSize.XL => $" material-symbols-opsz-48",
        IconSize.XXL => $" material-symbols-opsz-56",
        IconSize.XXXL => $" material-symbols-opsz-64",
        _ => $"",
    };

    public static string Value(this IconType type) => type switch
    {
        IconType.Sharp => $"Material Symbols Sharp",
        IconType.Rounded => $"Material Symbols Rounded",
        _ => $"Material Symbols Outlined",
    };

    public static int Value(this IconFill fill) => fill switch
    {
        IconFill.None => 0,
        IconFill.Solid => 1,
        _ => 0,
    };

    public static int Value(this IconWeight weight) => weight switch
    {
        IconWeight.W100 => 100,
        IconWeight.W200 => 200,
        IconWeight.W300 => 300,
        IconWeight.W400 => 300,
        IconWeight.W500 => 500,
        IconWeight.W600 => 600,
        IconWeight.W700 => 700,
        _ => 400,
    };

    public static int Value(this IconGrade grade) => grade switch
    {
        IconGrade.Min => -50,
        IconGrade.Low => -25,
        IconGrade.Normal => 0,
        IconGrade.Max => 200,
        _ => 0,
    };

    public static int Value(this IconSize size) => size switch
    {
        IconSize.SM => 20,
        IconSize.Normal => 24,
        IconSize.MD => 32,
        IconSize.LG => 40,
        IconSize.XL => 48,
        IconSize.XXL => 56,
        IconSize.XXXL => 64,
        _ => 24,
    };
}
