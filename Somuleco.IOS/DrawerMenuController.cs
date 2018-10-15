using Foundation;
using System;
using UIKit;

using SidebarNavigation;

namespace Somuleco.IOS
{
    public partial class DrawerMenuController : UIViewController
    {

        UINavigationController myLibraryNavController;
        UINavigationController chatNavController;
        UINavigationController cartNavController;
        UINavigationController profileNavController;
        UINavigationController notificationsNavController;



        public SidebarController SidebarController { get; private set; }

        public DrawerMenuController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SidebarController.HasShadowing = true;
            SidebarController.MenuWidth = 220;
            SidebarController.MenuLocation = MenuLocations.Left;

            myLibraryNavController = Storyboard.InstantiateViewController("MyLibraryNavController") as UINavigationController;
            chatNavController = Storyboard.InstantiateViewController("ChatNavController") as UINavigationController;
            cartNavController = Storyboard.InstantiateViewController("CartNavController") as UINavigationController;
            profileNavController = Storyboard.InstantiateViewController("ProfileNavController") as UINavigationController;
            notificationsNavController = Storyboard.InstantiateViewController("NotificationsNavController") as UINavigationController;


            MyLibraryButton.TouchUpInside += (sender, e) =>
            {

                SidebarController.ChangeContentView(myLibraryNavController);

            };



            ChatButton.TouchUpInside += (sender, e) =>
            {

                SidebarController.ChangeContentView(chatNavController);

            };



            CartButton.TouchUpInside += (sender, e) =>
            {

                SidebarController.ChangeContentView(cartNavController);

            };



            NotificationsButton.TouchUpInside += (sender, e) =>
            {

                SidebarController.ChangeContentView(notificationsNavController);

            };



            ProfileButton.TouchUpInside += (sender, e) =>
            {

                SidebarController.ChangeContentView(notificationsNavController);

            };
            ProfileButton2.TouchUpInside += (sender, e) =>
            {

                SidebarController.ChangeContentView(notificationsNavController);

            };
            ProfilePicButton.TouchUpInside += (sender, e) =>
            {

                SidebarController.ChangeContentView(notificationsNavController);

            };
        }
    }
}