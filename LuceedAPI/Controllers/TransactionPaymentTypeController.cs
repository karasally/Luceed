using LuceedAPI.Http;
using LuceedAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


namespace LuceedAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionPaymentTypeController : ControllerBase
    {
        private ICustomHttpClient customClient;
        public TransactionPaymentTypeController(ICustomHttpClient _customClient)
        {
            customClient = _customClient;
        }

        [HttpGet("{bu}/{from}/{to?}")]
        public async Task<IActionResult> GetByDate(string bu, string from, string? to = null)
        {
            try
            {
                string apiUrl = $"http://apidemo.luceed.hr/datasnap/rest/mpobracun/placanja/{bu}/{from}";

                if (!string.IsNullOrEmpty(to))
                {
                    apiUrl += $"/{to}";
                }

                var response = await customClient.OnGet(apiUrl);
                response.EnsureSuccessStatusCode();

                var resBody = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<LuceedTransactionPaymentTypeResponse>(resBody);

                return Ok(result.Result[0].ObracunPlacanja);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
