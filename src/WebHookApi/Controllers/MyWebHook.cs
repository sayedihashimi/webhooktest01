using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebHookApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class MyWebHook : ControllerBase {
        [HttpPost]
        public async Task PostHookAsync([FromBody] object body)
        {
            Console.WriteLine($"PostHook called");

            //throw new NullReferenceException();
            //Console.WriteLine($"going to sleep forever");
            //while (true) {
            //    Console.Write(".");
            //    await Task.Delay(5000);
            //}
        }
    }
}
