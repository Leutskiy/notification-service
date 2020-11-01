using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ENS.WebApi.Channels.Email
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
        public async Task SendAsync(NotificationDto notificationDto)
        {
            // валидация данных

            // генерация отчета по соответствующим параметрам

            // формирование объекта для отправки

            // проверка политик, выбор провайдера, ретрай, ...

            throw new NotImplementedException();
        }
    }
}
