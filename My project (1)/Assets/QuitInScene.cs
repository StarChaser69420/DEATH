using UnityEngine;
using UnityEngine.SceneManagement;

    public class QuitGame : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadSceneAsync(0);
            }
        }
    }

