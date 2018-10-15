// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Somuleco.IOS
{
    [Register ("DrawerMenuController")]
    partial class DrawerMenuController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CartButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ChatButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MyLibraryButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton NotificationsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ProfileButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ProfileButton2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ProfilePic { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ProfilePicButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CartButton != null) {
                CartButton.Dispose ();
                CartButton = null;
            }

            if (ChatButton != null) {
                ChatButton.Dispose ();
                ChatButton = null;
            }

            if (MyLibraryButton != null) {
                MyLibraryButton.Dispose ();
                MyLibraryButton = null;
            }

            if (NotificationsButton != null) {
                NotificationsButton.Dispose ();
                NotificationsButton = null;
            }

            if (ProfileButton != null) {
                ProfileButton.Dispose ();
                ProfileButton = null;
            }

            if (ProfileButton2 != null) {
                ProfileButton2.Dispose ();
                ProfileButton2 = null;
            }

            if (ProfilePic != null) {
                ProfilePic.Dispose ();
                ProfilePic = null;
            }

            if (ProfilePicButton != null) {
                ProfilePicButton.Dispose ();
                ProfilePicButton = null;
            }
        }
    }
}