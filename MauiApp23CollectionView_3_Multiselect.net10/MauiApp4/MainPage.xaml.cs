using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Note> AllNotes { get; set; }

        public Note Note
        {
            get => field;
            set
            {
                field = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            AllNotes = new ObservableCollection<Note>();

            AllNotes.Add(new Note("todo 1", 1));
            AllNotes.Add(new Note("todo 2", 2));

            Note = new Note("", 0);

            InitializeComponent();
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            AllNotes.Add(Note);
            Note = new Note("", 0);
        }

        private void RemoveButtonClicked(object sender, EventArgs e)
        {
            var toDelList = TodoList.SelectedItems.ToList();

            foreach (var selected in toDelList)
            {
                AllNotes.Remove((Note)selected);
            }
        }
    }

    public class Note
    {
        public int Priority { get; set; }
        public string Text {  get; set; }

        public Note(string text, int priority)
        {
            Priority = priority;
            Text = text;
        }
    }

}
