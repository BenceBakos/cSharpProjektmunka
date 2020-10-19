using System;
namespace TaskR
{
    public class CommandResult
    {
        public int httpStatus { get; private set;  }
        public bool success { get; private set; }
        public string response { get; private set; }

        public CommandResult(int httpStatus, bool success, string response)
        {
            this.httpStatus = httpStatus;
            this.success = success;
            this.response = response;
        }
    }
}
