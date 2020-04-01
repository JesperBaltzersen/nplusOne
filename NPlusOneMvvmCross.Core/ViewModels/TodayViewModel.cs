using System;
using MvvmCross.ViewModels;

namespace NPlusOneMvvmCross.Core.ViewModels
{
    public class TodayViewModel : MvxViewModel
    {
        private string _labelText;
        public string LabelText
        {
            get => _labelText;
            set => SetProperty(ref _labelText, value);
        }

        private string _otherLabel;
        public string OtherLabel
        {
            get => _otherLabel;
            set => SetProperty(ref _otherLabel, value);
        }

        public TodayViewModel()
        {
            this.LabelText = @"It's that \n /n comming at ya!";

            this.OtherLabel = $"Got that sweet {nameof(TodayViewModel)}!";
        }
    }
}
