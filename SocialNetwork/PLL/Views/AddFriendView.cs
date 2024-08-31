using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class AddFriendView
    {
        UserService userService;

        public AddFriendView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            try
            {
                var addFriendData = new AddFriendData();

                Console.WriteLine("Введите почтовый адрес пользователя, которого хотите добавить в друзья:");
                addFriendData.FriendEmail = Console.ReadLine();
                addFriendData.UserId = user.Id;

                this.userService.AddFriend(addFriendData);

                SuccessMessage.Show("Вы успешно добавили пользователя в друзья!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователя с указанным почтовым адресом не существует!");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произоша ошибка при добавлении пользотваеля в друзья!");
            }
        }
    }
}
