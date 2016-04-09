using UIKit;
using Cirrious.FluentLayouts.Touch;

namespace FluentLayoutDemo
{
    public partial class BlocksViewController : UIViewController
    {
        const int Margin = 5;
        const int Height = 40;
        const int StatusBarHeight = 30;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();     

            View.BackgroundColor = UIColor.Yellow;

            #region Define Views and Add as SubViews

            var blueBox = new UIView { BackgroundColor = UIColor.Blue };
            View.Add(blueBox);

            var redBox = new UIView { BackgroundColor = UIColor.Red };
            View.Add(redBox);

            var greenBox = new UIView { BackgroundColor = UIColor.Green };
            View.Add(greenBox);

            var magentaBox = new UIView { BackgroundColor = UIColor.Magenta };
            View.Add(magentaBox);

            var orangeBox = new UIView { BackgroundColor = UIColor.Orange };
            View.Add(orangeBox);

            #endregion

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            View.AddConstraints(

                blueBox.AtLeftOf(View).Plus(Margin),
                blueBox.AtTopOf(View).Plus(StatusBarHeight),
                blueBox.WithRelativeWidth(View, 0.5f), 
                blueBox.Height().EqualTo(Height),

                redBox.ToRightOf(blueBox).Plus(Margin),
                redBox.WithSameTop(blueBox),
                redBox.WithSameRight(View).Minus(Margin),
                redBox.WithSameHeight(blueBox),

                greenBox.Below(redBox).Plus(Margin),
                greenBox.WithSameLeft(View).Plus(Margin),
                greenBox.WithSameRight(View).Minus(Margin),
                greenBox.WithSameHeight(redBox),

                magentaBox.Below(greenBox).Plus(Margin),
                magentaBox.WithSameCenterX(View),
                magentaBox.WithRelativeWidth(View, 0.33f),
                magentaBox.WithSameHeight(greenBox),

                orangeBox.Below(magentaBox).Plus(Margin),
                orangeBox.WithSameLeft(greenBox),
                orangeBox.WithSameWidth(greenBox),
                orangeBox.WithSameBottom(View).Minus(Margin)

            );
        }
    }
}


