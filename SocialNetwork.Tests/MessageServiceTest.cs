using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Tests
{
    public class MessageServiceTest
    {
        [Fact]
        public void MessageMustNotExceed5000Characters()
        {
            string message = "Данное сообщение не выходит за пределы допустимого количества символов";

            Assert.True(message.Length < 5000);
        }
    }
}
