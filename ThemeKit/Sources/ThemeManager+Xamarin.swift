//
//  ThemeManager+Xamarin.swift
//  ThemeKit
//
//  Extensions for adapting ThemeKit for use from Xamarin
//

import Cocoa

public extension ThemeManager {
    
    @objc var userThemesFolderNSUrl: NSURL? {
        get {
            return self.userThemesFolderURL == nil ? nil : NSURL(string: self.userThemesFolderURL!.absoluteString)
        }
        set(value) {
            self.userThemesFolderURL = value?.absoluteURL
        }
    }
    
    @objc func getTheme(withIdentifier identifier: String?) -> Theme? {

        if let themeIdentifier: String = identifier {

            for theme in themes {

                let themeTypeName = String(describing: type(of: theme))

                if (themeTypeName == "TKTheme") {
                    continue;
                }
                
                if (theme.identifier == themeIdentifier) {
                    return theme
                }
            }
        }
        return nil
    }
    
    @objc func getActiveThemeAsset(key: String) -> Any? {

        return self.theme.themeAsset(key)
    }
    
    @objc func themeWindow(_ window: NSWindow) {
        
        window.theme()
    }
}
