using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorthNote.Back_End.Models;

namespace WorthNote.Back_End.Services
{
    public class NoteService : INoteService
    {
        static List<Note> notes = new();
        public Note CreateNote(Note note)
        {
            notes.Add(note);
            return notes.Last();
        }

        public void DeleteNote(int id)
        {
            throw new NotImplementedException();
        }

        public Note GetNote(int id)
        {
            return notes.Where(note => note.Id == id).LastOrDefault();
        }

        public Note UpdateNote(Note newNote)
        {
            throw new NotImplementedException();
        }
    }
}
