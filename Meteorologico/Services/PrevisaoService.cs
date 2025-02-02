﻿using Meteorologico.Provisorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Meteorologico.Services
{
    public class PrevisaoService
    {
        private HttpClient httpClient;
        private JsonSerializerOptions jsonSerializerOptions;
        public PrevisaoService()
        {
            httpClient = new HttpClient();
            jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public async Task<Previsoes> getPost()
        {
            Uri uri = new Uri("https://jsonplaceholder.typicode.com/posts");
            Previsoes items = new Previsoes();
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    items = JsonSerializer.Deserialize<Previsoes>(content, jsonSerializerOptions);
                }
            }
            catch (Exception ex)
            {
            }
            return items;
        }

    }
}


