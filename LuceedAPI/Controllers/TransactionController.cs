using LuceedAPI.Http;
using LuceedAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LuceedAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private ICustomHttpClient customClient;
        public TransactionController(ICustomHttpClient _customClient)
        {
            customClient = _customClient;
        }

        [HttpGet("paymentType/{bu}/{from}/{to?}")]
        public async Task<IActionResult> GetByPaymentType(string bu, string from, string? to = null)
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

        [HttpGet("product/{bu}/{from}/{to?}")]
        public async Task<IActionResult> GetByProduct(string bu, string from, string? to = null)
        {
            try
            {
                string apiUrl = $"http://apidemo.luceed.hr/datasnap/rest/mpobracun/artikli/{bu}/{from}";

                if (!string.IsNullOrEmpty(to))
                {
                    apiUrl += $"/{to}";
                }

                var response = await customClient.OnGet(apiUrl);
                response.EnsureSuccessStatusCode();

                var resBody = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<LuceedTransactionProductResponse>(resBody);

                return Ok(result.Result[0].ObracunArtikli);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
