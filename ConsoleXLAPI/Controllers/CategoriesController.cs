using ConsoleXLAPI.Models;
using ConsoleXLAPI.Utils.Request;
using ConsoleXLAPI.XLControllers;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleXLAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ILogger<CategoriesController> _logger;
        XLCategoriesController XLCategories { get; set; }




        public CategoriesController(ILogger<CategoriesController> logger, XLCategoriesController xLCategoriesController)
        {
            _logger = logger;
            XLCategories = xLCategoriesController;
            //   test();
        }

        [HttpPut("Add", Name = "AddCategories")]  //, Name = "Add contractors")]
        public async Task<ActionResult<OutputMessage>> AddMore([FromBody] CategoriesRequest response)
        {
            response.DateTime = DateTime.Now;
            try
            {
                if (response.Json.Any())
                {
                    response.PipeName = "AddCategories";
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

        [HttpGet("Get/{Guid}")] //, Name = "Get single Element by Guid")]
        public async Task<ActionResult<OutputMessage>> GetSingle(string guid)
        {
            try
            {
                if (Guid.TryParse(guid, out Guid guidResult))
                {
                    //response.PipeName = "GetSingleCat";
                    //OutputMessage? result = await response.SendData();
                    // to powinno byæ realizowane za pomoc¹ SQL i Connection string w API

                    // var result = "";// await XLController.TaskRun(new ContractorResponse() { MethodName = Enums.MethodName.AddOrChangeCommodity });
                    //   OutputMessage result = await SendRequestToConsoleApp(response, "GetSinglecAT");

                    //if (result == null)
                    //{
                    //    return await OutputMessage.BadGuid(guid, $"Nie znaleziono danych dla GUID: {guid}");
                    //}
                    //return Ok(result);
                    return Ok("do implementacji jako SQL w aplikacji API a nie w konsolowej XL- rozwa¿yæ implementacje SQL w konsolowej gdzie przekazuje siê string do pobranai wartosci");

                }
                else
                {
                    return await OutputMessage.BadGuid(guid, "Niepoprawny format GUID");
                }

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]//("Get All Contractors")]
        public async Task<ActionResult<OutputMessage>> GetAll()
        {
            try
            {//GET NIE POTRZEBUJE RESPONSE

                //OutputMessage result = await SendRequestToConsoleApp("", "GetAllCat");
                //

                //var result = await OutputMessage.ResultOk(nameof(GetAll) + "" + nameof(CategoriesController), "");//await XLController.TaskRun(new ConsoleXLAPI.ContractorResponse() { });

                return Ok("do implementacji jako SQL w aplikacji API a nie w konsolowej XL- rozwa¿yæ implementacje SQL w konsolowej gdzie przekazuje siê string do pobranai wartosci");

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}