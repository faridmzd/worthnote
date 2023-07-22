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

        void Delete(int id);

        Note Update(Note newNote);
            
        Note Create(Note note);
    }
}
