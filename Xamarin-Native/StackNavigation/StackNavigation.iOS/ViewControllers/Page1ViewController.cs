using UIKit;

namespace StackNavigation.iOS.ViewControllers
{
    public class Page1ViewController : UIViewController
    {
        public Page1ViewController()
        {
            this.View.BackgroundColor = UIColor.White;

            this.Title = "White";

            var myButton = UIButton.FromType(UIButtonType.RoundedRect);
            myButton.SetTitle("Go to Next Page", UIControlState.Normal);
            myButton.Frame = new CoreGraphics.CGRect(0, 0, 150, 30);
            myButton.Center = this.View.Center;

            myButton.TouchUpInside += (sender, e) =>
            this.NavigationController.PushViewController(new Page2ViewController(), true);

            this.Add(myButton);
        }
    }
}
