namespace Selfish.Contracts.Api {
    public class Message {
        public MessageType Type { set; get; }
        public string Text { set; get; }
        public string Code { set; get; }
    }
}