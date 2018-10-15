using Foundation;
using System;
using UIKit;
using SidebarNavigation;

namespace Somuleco.IOS
{
    public partial class LessonsFeedViewController : UIViewController
    {


        public SidebarController SidebarController { get; private set; }

        public LessonsFeedViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            MenuToggle.Clicked += (sender, e) => {
                SidebarController.ToggleMenu();
            };



        }
    }
}