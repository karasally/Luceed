using LuceedAPI.Http;
using LuceedAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


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
