using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using System.Web.ModelBinding;
using CODEToad.Data.Models;
using NLog;
using NLog.Fluent;

namespace CODEToad.Data.Repository
{
    
    public class Repository:ICodeNote
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        CodeToadContext dbc=new CodeToadContext();
        public List<CodeNote> GetNotes()
        {
            return dbc.CodeNodes.ToList();
        }

        public bool AddNote(CodeNote note)
        {
            try
            {
                var rec = new CodeNote
                {
                    Title = note.Title,
                    Description = note.Description ?? string.Empty,
                    Snippet = note.Snippet ?? string.Empty,
                    URL = note.URL ?? string.Empty,
                    StatusCode = note.StatusCode = "A",
                    UpdateDate = note.UpdateDate = DateTime.Now
                };
                dbc.CodeNodes.Add(rec);
                dbc.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                return false;
            }
        }

        public bool DeleteNote(int noteId)
        {
            try
            {
                var note = dbc.CodeNodes.FirstOrDefault(x => x.CodeNoteId == noteId);
                if (note != null)
                {
                    dbc.CodeNodes.Remove(note);
                    dbc.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                return false;
            }
        }

        public bool UpdateNote(CodeNote note)
        {
            try
            {
                var rec = dbc.CodeNodes.FirstOrDefault(x => x.CodeNoteId == note.CodeNoteId);
                if (rec != null)
                {
                    var record = new CodeNote
                    {
                        CodeNoteId = note.CodeNoteId,
                        Title = note.Title,
                        Description = note.Description ?? string.Empty,
                        Snippet = note.Snippet ?? string.Empty,
                        URL = note.URL ?? string.Empty,
                        StatusCode = note.StatusCode = "A",
                        UpdateDate = note.UpdateDate = DateTime.Now
                    };
                    dbc.CodeNodes.AddOrUpdate(record);
                    dbc.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                return false;
            }
        }
    }
}
