using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using AttributeRouting.Web.Http;
using CODEToad.Data;

namespace CODEToad.API.Controllers
{
    public class CodeToadController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        [Route("api/notes")]
        public IEnumerable<CodeNotes> Get()
        {
            var retVal = new List<CodeNotes>();
            try
            {
                
                var c = new CodeToadModel();
                retVal = c.CodeNodeList.ToList();
                return retVal;
            }
            catch (Exception ex)
            {
                return retVal;
            }
        }

        [HttpGet]
        [Route("api/notes/{noteid:int}")]
        public CodeNotes Get(int noteid)
        {
            var retVal = new CodeNotes();
            try
            {

                var c = new CodeToadModel();
                retVal = c.CodeNodeList.FirstOrDefault(x=>x.CodeNoteId==noteid);
                return retVal;
            }
            catch (Exception ex)
            {
                return retVal;
            }
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}