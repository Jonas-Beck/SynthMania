using System.Net.Http.Json;
using SynthMania.Models;

namespace SynthMania.Services;

public class ProductService
{
   private const string URL = "https://localhost:7137/";

   public async Task<IEnumerable<Product>> GetAllProducts()
   {
      using (HttpClient client = new())
      {
         client.BaseAddress = new Uri(URL);

         var response = await client.GetFromJsonAsync<IEnumerable<Product>>("api/Product");

         return response;
         
      }
   }
}