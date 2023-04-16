using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TestMobile.Api.Models.Domain;
using Xamarin.Android.Net;

namespace TestMobile.Api;

public class Api
{
    private readonly string _baseAddress = "http://192.168.1.47:5065";

    private HttpClient GetHttpClient()
    {
        return new HttpClient(new AndroidClientHandler());
    }

    public async Task<bool> Login(string code)
    {
        var url = _baseAddress + "/api/Worker/Login?code=" + code;
        
        var client = GetHttpClient();
        client.DefaultRequestHeaders.Clear();

        var result = await client.PostAsync(new Uri(url), null);

        return result.IsSuccessStatusCode;
    }
    
    public async Task<List<PassDomain>> GetPasses()
    {
        var url = _baseAddress + "/api/Pass/GetPasses";

        var client = GetHttpClient();

        var res = await client.GetStringAsync(url);

        return JsonSerializer.Deserialize<List<PassDomain>>(res);
    }
}