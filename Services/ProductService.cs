
using Shared.Models;
using System.Net.Http.Json;

namespace ShoppingCart.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            // Si estás usando una API hospedada
            // return await _httpClient.GetFromJsonAsync<List<Product>>("api/products");

            // Si estás usando un archivo JSON local
            return await _httpClient.GetFromJsonAsync<List<Product>>("products.json");
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            // Si estás usando una API hospedada
            // return await _httpClient.GetFromJsonAsync<Product>($"api/products/{id}");

            // Si estás usando un archivo JSON local
            var products = await GetProductsAsync();
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}
