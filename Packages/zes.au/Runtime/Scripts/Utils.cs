using System;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Au
{
    public static class Utils
    {
        /// <summary>
        /// Get NONE-BOM Utf8 encoding 
        /// </summary>
        public static Encoding utf8WithoutBOM = new UTF8Encoding(false);

        /// <summary>
        /// Wait an unity async operation
        /// </summary>
        /// <param name="op">AsyncOperation</param>
        /// <param name="progress">progress callback</param>
        /// <returns></returns>
        public static async Task<bool> WaitAsyncOperation(AsyncOperation op, Action<float> progress = null)
        {
            while (!op.isDone)
            {
                progress?.Invoke(op.progress);
                await Task.Yield();
            }
            progress?.Invoke(1);
            return true;
        }

        /// <summary>
        /// Wait until condition return true
        /// </summary>
        /// <param name="condition">wait condition</param>
        /// <returns></returns>
        public static async Task<bool> WaitUntil(Func<bool> condition)
        {
            while (!condition())
            {
                await Task.Yield();
            }
            return true;
        }


    }
}
