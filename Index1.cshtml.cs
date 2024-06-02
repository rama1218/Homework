using Homework2.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework2.Pages
{
    public class Index1Model : PageModel
    {
        public List<Person> PersonList = new List<Person>();
        public void OnGet()
        {
            Person person = new Person();
            PersonList = person.GetPerson();
        }
    }
}
