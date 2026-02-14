using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    public string nextSceneName;
    public void nextLevel()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
