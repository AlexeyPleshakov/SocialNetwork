using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Views;
using System;

namespace SocialNetwork
{
    class Program
    {
        static MessageService messageService;
        static UserService userService;
        public static AuthenticationView authenticationView;
        public static MainView mainView;
        public static RegistrationView registrationView;
        public static MessageSendingView messageSendingView;
        public static UserInfoView userInfoView;
        public static UserMenuView userMenuView;
        public static UserDataUpdateView userDataUpdateView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutcomingMessageView userOutcomingMessageView;
        public static AddingFriendView addingFriendView;
        public static UserFriendView userFriendView;
        static void Main()
        {
            messageService = new MessageService();
            userService = new UserService();

            authenticationView = new AuthenticationView(userService);
            registrationView = new RegistrationView(userService);
            mainView = new MainView();
            messageSendingView = new MessageSendingView(userService, messageService); ;
            userInfoView = new UserInfoView();
            userMenuView = new UserMenuView(userService);
            userDataUpdateView = new UserDataUpdateView(userService);
            userIncomingMessageView = new UserIncomingMessageView();
            userOutcomingMessageView = new UserOutcomingMessageView();
            addingFriendView = new AddingFriendView(userService);
            userFriendView = new UserFriendView();

            while (true)
            {
                mainView.Show();
            }
        }
    }
}