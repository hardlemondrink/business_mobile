using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using business_mobile.Models;

namespace business_mobile.Data
{
    public class NoteDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public NoteDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Note>().Wait();
        }
        public Task<List<Note>> GetNotesAsync(string id)
        {
            return _database.Table<Note>().Where(i => i.UserID == id).ToListAsync();
        }
        public Task<List<Note>> GetNotesAsync(bool Processed)
        {
            return _database.Table<Note>().Where(i => i.Processed == Processed).ToListAsync();
        }
        public Task<List<Note>> GetNotesAsync()
        {
            return _database.Table<Note>().ToListAsync();
        }
        public Task<Note> GetNoteAsync(string id)
        {
            return _database.Table<Note>()
                .Where(i => i.UserID == id)
                .FirstOrDefaultAsync();
        }
        public Task<int> SaveNoteAsync(Note note)
        {
            if(note.TaskID != null)
            {
                return _database.UpdateAsync(note);
            }
            else
            {
                return _database.InsertAsync(note);
            }
        }
        public Task<int> DeleteNoteAsync(Note note)
        {
            return _database.DeleteAsync(note);
        }
    }
}
