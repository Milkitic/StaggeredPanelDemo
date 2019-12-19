using System.ComponentModel;
using System.Runtime.CompilerServices;
using StaggeredPanelDemo.Annotations;

namespace StaggeredPanelDemo
{
    public class GalleryVm : INotifyPropertyChanged
    {
        private string _imagePath;

        public string ImagePath
        {
            get => _imagePath;
            set
            {
                if (value == _imagePath) return;
                _imagePath = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}