using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

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
        IconWeight.Weight100 => $" material-symbols-wght-100",
        IconWeight.Weight200 => $" material-symbols-wght-200",
        IconWeight.Weight300 => $" material-symbols-wght-300",
        IconWeight.Weight500 => $" material-symbols-wght-500",
        IconWeight.Weight600 => $" material-symbols-wght-600",
        IconWeight.Weight700 => $" material-symbols-wght-700",
        _ => $"",
    };

    public static string CssClass(this IconGrade grade) => grade switch
    {
        IconGrade.Low => $" material-symbols-grad-low",
        IconGrade.High => $" material-symbols-grad-high",
        _ => $"",
    };

    public static string CssClass(this IconSize size) => size switch
    {
        IconSize.Small => $" material-symbols-opsz-20",
        IconSize.Large => $" material-symbols-opsz-40",
        IconSize.ExtraLarge => $" material-symbols-opsz-48",
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
        IconFill.Solid => 1,
        _ => 0,
    };

    public static int Value(this IconWeight weight) => weight switch
    {
        IconWeight.Weight100 => 100,
        IconWeight.Weight200 => 200,
        IconWeight.Weight300 => 300,
        IconWeight.Weight500 => 500,
        IconWeight.Weight600 => 600,
        IconWeight.Weight700 => 700,
        _ => 400,
    };

    public static int Value(this IconGrade grade) => grade switch
    {
        IconGrade.Low => -25,
        IconGrade.High => 200,
        _ => 0,
    };

    public static int Value(this IconSize size) => size switch
    {
        IconSize.Small => 20,
        IconSize.Large => 40,
        IconSize.ExtraLarge => 48,
        _ => 24,
    };
}
