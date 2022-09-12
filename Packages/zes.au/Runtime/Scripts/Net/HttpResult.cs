namespace Au.Net
{
    /// <summary>
    /// Http result
    /// </summary>
    public class HttpResult : Result<string>
    {
        public HttpResult(string data) : base(data) { }

        public HttpResult(int error, string message) : base(error, message) { }
    }
}
