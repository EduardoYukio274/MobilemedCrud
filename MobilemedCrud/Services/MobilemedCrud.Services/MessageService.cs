using MobilemedCrud.Services.Interfaces;

namespace MobilemedCrud.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
