using Foundation;
using System;
using UIKit;
using Xamarin.SideMenu;

namespace Somuleco.IOS
{
    public partial class ProfileViewController : UIViewController
    {


        UIGestureRecognizer _navBarGesture;

        SideMenuManager _sideMenuManager;

        public ProfileViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad() {


            this.NavigationItem.SetLeftBarButtonItem(
                new UIBarButtonItem("Left Menu", UIBarButtonItemStyle.Plain, (sender, e) => {
                    PresentViewController(_sideMenuManager.LeftNavigationController, true, null);
                }),

                false);

            _sideMenuManager = new SideMenuManager();
        }
        
    }
}