using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ReefTankCore.Web.Helpers
{
    public static class HtmlHelpers
    {
        public static string ImageOrDefault(this HtmlHelper helper, string filename)
        {
            var imagePath = uploadsDirectory + filename + ".png";
            var imageSrc = File.Exists(helper.ViewContext.ExecutingFilePath) ? imagePath : defaultImage;

            return imageSrc;
        }

        private static string defaultImage = "/Content/Placeholders/270x270.png";
        private static string uploadsDirectory = "/Content/Categories/";
    }
}
