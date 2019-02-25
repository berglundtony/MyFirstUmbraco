using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using MyFirstUmbraco.Core.ViewModels;

namespace MyFirstUmbraco.Core.Controllers
{
    public class HomeController : RenderMvcController
    {
        public ActionResult Index()
        {
            var model = new HomeViewModel(CurrentPage)
            {
                MyTextArea = CurrentPage.GetPropertyValue<string>("bodyText")
            };

            return CurrentTemplate(model);
        }
    }
}