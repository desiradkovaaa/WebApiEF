using Microsoft.AspNetCore.Mvc;
using WebApplication3.Services;
using WebApplication3.Models.education;

namespace WebApplication3.Controllers
{
   
    [ApiController]
    [Route("[controller]")]
    public class EducationalFController : GenericController<EducationalForm>
    {
        public EducationalFController (GenericService<EducationalForm> service) : base(service)
        {
        }
    }
}