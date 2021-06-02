using AppKit;
using Foundation;

namespace FrameworkSigningTest.ThemeKit
{
    [BaseType(typeof(NSObject), Name = "TKThemeManager")]
    interface ThemeManager
    {
        [Static, Export("sharedManager")]
        ThemeManager Shared { get; }

        [Static, Export("defaultTheme")]
        Theme DefaultTheme { get; set; }

        [Export("userThemesFolderNSUrl")]
        NSUrl UserThemesFolderNSUrl { get; set; }

        [Export("getThemeWithIdentifier:")]
        Theme GetTheme(string identifier);

        [Export("theme")]
        Theme ActiveTheme { get; set; }

        [Export("getActiveThemeAssetWithKey:")]
        NSObject GetActiveThemeAsset(string key);

        [Export("themeWindow:")]
        void ThemeWindow(NSWindow window);
    }

    [BaseType(typeof(NSObject), Name = "TKTheme")]
    [Model, Protocol]
    interface Theme
    {
    }
}
