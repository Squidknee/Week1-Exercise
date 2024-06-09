using UnityEngine;

namespace _app.Scripts.Managers
{
    public class DelegateManager : MonoBehaviour
    {
        public delegate void eventDelegate();

        public static eventDelegate scoreEvent;
        public static eventDelegate deathEvent;

        public delegate void StringEvent(string s);

        public static StringEvent stringEvent;
    }
}