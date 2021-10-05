using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp.Client
{
    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}