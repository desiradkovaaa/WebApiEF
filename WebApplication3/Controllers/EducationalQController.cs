using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models.education;
using WebApplication3.Services;

namespace WebApplication3.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EducationalQController : GenericController<EducationalQualification>
    {
        public EducationalQController(GenericService<EducationalQualification> service) : base(service)
        {
        }
    }
}