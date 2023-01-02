using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyServiceController : ControllerBase
    {
        // GET: api/<StudentAdmissionController>
        [HttpGet]
        public IEnumerable<CompanyModel> Get()
        {
            CompanyModel admissionobj1 = new CompanyModel();
            CompanyModel admissionobj2 = new CompanyModel();
            admissionobj1.CompanyID = 1;
            admissionobj1.CompanyName = "HI";
            admissionobj1.CompanyClass = "X";
            admissionobj1.DateofJoining = DateTime.Now;
            admissionobj2.CompanyID = 2;
            admissionobj2.CompanyName = "Jay";
            admissionobj2.CompanyClass = "V";
            admissionobj2.DateofJoining = DateTime.Now;
            List<CompanyModel> listofobj = new List<CompanyModel>
            {
                admissionobj1,
                admissionobj2
            };
            return listofobj;
        }
    }
}
