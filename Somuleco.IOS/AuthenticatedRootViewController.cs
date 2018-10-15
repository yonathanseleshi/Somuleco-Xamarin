using Foundation;
using System;
using UIKit;

using SidebarNavigation;

namespace Somuleco.IOS
{
    public partial class AuthenticatedRootViewController : UIViewController
    {


        public SidebarController SidebarController { get; private set; }

        public UINavigationController lessonsNavController { get; private set; }


        public AuthenticatedRootViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var lessonsFeedViewController = (LessonsFeedViewController)Storyboard.InstantiateViewController("LessonFeedViewController");
            var drawerMenuController = (DrawerMenuController)Storyboard.InstantiateViewController("DrawerMenuViewController");

            lessonsNavController = Storyboard.InstantiateViewController("LessonsNavController") as UINavigationController;



            SidebarController = new SidebarController(this, lessonsNavController, drawerMenuController);
        }
    }
}