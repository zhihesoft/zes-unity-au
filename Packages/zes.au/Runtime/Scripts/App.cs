using UnityEngine;
using UnityEngine.Assertions;

namespace Au
{
    public class App : MonoBehaviour
    {
        private static App instance;

        private void Start()
        {
            Assert.IsNull(instance, "App can only be init once");

            // App instance will not be destroy when scene changed
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
    }
}
