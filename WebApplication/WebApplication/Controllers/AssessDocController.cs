using App.BusinessService.IService;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssessDocController : ControllerBase
    {
        private readonly IAssessDocService _service;

        public AssessDocController(IAssessDocService service)
        {
            _service = service;
        }


        // GET: api/AssessDoc/5
        [HttpGet("{id}", Name = "Get")]
        public object GetDoc(string id)
        {
           return _service.GetById(id);
        }

        // POST: api/AssessDoc
        [HttpPost]
        public void PostDoc(string id)
        {
            _service.ProductPDF(id);
        }

        // PUT: api/AssessDoc/5
        [HttpPut("{id}")]
        public void PutDoc(string id)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteDoc(string id)
        {
        }
    }
}
