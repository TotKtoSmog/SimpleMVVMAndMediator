using SimpleMVVMAndMediator.Model;
using System;

namespace SimpleMVVMAndMediator.ViewModels
{
    public class Mediator
    {
        private static Mediator instance;
        private Mediator() { }

        public static Mediator Instance
        {
            get
            {
                if (instance == null)
                    instance = new Mediator();
                return instance;
            }
        }
        public event Action<string, User> ReceivedMessage;
        public void SendMessage(string receiver, User user)
            => ReceivedMessage?.Invoke(receiver, user);

        public event Action<User> ReceivedMessageFromPage1;
        public void SendMessagePage2(User user)
            => ReceivedMessageFromPage1?.Invoke(user);

        public event Action<User> ReceivedMessageFromPage2;
        public void SendMessagePage1(User user)
            => ReceivedMessageFromPage2?.Invoke(user);
    }
}
