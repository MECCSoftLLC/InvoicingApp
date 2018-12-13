using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoicing.Core.Base
{
    public class RequestResult
    {
        public RequestState State { get; set; }
        public String Message { get; set; }
        public Object Data { get; set; }

        public String Serialize() => JsonConvert.SerializeObject(this);
    }

    public enum RequestState
    {
        Failed = -1,
        NotAuth = 0,
        Success = 1
    }
}
