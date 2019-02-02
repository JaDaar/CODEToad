using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using AttributeRouting.Web.Http;
using CODEToad.Data;
using CODEToad.Data.Models;
using CODEToad.Data.Repository;

namespace CODEToad.API.Controllers
{
    public class CodeToadController : ApiController
    {
        private Repository repo;
        public CodeToadController()
        {
            repo = new Repository();
        }
        // GET api/<controller>
        [HttpGet]
        [Route("api/notes")]
        public IEnumerable<CodeNote> Get()
        {
            var retVal = new List<CodeNote>();
            try
            {
                
                var repo = new CodeToadContext();
                retVal = repo.CodeNodes.ToList();
                return retVal;
            }
            catch (Exception)
            {
                return retVal;
            }
        }

        [HttpGet]
        [Route("api/notes/{noteid:int}")]
        public CodeNote Get(int noteid)
        {
            var retVal = new CodeNote();
            try
            {
                retVal = repo.GetNotes().FirstOrDefault(x=>x.CodeNoteId==noteid);
                return retVal;
            }
            catch (Exception)
            {
                return retVal;
            }
        }

        // POST api/<controller>
        [HttpPost]
        [Route("api/notes")]
        public bool Post([FromBody]CodeNote note)
        {
            bool retVal = false;
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                if (string.IsNullOrWhiteSpace(note.Title))
                    return retVal;
                retVal=repo.AddNote(note);
                return retVal;
            }
            catch (Exception)
            {

                return retVal;
            }
        }

        [HttpPost]
        [Route("api/notes/update/")]
        public bool Update([FromBody]CodeNote note)
        {
            bool retVal = false;
            try
            {
                if (!ModelState.IsValid)
                {
                    return false;
                }
                if (string.IsNullOrWhiteSpace(note.Title))
                    return retVal;
                retVal = repo.UpdateNote(note);
                return retVal;
            }
            catch (Exception)
            {
                return retVal;
            }
        }

        [HttpPut]
        [Route("api/notes/delete/{noteid:int}")]
        public bool Put(int noteid)
        {
            bool retVal = false;
            try
            {
                retVal = repo.DeleteNote(noteid);
                return retVal;
            }
            catch (Exception)
            {
                return retVal;
            }
        }
    }
}