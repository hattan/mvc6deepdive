using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using DemoApp.Models;


namespace DemoApp
{
    public class IAMMiddleware
    {
        RequestDelegate _next;
        
        IAMModel iAam=null;
        public IAMMiddleware(RequestDelegate next,IAMModel iamModel)
        {
            _next = next;
            iAam = iamModel;
        }

        public async Task Invoke(HttpContext context)
        {
            
           context.Response.Headers.Add("I_AM", new[] { iAam.IAM });
           context.Response.Headers.Add("GitHubToken", new[] { iAam.GitHubToken });
           await _next(context);

           /* var sw = new Stopwatch();
            sw.Start();
1
            using (var memoryStream = new MemoryStream())
            {
                var bodyStream = context.Response.Body;
                context.Response.Body = memoryStream;
  
                await _next(context);

                var isHtml = context.Response.ContentType?.ToLower().Contains("text/html");
                if (context.Response.StatusCode == 200 && isHtml.GetValueOrDefault())
                {
                    {
                        memoryStream.Seek(0, SeekOrigin.Begin);
                        using (var streamReader = new StreamReader(memoryStream))
                        {
                            var responseBody = await streamReader.ReadToEndAsync();
                            var newFooter = @"<footer><div id=""process"">Page processed in {0} milliseconds.</div>";
                            responseBody = responseBody.Replace("<footer>", string.Format(newFooter, sw.ElapsedMilliseconds));
                            context.Response.Headers.Add("X-ElapsedTime", new[] { sw.ElapsedMilliseconds.ToString() });
                            using (var amendedBody = new MemoryStream())
                            using (var streamWriter = new StreamWriter(amendedBody))
                            {
                                streamWriter.Write(responseBody);
                                amendedBody.Seek(0, SeekOrigin.Begin);
                                await amendedBody.CopyToAsync(bodyStream);
                            }
                        }
                    }
                }
            }*/
        }
    }
}