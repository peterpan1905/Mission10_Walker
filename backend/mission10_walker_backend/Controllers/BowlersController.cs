using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mission10_walker_backend.Data;

namespace mission10_walker_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlersController(IBowlerRepository temp) {
            _bowlerRepository = temp;
        }
        [HttpGet]
        public IEnumerable<object> Get()
        {
            var bowlerData = _bowlerRepository.GetBowlersWithTeam()
                             .Where(b => b.Teams.TeamName == "Marlins" || b.Teams.TeamName == "Sharks")
                             .Select(b => new
                             {
                                 BowlerID = b.BowlerID,
                                 BowlerFirstName = b.BowlerFirstName,
                                 BowlerMiddleInit = b.BowlerMiddleInit,
                                 BowlerLastName = b.BowlerLastName,
                                 TeamName = b.Teams?.TeamName,
                                 BowlerAddress = b.BowlerAddress,
                                 BowlerCity = b.BowlerCity,
                                 BowlerState = b.BowlerState,
                                 BowlerZip = b.BowlerZip,
                                 BowlerPhoneNumber = b.BowlerPhoneNumber
                             });

            var bowlerArray = bowlerData.ToArray();

            return bowlerArray;
        }
    }
}
