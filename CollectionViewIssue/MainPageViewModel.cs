using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CollectionViewIssue
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            PropertyChanged += MainPageViewModel_PropertyChanged;
            Images = new List<string>
            {
                "bg_blue",
                "bg_brown",
                "bg_green",
                "bg_grey",
                "bg_pink",
                "bg_purple",
                "bg_yellow",
            };
        }

        private void MainPageViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public List<string> Images { get; set; }
    }
}
