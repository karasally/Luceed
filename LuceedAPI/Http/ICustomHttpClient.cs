namespace LuceedAPI.Http
{
    public interface ICustomHttpClient
    {
        Task<HttpResponseMessage> OnGet(string url);
    }
}
