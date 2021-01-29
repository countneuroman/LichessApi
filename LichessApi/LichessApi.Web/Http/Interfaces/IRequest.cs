using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

namespace LichessApi.Web.Http
{
    public interface IRequest
    {
        Uri BaseAddress { get; }

        Uri Endpoint { get; }

        IDictionary<string, string> Headers { get; }

        IDictionary<string, string> Parameters { get; }

        HttpMethod Method { get; }

        object? Body { get; set; }

        CancellationToken CancellationToken { get; set; }
    }
}
