using Microsoft.AspNetCore.Mvc;
using zuri_week_1.Model;
using zuri_week_1.Service;

namespace zuri_week_1.Controllers
{
    public class UserController : Controller
    {
        private readonly User User;
        private readonly IArithemeticOperations _arithemetic;

        public UserController(IArithemeticOperations arithemetic)
        {
            User = new User
            {
                SlackUsername = "Best Ogbeide",
                Backend = true,
                Age = 25,
                Bio = "HNG 9.0 Backend developer"
            };
            _arithemetic = arithemetic;
        }


        [HttpGet("get-user")]
        public IActionResult Get()
        {
            var user = User;
            return Ok(user);
        }
        [HttpPost("perform-basic-arithmetic-operations")]
        public IActionResult PerformArithmeticOperation([FromBody]InputDto input)
        {
            var result = _arithemetic.BasicOperation(input);
            if (result.Result==00)
            {
                return BadRequest("Invalid operation type! Operation can only be addition, multiplication, or subtraction.");
            }
            return Ok(result);
        }
    }
}
