using System.Net.Http.Json;
using UdlaLife.Models;

namespace UdlaLife.Services;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService()
    {
        _httpClient = new HttpClient { BaseAddress = new Uri("https://tuapiurl.com/api/") };
    }

    public async Task<List<Estudiante>> GetEstudiantesAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Estudiante>>("Estudiantes");
    }
}
