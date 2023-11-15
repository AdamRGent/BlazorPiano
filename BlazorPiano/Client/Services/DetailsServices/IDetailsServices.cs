namespace BlazorPiano.Client.Services.DetailsServices
{
    public interface IDetailsServices
    {
        List<Details> Details { get; set; }
        Task GetDetails();
    }
}
