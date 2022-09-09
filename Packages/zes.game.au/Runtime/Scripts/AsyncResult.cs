namespace Au
{
    /// <summary>
    /// Async op result
    /// </summary>
    /// <typeparam name="T">Type of the return data</typeparam>
    public class AsyncResult<T>
    {
        public AsyncResult(int error, string message)
        {
            this.error = error;
            this.message = message;
        }

        public AsyncResult(T data)
        {
            this.error = 0;
            this.data = data;
        }

        public int error;
        public string message;
        public T data;

        /// <summary>
        /// Whether result is failed
        /// </summary>
        public bool Failed
        {
            get { return error != 0; }
        }
    }
}
