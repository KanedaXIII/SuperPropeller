using UnityEngine;

namespace Code.Managers
{
    public class TimeManager : MonoBehaviour
    {
        public void SetTimeScale(float scale)
        {
            Time.timeScale = scale;
        }
    }
}
