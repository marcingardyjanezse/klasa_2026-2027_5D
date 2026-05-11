using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Note> AllNotes { get; set; }

        public Command AddCommand { get; set; }
        public Command DeleteSelectedCommand { get; set; }

        public Command DeleteSingleCommand { get; set; }

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

            AddCommand = new Command(AddNote);
            DeleteSelectedCommand = new Command(DeleteSelected);
            DeleteSingleCommand = new Command<Note>(Delete);

            InitializeComponent();
        }

        void AddNote()
        {
            AllNotes.Add(Note);
            Note = new Note("", 0);
        }

        void DeleteSelected()
        {
            var toDelList = TodoList.SelectedItems.ToList();

            foreach (var selected in toDelList)
            {
                AllNotes.Remove((Note)selected);
            }
        }

        void Delete(Note note)
        {
            AllNotes.Remove(note);
        }
    }

    public class Note
    {
        public int Priority { get; set; }
        public string Text { get; set; }

        public Note(string text, int priority)
        {
            Priority = priority;
            Text = text;
        }
    }

}
