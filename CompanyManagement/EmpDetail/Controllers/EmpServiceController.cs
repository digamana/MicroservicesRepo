using Microsoft.AspNetCore.Mvc;
namespace EmpDetail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpServiceController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<EmpModel> Get()
        {
            EmpModel attendanceObj1 = new EmpModel();
            EmpModel attendanceObj2 = new EmpModel();
            attendanceObj1.EmpID = 1;
            attendanceObj1.EmpName = "Adam";
            attendanceObj1.AttendencePercentage = 83.02;
            attendanceObj2.EmpID = 2;
            attendanceObj2.EmpName = "Brad";
            attendanceObj2.AttendencePercentage = 71.02;
            List<EmpModel> listObj = new List<EmpModel>
            {
                attendanceObj1,
                attendanceObj2
            };
            return listObj;
        }
    }
}
