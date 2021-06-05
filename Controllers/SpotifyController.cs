using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Text.Json;
using plantitas.DTO;

namespace plantitas.Controllers
{
    public class SpotifyController : Controller
    {

        private const string URL_API_SPOTIFY = "https://api.spotify.com/v1/";
        private const string ACCESS_TOKEN ="BQA2mKLwJkBOIXYMED5rBVt1tzIR5nYQ3xoS5UReUn2L9oh07PvcOz4InZN2m-57T1vKSJX8ry5QxfX0Uxpq31vUXd_kicZVxZh1fmvVL_McLIg_k146dYnYZBTw5N7C0Omh5v8AOcD4AMLXcqShcOw9ASDlVOEAZBUbRT4Ra0Q98kCNAbG1CfGhGxatu7t2IYvRZQzjYQb1VixrvyHpg8tvt_3kkU6CyUPz7jpnlqVM3ymvK8Ulq60fSVtMXTjGdJUCbHdmWJNnGPF8kXJn8w";

        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.BaseAddress = new Uri(URL_API_SPOTIFY);
             httpClient.DefaultRequestHeaders.Authorization = 
                new AuthenticationHeaderValue("Bearer", ACCESS_TOKEN);
            var streamTask = httpClient.GetStreamAsync( "users/12153957956");
            var me = await JsonSerializer.DeserializeAsync<UserSpotify>(await streamTask);                
            return View(me);
        }
    }
}