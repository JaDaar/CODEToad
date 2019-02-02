using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CODEToad.Data.Models;

namespace CODEToad.Data.Repository
{
    public interface ICodeNote
    {
        List<CodeNote> GetNotes();
        bool AddNote(CodeNote note);
        bool UpdateNote(CodeNote note);
        bool DeleteNote(int noteId);
        //CodeNote FindNote(SearchNote searchNote);
    }
}
