using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CalcTest.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace CalcTest.API.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class ShowMeTheCodeController : ControllerBase
  {
    private HttpClient client;
    private string URLAPI = "https://api.github.com/repos/luicesar";

    public ShowMeTheCodeController()
    {
      this.client = new HttpClient();
      this.client.DefaultRequestHeaders.Accept.Clear();
      this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
      this.client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
    }

    [HttpGet]
    public async Task<object> Get()
    {
      var result = await GetRespositoryAsync($"{URLAPI}/projeto");
      return Ok(result);
    }

    [NonAction]
    async Task<string> GetRespositoryAsync(string path)
    {
      RepositoryModel respository = new RepositoryModel();
      HttpResponseMessage response = await this.client.GetAsync(path);
      if (response.IsSuccessStatusCode)
      {
        respository = await response.Content.ReadAsAsync<RepositoryModel>();
      }
      return respository.html_url;
    }

  }
}