using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using StaggeredPanelDemo.Annotations;

namespace StaggeredPanelDemo
{
    public class MainWindowVm : INotifyPropertyChanged
    {
        private ObservableCollection<GalleryVm> _imageList = new ObservableCollection<GalleryVm>();

        public ObservableCollection<GalleryVm> ImageList
        {
            get => _imageList;
            set
            {
                if (Equals(value, _imageList)) return;
                _imageList = value;
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