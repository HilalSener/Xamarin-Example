using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace TableViewDemo
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			
		}

		UITableView tableView;

		class EmailServerDataSource : UITableViewSource
		{
			EmailServer emailServer = new EmailServer();

			public override nint RowsInSection(UITableView tableview, nint section)
			{
				return emailServer.Email.Count;
			}

			public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
			{
				UITableViewCell cell = new UITableViewCell(CGRect.Empty);

				var emailItem = emailServer.Email[indexPath.Row];
				cell.TextLabel.Text = emailItem.Subject;

				return cell;
			}
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			tableView = new UITableView(this.View.Frame);

			tableView.Source = new EmailServerDataSource();

			//this.View.Add(tableView);
			//this.Add(tableView);
			this.View.AddSubview(tableView);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}
	}
}

