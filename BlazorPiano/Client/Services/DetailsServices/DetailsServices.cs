namespace BlazorPiano.Client.Services.DetailsServices
{
    public class DetailsServices : IDetailsServices
    {
        private readonly HttpClient _http;

        public DetailsServices(HttpClient http)
        {
            _http = http;
        }

        
        public List<Details> Details { get ; set ; } = new List<Details>();

        public async Task GetDetails()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Details>>>("api/Details");
            if (response != null && response.Data != null) 
            Details = response.Data;
        }
    }
}
