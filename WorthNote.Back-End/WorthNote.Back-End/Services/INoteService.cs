using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorthNote.Back_End.Models;

namespace WorthNote.Back_End.Services
{
    public interface INoteService
    {
        Note GetNote(int id);

        List<Note> GetAllNotes();

        void DeleteNote(int id);

        Note UpdateNote(Note newNote);
            
        Note CreateNote(Note note);
    }
}
