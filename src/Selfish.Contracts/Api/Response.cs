using System.Collections.Generic;

namespace Selfish.Contracts.Api {
    public class Response<T> {
        public bool Success { set; get; }
        public IList<Message> Messages { set; get; }
        public T Data { set; get; }
    }

    public class Response: Response<object>
    {
        
    }
}