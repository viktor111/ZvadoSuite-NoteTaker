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
    public partial class NoteDetails : Form
    {
        private readonly Note note;

        public NoteDetails(Note note)
        {
            InitializeComponent();

            this.note = note;
        }

        public NoteDetails()
        {
            InitializeComponent();
        }

        private void NoteDetails_Load(object sender, EventArgs e)
        {
            if (note != null)
            {
                this.LoadNoteData();
                CreateButton.Hide();
            }
            else
            {
                EditButton.Hide();
                DeleteButton.Hide();
                DateCreatedOnLabel.Text = DateTime.Now.ToString("MM/dd/yyyy");
            }
        }

        private void LoadNoteData()
        {
            NoteTextTextBox.Text = note.Text;
            TitleTextBox.Text = note.Title;
            DateCreatedOnLabel.Text = note.CreatedOn.ToString("MM/dd/yyyy");
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            var dbContext = new NoteTakerDbContext();
            var noteDb = new NoteSqlService(dbContext);

            var title = TitleTextBox.Text;
            var text = NoteTextTextBox.Text;

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Can't have empty title");
                return;
            }
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Can't have empty text");
                return;
            }

            var newNote = note.UpdateTitle(title).UpdateText(text);

            await noteDb.Edit(newNote);

            var main = Owner as Main;

            main.Main_Load(sender, e);
            this.Close();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var dbContext = new NoteTakerDbContext();
            var noteDb = new NoteSqlService(dbContext);

            await noteDb.Delete(note.Id);

            var main = Owner as Main;

            main.Main_Load(sender, e);
            this.Close();
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            var dbContext = new NoteTakerDbContext();
            var noteDb = new NoteSqlService(dbContext);

            var title = TitleTextBox.Text;
            var text = NoteTextTextBox.Text;

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Can't have empty title");
                return;
            }
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Can't have empty text");
                return;
            }

            await noteDb.Create(new Note(title, text));

            var main = Owner as Main;

            main.Main_Load(sender, e);
            this.Close();
        }
    }
}
