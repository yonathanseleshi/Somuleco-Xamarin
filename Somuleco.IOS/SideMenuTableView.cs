using System;
using System.Collections.Generic;


using UIKit;

namespace Somuleco.IOS
{
    public partial class SideMenuTableView : UITableViewController
    {
        String[] mine = new string[] { "Profile", "Notifications", "Chat", "My Courses" };

        String[] sideMenuLinks = new string[] {"Lessons", "Social", "Library", "Wallet", "Learning Profile" };


        String[] sideMenuImages1 = new string[] { "UserProfilePicDefault", "Notifications", "Chat", "MyLibrary"};
        String[] sideMenuImages2 = new string[] { "LessonsFeed", "SocialFeed", "Library", "Wallet", "LearningProfile" };


        Dictionary<nint, string[]> tableData = new Dictionary<nint, string[]>();
        Dictionary<nint, string[]> tableImages = new Dictionary<nint, string[]>();





        Dictionary<nint, UIViewController[]> viewControllers = new Dictionary<nint, UIViewController[]>();

        UIViewController profileVC;
        UIViewController notificationsVC;
        UIViewController chatVC;
        UIViewController mylibraryVC;
        UIViewController cartVC;


        UIViewController lessonsVC;
        UIViewController socialVC;
        UIViewController libraryVC;
        UIViewController walletVC;
        UIViewController learningProfileVC;






        public SideMenuTableView() : base("SideMenuTableView", null)
        {

            tableData.Add(0, mine);
            tableData.Add(1, sideMenuLinks);


            tableImages.Add(0, sideMenuImages1);
            tableImages.Add(1, sideMenuImages2);

            profileVC = Storyboard.InstantiateViewController("ProfileViewController") as ProfileViewController;
            notificationsVC = Storyboard.InstantiateViewController("NotificationsViewController") as NotificationsViewController;
            chatVC = Storyboard.InstantiateViewController("ChatViewController") as ChatViewController;
            mylibraryVC = Storyboard.InstantiateViewController("MyLibraryViewController") as MyLibraryViewController;
            cartVC = Storyboard.InstantiateViewController("CartViewController") as CartViewController;


            lessonsVC = Storyboard.InstantiateViewController("LessonsFeediewController") as LessonsFeedViewController;
            socialVC = Storyboard.InstantiateViewController("SocialFeedViewController") as SocialFeedViewController;
            libraryVC = Storyboard.InstantiateViewController("LibraryViewController") as LibraryViewController;
            walletVC = Storyboard.InstantiateViewController("WalletViewController") as WalletViewController;
            learningProfileVC = Storyboard.InstantiateViewController("LearningProfileViewController") as LearningProfileViewController;


            UIViewController[] vc1 = new UIViewController[] {profileVC, notificationsVC, chatVC, mylibraryVC, cartVC };
            UIViewController[] vc2 = new UIViewController[] {lessonsVC, socialVC, libraryVC, walletVC, learningProfileVC };

            viewControllers.Add(0, vc1);
            viewControllers.Add(1, vc2);




        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            TableView.BackgroundColor = UIColor.Black;

            
            
            

        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 2;
        }


        public override nint RowsInSection(UITableView tableView, nint section)
        {

            string[] tableSection = tableData[section];

            return tableSection.Length;
        }



        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            var cellDefault = new UITableViewCell(UITableViewCellStyle.Default, "default");
            var profileCell = new UITableViewCell(UITableViewCellStyle.Subtitle, "profile");
            var updateableCell = new UITableViewCell(UITableViewCellStyle.Value1, "updateable");

            if(indexPath.Section == 0 && indexPath.Row == 0) {

                profileCell.TextLabel.Text = "Display Name";
                profileCell.DetailTextLabel.Text = "@Username";


                profileCell.TextLabel.TextColor = UIColor.White;
                profileCell.TextLabel.TextColor = UIColor.LightTextColor;

                profileCell.ImageView.Image = UIImage.FromBundle("UserProfilePicDefault");
                return profileCell;
            
            }

            if (indexPath.Section == 0 && indexPath.Row == 1)
            {

                updateableCell.TextLabel.Text = "Notifications";
                updateableCell.DetailTextLabel.Text = "# of Notifications";

                updateableCell.TextLabel.TextColor = UIColor.White;
                updateableCell.TextLabel.TextColor = UIColor.LightTextColor; 

                updateableCell.ImageView.Image = UIImage.FromBundle("Notifications");
                return updateableCell;

            }
            if (indexPath.Section == 0 && indexPath.Row == 2)
            {

                updateableCell.TextLabel.Text = "Chat";
                updateableCell.DetailTextLabel.Text = "# of messages";

                updateableCell.TextLabel.TextColor = UIColor.White;
                updateableCell.TextLabel.TextColor = UIColor.LightTextColor;

                updateableCell.ImageView.Image = UIImage.FromBundle("Chat");
                return updateableCell;

            }


            string[] tableSection = tableData[indexPath.Section];
            string[] tableImagesSection = tableImages[indexPath.Section];


            cellDefault.TextLabel.Text = tableSection[indexPath.Row];
            cellDefault.ImageView.Image = UIImage.FromBundle(tableImagesSection[indexPath.Row]);

            cellDefault.TextLabel.TextColor = UIColor.White;
           

            return cellDefault;
        }



        public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);

            var sectionVcs = viewControllers[indexPath.Section];
            var vc = sectionVcs[indexPath.Row];

            this.ShowViewController(vc, this);
        }


    }
}

