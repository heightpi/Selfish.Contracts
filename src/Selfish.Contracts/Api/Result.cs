using System.Collections.Generic;

namespace Selfish.Contracts.Api {
    public class Result<T> {
        public bool Success { set; get; }
        public IList<Message> Messages { set; get; }
        public T Data { set; get; }
    }

    public class Result: Result<object>
    {
        
    }
}