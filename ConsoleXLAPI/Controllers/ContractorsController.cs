using ConsoleXLAPI.Models;
using ConsoleXLAPI.Utils.Request;
using ConsoleXLAPI.XLControllers;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleXLAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContractorsController : ControllerBase
    {

        private readonly ILogger<ContractorsController> _logger;

        XLContractorsController XLContractors { get; set; }
        public ContractorsController(ILogger<ContractorsController> logger, XLContractorsController xLContractorsController)
        {
            _logger = logger;
            XLContractors = xLContractorsController;
        }

        [HttpPut("Add", Name = "AddContractors")]
        public async Task<ActionResult<OutputMessage>> AddMore([FromBody] ContractorRequest response)
        {
            response.DateTime = DateTime.Now;
            try
            {
                if (response.Json.Any())
                {
                    response.PipeName = "AddContractors";
                    OutputMessage? result = await response.SendData();
                    if (result == null)
                        return NotFound();
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("AddSQL", Name = "AddContractorsSQL")]
        public async Task<ActionResult<OutputMessage>> AddMoreSQL([FromBody] ContractorSQLRequest response)
        {
            response.DateTime = DateTime.Now;
            try
            {
                if (response.Json.Any())
                {
                    response.PipeName = "AddContractorsSQL";
                    OutputMessage? result = await response.SendData();

                    if (result == null)
                    {
                        return NotFound();
                    }
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("Get/{Guid}")]
        public async Task<ActionResult<OutputMessage>> GetSingle(Guid guid)
        {
            try
            {
                return Ok("do implementacji jako SQL w aplikacji API a nie w konsolowej XL- rozwa¿yæ implementacje SQL w konsolowej gdzie przekazuje siê string do pobranai wartosci");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}