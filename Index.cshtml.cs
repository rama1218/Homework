using Homework2.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace Homework2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnPost()
        {
            string Name = Request.Form["Name"];
            string Mobile = Request.Form["Mobile"];
            string Address = Request.Form["Address"];
            Person person = new Person();
            person.SaveData(Name, Mobile, Address);

        }
    }
}