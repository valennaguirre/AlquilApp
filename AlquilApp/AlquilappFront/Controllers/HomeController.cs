using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private readonly HttpClient _httpClient;

    public HomeController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("AlquilappApi");
    }

    public async Task<IActionResult> Index()
    {
        string mensaje = await _httpClient.GetStringAsync("api/saludo"); // Ruta relativa al backend
        ViewBag.Mensaje = mensaje;
        return View();
    }
}
