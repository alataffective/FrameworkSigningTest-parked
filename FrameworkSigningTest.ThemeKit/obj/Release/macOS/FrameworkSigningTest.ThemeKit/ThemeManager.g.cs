//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using QTKit;
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;

#nullable enable

namespace FrameworkSigningTest.ThemeKit {
	[Register("TKThemeManager", true)]
	public unsafe partial class ThemeManager : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultTheme = "defaultTheme";
		static readonly IntPtr selDefaultThemeHandle = Selector.GetHandle ("defaultTheme");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetActiveThemeAssetWithKey_ = "getActiveThemeAssetWithKey:";
		static readonly IntPtr selGetActiveThemeAssetWithKey_Handle = Selector.GetHandle ("getActiveThemeAssetWithKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetThemeWithIdentifier_ = "getThemeWithIdentifier:";
		static readonly IntPtr selGetThemeWithIdentifier_Handle = Selector.GetHandle ("getThemeWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultTheme_ = "setDefaultTheme:";
		static readonly IntPtr selSetDefaultTheme_Handle = Selector.GetHandle ("setDefaultTheme:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTheme_ = "setTheme:";
		static readonly IntPtr selSetTheme_Handle = Selector.GetHandle ("setTheme:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserThemesFolderNSUrl_ = "setUserThemesFolderNSUrl:";
		static readonly IntPtr selSetUserThemesFolderNSUrl_Handle = Selector.GetHandle ("setUserThemesFolderNSUrl:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedManager = "sharedManager";
		static readonly IntPtr selSharedManagerHandle = Selector.GetHandle ("sharedManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTheme = "theme";
		static readonly IntPtr selThemeHandle = Selector.GetHandle ("theme");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selThemeWindow_ = "themeWindow:";
		static readonly IntPtr selThemeWindow_Handle = Selector.GetHandle ("themeWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserThemesFolderNSUrl = "userThemesFolderNSUrl";
		static readonly IntPtr selUserThemesFolderNSUrlHandle = Selector.GetHandle ("userThemesFolderNSUrl");
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("TKThemeManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ThemeManager () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ThemeManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ThemeManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("getActiveThemeAssetWithKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetActiveThemeAsset (string key)
		{
			if (key == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = NSString.CreateNative (key);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selGetActiveThemeAssetWithKey_Handle, nskey));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selGetActiveThemeAssetWithKey_Handle, nskey));
			}
			NSString.ReleaseNative (nskey);
			
			return ret!;
		}
		
		[Export ("getThemeWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Theme GetTheme (string identifier)
		{
			if (identifier == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = NSString.CreateNative (identifier);
			
			Theme ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<Theme> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selGetThemeWithIdentifier_Handle, nsidentifier));
			} else {
				ret =  Runtime.GetNSObject<Theme> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selGetThemeWithIdentifier_Handle, nsidentifier));
			}
			NSString.ReleaseNative (nsidentifier);
			
			return ret!;
		}
		
		[Export ("themeWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ThemeWindow (global::AppKit.NSWindow window)
		{
			var window__handle__ = window.GetNonNullHandle (nameof (window));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selThemeWindow_Handle, window__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selThemeWindow_Handle, window__handle__);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Theme ActiveTheme {
			[Export ("theme")]
			get {
				Theme ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<Theme> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selThemeHandle));
				} else {
					ret =  Runtime.GetNSObject<Theme> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selThemeHandle));
				}
				return ret!;
			}
			
			[Export ("setTheme:")]
			set {
				var value__handle__ = value.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTheme_Handle, value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTheme_Handle, value__handle__);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Theme DefaultTheme {
			[Export ("defaultTheme")]
			get {
				Theme ret;
				ret =  Runtime.GetNSObject<Theme> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, selDefaultThemeHandle));
				return ret!;
			}
			
			[Export ("setDefaultTheme:")]
			set {
				var value__handle__ = value.GetNonNullHandle (nameof (value));
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetDefaultTheme_Handle, value__handle__);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ThemeManager Shared {
			[Export ("sharedManager")]
			get {
				ThemeManager ret;
				ret =  Runtime.GetNSObject<ThemeManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, selSharedManagerHandle));
				return ret!;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl UserThemesFolderNSUrl {
			[Export ("userThemesFolderNSUrl")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selUserThemesFolderNSUrlHandle));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserThemesFolderNSUrlHandle));
				}
				return ret!;
			}
			
			[Export ("setUserThemesFolderNSUrl:")]
			set {
				var value__handle__ = value.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserThemesFolderNSUrl_Handle, value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserThemesFolderNSUrl_Handle, value__handle__);
				}
			}
		}
		
	} /* class ThemeManager */
}
