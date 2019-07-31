using Foundation;
using System;
using UIKit;
using System.Drawing;

namespace week1
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }


        UIButton imgButton;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            imgButton = UIButton.FromType(UIButtonType.Custom);
            imgButton.Frame = new RectangleF(0, 0, float.Parse(View.Bounds.Width.ToString()), float.Parse(View.Bounds.Height.ToString()));

            imgButton.SetImage(UIImage.FromFile("we.jpg"), UIControlState.Normal);
            View.AddSubview(imgButton);
            imgButton.SetBackgroundImage(UIImage.FromFile("back.jpg"), UIControlState.Normal);
            View.AddSubview(imgButton);


            var imageSwitch = false;
            imgButton.TouchUpInside += delegate
            {
                if (imageSwitch)
                {
                    imgButton.SetImage(UIImage.FromFile("buou.jpg"), UIControlState.Normal);
                    imageSwitch = false;
                }
                
                else
                {
                    imgButton.SetImage(UIImage.FromFile("timg.jpg"), UIControlState.Normal);
                    imageSwitch = true;
                }
                
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}