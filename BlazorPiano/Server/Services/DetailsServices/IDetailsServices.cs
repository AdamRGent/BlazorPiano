namespace BlazorPiano.Server.Services.DetailsServices
{
    public interface IDetailsServices
    {
        Task<ServiceResponse<List<Details>>> GetDetails();
    }
}
