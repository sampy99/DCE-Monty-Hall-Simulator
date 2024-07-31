using Microsoft.AspNetCore.Mvc;
using MontyHallSimulator.Models;
using MontyHallSimulator.Services;

namespace MontyHallSimulator.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class SimulationController : ControllerBase
    {
        private readonly MontyHallService _montyHallService;

        public SimulationController()
        {
            _montyHallService = new MontyHallService();
        }

        [HttpPost]
        public ActionResult<SimulationResult> Simulate(SimulationRequest request)
        {
            var result = _montyHallService.Simulate(request.NumSimulations, request.SwitchDoor);
            return Ok(result);
        }
    }
}
