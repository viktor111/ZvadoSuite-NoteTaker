namespace NoteTaker.Persistance.Services
{
    using Microsoft.EntityFrameworkCore;
    using Models.Notes;
    using System.Linq.Expressions;

    public class NoteSqlService
    {
        private readonly NoteTakerDbContext dbContext;

        public NoteSqlService(NoteTakerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Note> Create(Note note)
        {
            await dbContext.Notes.AddAsync(note);
            await dbContext.SaveChangesAsync();

            return note;
        }

        public async Task<Note> Edit(Note note)
        {
            var noteToEdit = await dbContext.Notes.FirstOrDefaultAsync(x => x.Id == note.Id);

            if (noteToEdit == null)
            {
                throw new Exception("Note null in " + nameof(Edit));
            }

            noteToEdit.UpdateTitle(note.Title);
            noteToEdit.UpdateText(note.Text);

            await dbContext.SaveChangesAsync();

            return noteToEdit;
        }

        public async Task Delete(int id)
        {
            var note = await dbContext.Notes.FirstOrDefaultAsync(x => x.Id == id);

            if (note == null)
            {
                throw new Exception("Note null in " + nameof(Delete));
            }

            dbContext.Notes.Remove(note);

            await dbContext.SaveChangesAsync();
        }

        public async Task<Note> Get(int id)
        {
            var note = await dbContext.Notes.FirstOrDefaultAsync(x => x.Id == id);

            if (note == null)
            {
                throw new Exception("Note null in " + nameof(Get));
            }

            return note;
        }

        public async Task<List<Note>> All()
        {
            return await dbContext.Notes.ToListAsync();
        }

        public async Task<List<Note>> FindMany(Expression<Func<Note, bool>> predicate)
        {
            var result = await dbContext.Notes.Where(predicate).ToListAsync();

            if(result == null)
            {
                throw new Exception("Notes null in " + nameof(FindMany));
            }

            return result;
        }

        public async Task<Note> FindOne(Expression<Func<Note, bool>> predicate)
        {
            var result = await dbContext.Notes.FirstOrDefaultAsync(predicate);

            if (result == null)
            {
                throw new Exception("Notes null in " + nameof(FindOne));
            }

            return result;
        }
    }
}
