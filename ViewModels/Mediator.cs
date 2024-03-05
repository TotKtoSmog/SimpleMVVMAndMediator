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
        public event Action<string, string> ReceivedMessage;
        public void SendMessage(string receiver, string message)
            => ReceivedMessage?.Invoke(receiver, message);

        public event Action<string> ReceivedMessageFromPage1;
        public void SendMessagePage2(string message)
            => ReceivedMessageFromPage1?.Invoke(message);

        public event Action<string> ReceivedMessageFromPage2;
        public void SendMessagePage1(string message)
            => ReceivedMessageFromPage2?.Invoke(message);
    }
}
