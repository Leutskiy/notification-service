using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ENS.WebApi.Channels
{
    /// <summary>
    /// Контроллер отправки сообщений на электронную почту
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        public EmailController()
        {


        }

        [HttpPost]
        public async Task<string?> SendAsync(SendEmailNotification notificationDto)
        {
            // валидация данных

            // генерация отчета по соответствующим параметрам

            // формирование объекта для отправки

            // проверка политик, выбор провайдера, ретрай, ...

            await Task.Delay(1);

            return notificationDto.Recipients.FirstOrDefault()?.Recipient.ToString();
        }
    }
}
