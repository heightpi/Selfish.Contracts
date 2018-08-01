using System.Collections.Generic;

namespace Selfish.Contracts.Api {
    public class Result<T> {
        private void InitFields(){
            Messages = new List<Message>();
        }
        public Result (bool success) {
            InitFields();
            Success = success;
        }

        public Result () {
            InitFields();
            Success = true;
        }
        public bool Success { set; get; }
        public IList<Message> Messages { set; get; }
        public T Data { set; get; }
    }

    public class Result : Result<object> {
        public Result () : base () { }
        public Result (bool success) : base (success) { }

    }
}