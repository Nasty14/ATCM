using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace RESTfull.Controllers
{
    public class ImageControllerController : ApiController
    {

        public HttpResponseMessage Picture()
        {
            var bitmap = new Bitmap(500, 500);
            var image = Image.FromHbitmap(bitmap.GetHbitmap());
            //Image img = new Image.
            //ImageConverter converter = new ImageConverter();
            //converter.ConvertTo(image, typeof(byte[]));
            byte[] byteArray = new byte[0];
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Close();

                byteArray = stream.ToArray();
            }

            var response = new HttpResponseMessage();
            response.Content = new ByteArrayContent(byteArray);
           response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
            return response;
        }
    }
}
