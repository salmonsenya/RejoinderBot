using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace RejoinderBot.Controllers
{
    [Route("bot")]
    public class UpdateController : Controller
    {
        private readonly IUpdateService _updateService;

        public UpdateController(IUpdateService updateService)
        {
            _updateService = updateService ?? throw new ArgumentNullException(nameof(updateService));
        }

        [HttpPost]
        [Route("pizda")]
        public async Task<IActionResult> Update([FromBody] object body)
        {
            var update = JsonConvert.DeserializeObject<Telegram.Bot.Types.Update>(body.ToString());
            if (update == null) return Ok();
            await _updateService.ReplyAsync(update);
            return Ok();
        }
    }
}
