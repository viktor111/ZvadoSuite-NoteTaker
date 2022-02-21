using NoteTaker.Models.Notes;
using NoteTaker.Persistance;
using NoteTaker.Persistance.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class Main : Form
    {        
        public Main()
        {
            InitializeComponent();
        }

        public async void RefreshNotes()
        {
            await this.LoadInitialNotes();
        }

        public async void Main_Load(object sender, EventArgs e)
        {
            await this.LoadInitialNotes();
        }

        public async Task LoadInitialNotes()
        {
            var dbContext = new NoteTakerDbContext();
            var noteDb = new NoteSqlService(dbContext);            

            var notes = await noteDb.All();

            NotesListView.Items.Clear();

            for (int i = 0; i < notes.Count; i++)
            {
                var note = notes[i];

                var row = new string[] { note.Title, note.Id.ToString() };

                var listViewItem = new ListViewItem(row);

                NotesListView.Items.Add(listViewItem);
            }
        }

        private async void NotesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var firstSelectedItem = NotesListView.SelectedItems[0];
            var secondSelctedItem = firstSelectedItem.SubItems[1];
            var id = Convert.ToInt32(secondSelctedItem.Text);

            var dbContext = new NoteTakerDbContext();
            var noteDb = new NoteSqlService(dbContext);

            var note = await noteDb.Get(id);

            var noteDetailsForm = new NoteDetails(note);

            noteDetailsForm.Show(this);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var dbContext = new NoteTakerDbContext();
            var noteDb = new NoteSqlService(dbContext);

            await noteDb.Create(new Note("Title for note", "Text for note"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var noteDetailsForm = new NoteDetails();

            noteDetailsForm.Show(this);
        }

        private async void SortButton_Click(object sender, EventArgs e)
        {
            var dbContext = new NoteTakerDbContext();
            var noteDb = new NoteSqlService(dbContext);

            var fromDate = FromDateTimePicker.Value;

            var notes = await noteDb.All();


            NotesListView.Items.Clear();

            for (int i = 0; i < notes.Count; i++)
            {
                var note = notes[i];

                var row = new string[] { note.Title, note.Id.ToString() };

                var listViewItem = new ListViewItem(row);
                if (note.CreatedOn.ToString("MM/dd/yyyy") == fromDate.ToString("MM/dd/yyyy"))
                {
                    NotesListView.Items.Add(listViewItem);
                }                
            }
        }
    }
}
