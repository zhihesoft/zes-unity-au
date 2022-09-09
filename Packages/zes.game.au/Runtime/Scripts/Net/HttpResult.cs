namespace Au.Net
{
    /// <summary>
    /// Http result
    /// </summary>
    public class HttpResult : AsyncResult<string>
    {
        public HttpResult(string data) : base(data) { }

        public HttpResult(int error, string message) : base(error, message) { }
    }
}
