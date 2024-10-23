using Meteorologico.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Meteorologico.Services
{
    public class CidadeService
    {
        private HttpClient httpClient;
        private JsonSerializerOptions jsonSerializerOptions;
        public CidadeService()
        {
            httpClient = new HttpClient();
            jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public async Task<ObservableCollection<Cidades>> getCidade()
        {
            Uri uri = new Uri("https://jsonplaceholder.typicode.com/posts");
            ObservableCollection<Cidades> items = new ObservableCollection<Cidades>();
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    items = JsonSerializer.Deserialize<ObservableCollection<Cidades>>(content, jsonSerializerOptions);
                }
            }
            catch (Exception ex)
            {
            }
            return items;
        }

    }
}
