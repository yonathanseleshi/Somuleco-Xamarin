using Foundation;
using System;
using UIKit;
using SidebarNavigation;

namespace Somuleco.IOS
{
    public partial class DrawerTableViewController : UITableViewController
    {

        UINavigationController LessonsNavController;
        UINavigationController libraryNavController;
        UINavigationController socialNavController;
        UINavigationController walletNavController;
        UINavigationController learningProfileNavController;

        public SidebarController SidebarController { get; private set; }

        public DrawerTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            LessonsNavController = Storyboard.InstantiateViewController("LessonsNavController") as UINavigationController;
            libraryNavController = Storyboard.InstantiateViewController("LibraryNavController") as UINavigationController;
            socialNavController = Storyboard.InstantiateViewController("SocialNavController") as UINavigationController;
            walletNavController = Storyboard.InstantiateViewController("WalletNavController") as UINavigationController;
            learningProfileNavController = Storyboard.InstantiateViewController("LearningProfileNavController") as UINavigationController;
            

        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {


            switch (indexPath.Row) {

                case 0:
                    SidebarController.ChangeContentView(LessonsNavController);
                    break;
                case 1:
                    SidebarController.ChangeContentView(socialNavController);
                    break;
                case 2:
                    SidebarController.ChangeContentView(libraryNavController);
                    break;
                case 3:
                    SidebarController.ChangeContentView(walletNavController);
                    break;
                case 4:
                    SidebarController.ChangeContentView(learningProfileNavController);
                    break;

            }


        }
    }
}