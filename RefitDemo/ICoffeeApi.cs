using Refit;

namespace RefitDemo
{
    public interface ICoffeeApi
    {
        [Get("/coffee/hot")]
        Task<List<Coffee>> GetCoffeeDetailsAsync();
    }
}
