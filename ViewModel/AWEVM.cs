using aweAPI.Model;
using aweAPI.ViewModel.APIHelper;
using aweAPI.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aweAPI.ViewModel
{
    public class AWEVM : INotifyPropertyChanged
    {

        private string query;

        public string Query
        {
            get => query;
            set
            {
                query = value;
                OnpropertyChanged("Query");
            }
        }

        private Video video;
        public Video Video
        {
            get => video;
            set
            {
                video = value;
                OnpropertyChanged("Video");
            }
        }

        public ObservableCollection<Video> Videos { get; set; }

        public SearchCommand SearchCommand { get; set; }

        public AWEVM()
        {
            SearchCommand = new SearchCommand(this);
            Videos = new ObservableCollection<Video>();
        }

        public async void MakeQuery()
        {
            var videos = await Api.GetVideos(Query);
            Videos.Clear();

            foreach (var item in videos)
            {
                Videos.Add(item);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnpropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
