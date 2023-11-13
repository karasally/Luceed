using LuceedAPI.Http;
using LuceedAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LuceedAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors()]
    public class ArticleController : ControllerBase
    {
        private ICustomHttpClient customClient;

        public ArticleController(ICustomHttpClient _customClient)
        {
            customClient = _customClient;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            try
            {
                var response = await customClient.OnGet($"http://apidemo.luceed.hr/datasnap/rest/artikli/naziv/{name}");
                response.EnsureSuccessStatusCode();

                var resBody = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<LuceedArticleResponse>(resBody);

                return Ok(result.Result[0].Artikli);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var response = await customClient.OnGet("http://apidemo.luceed.hr/datasnap/rest/artikli/naziv");
                response.EnsureSuccessStatusCode();

                var resBody = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<LuceedArticleResponse>(resBody);

                return Ok(result.Result[0].Artikli);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




    }
}
