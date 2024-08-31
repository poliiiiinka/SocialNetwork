﻿using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserIncomingMessageView
    {
        public void Show(IEnumerable<Message> incomingMessages)
        {
            Console.WriteLine("Входящие сообщения:");

            if (incomingMessages.Count() == 0)
            {
                Console.WriteLine("Входящих сообщений нет");
                return;
            }

            incomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine($"От кого: {message.SenderEmail}. Текст сообщения: {message.Content}");
            });
        }
    }
}
