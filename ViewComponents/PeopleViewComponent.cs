using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using DemoApp.Models;

namespace DemoApp
{
  // [ViewComponent(Name = "People")]
  public class PeopleViewComponent : ViewComponent
  {
 
    List<Person> _people;
    
    public PeopleViewComponent()
    {
    
    }

    public IViewComponentResult Invoke(int count)
    {
      _people = new List<Person>
      {
       new Person{Name="bob"},
       new Person{Name="frank"},
       new Person{Name="sally"}
      };
      
      return View(_people.Take(count));
    }
  }
}