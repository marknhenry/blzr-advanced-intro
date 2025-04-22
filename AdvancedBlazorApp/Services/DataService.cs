using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AdvancedBlazorApp.Services
{
    public class DataService
    {
        public async Task<List<string>> GetProductsAsync()
        {
            await Task.Delay(500); // Simulate a delay for data fetching
            return new List<string> {"Product 1", "Product 2", "Product 3" };
        }
    }
}