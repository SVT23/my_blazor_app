using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp.Client // Provides a scope to the identifiers inside it --> Blazor 
{
    public class TodoItem // Create the public class called TodoItem
    {
        public string Title { get; set; } // Get & Set Title 
        public bool IsDone { get; set; } // Get & Set IsDone
    }
}