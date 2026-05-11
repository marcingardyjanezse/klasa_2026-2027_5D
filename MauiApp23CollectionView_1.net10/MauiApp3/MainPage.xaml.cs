using System.Collections.ObjectModel;

namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> AllNotes { get; set; }

        public string Note
        {
            get => field;
            set
            {
                field = value;
                OnPropertyChanged();
            }
        }

        public string SelectedNote { get; set; }

        public MainPage()
        {
            AllNotes = new ObservableCollection<string>();

            AllNotes.Add("todo 1");
            AllNotes.Add("todo 2");

            InitializeComponent();
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            AllNotes.Add(Note);           
            Note = String.Empty;
        }

        private void RemoveButtonClicked(object sender, EventArgs e)
        {
            AllNotes.Remove(SelectedNote);
        }
    }
}
