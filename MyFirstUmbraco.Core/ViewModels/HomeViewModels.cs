using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace MyFirstUmbraco.Core.ViewModels
{
    public class HomeViewModel : RenderModel
    {
        public string MyTextArea { get; set; }

        public HomeViewModel(IPublishedContent content) : base(content)
        {
        }

        public HomeViewModel(IPublishedContent content, CultureInfo culture) : base(content, culture)
        {
        }
    }
}