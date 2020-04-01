using System;
using System.Diagnostics;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using NPlusOneMvvmCross.Core.ViewModels;
using UIKit;

namespace NPlusOneMvvmCross.iOS.Views
{
    //[MvxRootPresentation(WrapInNavigationController = false)]
    public class TodayView : MvxViewController
    {
        public TodayView() : base(nameof(TodayView), null) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.White;

            Initialize();
        }

        private void Initialize()
        {
            var label = new UILabel()
            {
                //Text = "I got it",
                Font = UIFont.FromName(name: "Helvetica", size: 22)
            };
            label.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor, 0).Active = true;
            label.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor, 0).Active = true;
            label.WidthAnchor.ConstraintEqualTo(View.Frame.Width / 2).Active = true;
            label.HeightAnchor.ConstraintEqualTo(60).Active = true;
            Add(label);

            var otherLabel = new UILabel()
            {
                //Text = "I got it",
                Font = UIFont.FromName(name: "Helvetica", size: 22)
            };
            otherLabel.TopAnchor.ConstraintEqualTo(label.BottomAnchor, 10).Active = true;
            //otherLabel.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor, 0).Active = true;
            otherLabel.WidthAnchor.ConstraintEqualTo(View.Frame.Width / 2).Active = true;
            otherLabel.HeightAnchor.ConstraintEqualTo(60).Active = true;
            Add(otherLabel);


            var set = this.CreateBindingSet<TodayView, TodayViewModel>();
            set.Bind(label).For("Text").To("LabelText");
            set.Bind(otherLabel).To(v => v.OtherLabel);
            set.Apply();

            Debug.WriteLine(otherLabel.Frame.ToString());
        }
    }
}
