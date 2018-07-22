using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class SceneHandler : MonoBehaviour
    {

        public void ChangeScene(int scene)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
