
using Csharp_Seat_Booking_System.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Csharp_Seat_Booking_System.Services
{
    public class JsonFileProductService
    {
        //find wwwroot
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        //combine wwwroot + /data/products.json
        private string JsonFileName // get the products.json file.
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
        }


        //deserialize the .json file into a .Net object.(an IEnumerable(list, arrays etc). we can loop through.
        public IEnumerable<Product> GetProducts()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

            }
        }

        public void AddRating(string ProductId, int rating)
        {
            //get all products
            var products = GetProducts();
            // query a specific product by id.
            var query = products.First(x => x.Id == ProductId);
            if (query.Ratings == null)
            {
                query.Ratings = new int[] { rating };
            }
            else
            {
                var ratings = query.Ratings.ToList();
                ratings.Add(rating);
                query.Ratings = ratings.ToArray();// overridie the old array with the newly updated array.
            }

            // writing on the json file, in the Product models format.
            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Product>>(
                   new Utf8JsonWriter(outputStream, new JsonWriterOptions
                   {
                       SkipValidation = true,
                       Indented = true
                   }), products
                   );
            }

        }
    }
}