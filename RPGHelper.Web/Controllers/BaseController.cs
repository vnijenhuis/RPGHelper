using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RPGHelper.Models.System;

namespace RPGHelper.Web.Controllers
{
    public class BaseController : Controller
    {
        public const string Key = "NotificationMessages";

        public void AddNotificationMessage(MessageTypeDto message)
        {
            var messages = (IList<MessageTypeDto>)TempData[Key] ?? new List<MessageTypeDto>();

            messages.Add(message);
            TempData[Key] = messages;
        }
    }
}