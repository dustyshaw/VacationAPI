namespace VacationAPI.Services
{
    public interface IForcastService
    {
        Task<WeatherForecast> GetForcastByDate(DateTime date);
        Task<IEnumerable<WeatherForecast>> GetAllForecasts();
        
    }
}
