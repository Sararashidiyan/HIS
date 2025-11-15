using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.SharedKernel.Http
{
    public class ResponseDto
    {
        public int Code { get; set; }

        public string? Message { get; set; }

        public string? DebugMessage { get; set; }

        public object? Data { get; set; }

        public string? TraceID { get; set; }

        public ResponseDto()
        {
        }

        public ResponseDto(object? data, string? message = null, int code = 1, string? debugMessage = null, string? traceID = null)
        {
            Data = data;
            Message = message;
            Code = code;
            DebugMessage = debugMessage;
            TraceID = traceID;
        }
    }
}
