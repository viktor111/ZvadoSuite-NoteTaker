namespace NoteTaker.Models.Notes
{
    using NoteTaker.Models.Exceptions;

    public class Note
    {
        internal Note( string title, string text)
        {
            this.Validate(title, text);

            this.Title = title;
            this.Text = text;
        }

        private Note(string title, DateTime createdOn, string text)
        {
            this.Title = title;
            this.CreatedOn = DateTime.Now;
            this.Text = text;
        }

        public int Id { get; set; }

        public string Title { get; private set; }

        public DateTime CreatedOn { get; private set; } = DateTime.UtcNow;

        public string Text { get; private set; }

        public Note UpdateTitle(string title)
        {
            this.ValidateTitle(title);
            this.Title = title;
            return this;
        }
        public Note UpdateText(string text)
        {
            this.ValidateText(text);
            this.Text = text;
            return this;
        }

        private void Validate(string title, string text)
        {
            this.ValidateTitle(title);
            this.ValidateText(text);
        }

        private void ValidateTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new InvalidNoteException("Title can't be null or empty");
            }
            if(title.Length > 50)
            {
                throw new InvalidNoteException("Title can't be above 50 in length");
            }
        }

        private void ValidateText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new InvalidNoteException("Text can't be null or empty");
            }
        }
    }
}
