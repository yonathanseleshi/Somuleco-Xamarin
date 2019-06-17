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

namespace Somuleco.IOS.Views
{
    [Register ("LoginView")]
    partial class LoginView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CancelBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoginBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LoginEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LoginPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SignupBtn { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CancelBtn != null) {
                CancelBtn.Dispose ();
                CancelBtn = null;
            }

            if (LoginBtn != null) {
                LoginBtn.Dispose ();
                LoginBtn = null;
            }

            if (LoginEmail != null) {
                LoginEmail.Dispose ();
                LoginEmail = null;
            }

            if (LoginPassword != null) {
                LoginPassword.Dispose ();
                LoginPassword = null;
            }

            if (SignupBtn != null) {
                SignupBtn.Dispose ();
                SignupBtn = null;
            }
        }
    }
}