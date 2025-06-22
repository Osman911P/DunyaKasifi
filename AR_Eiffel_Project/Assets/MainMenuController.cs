using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartARScene()
    {
        SceneManager.LoadScene("ARScene"); // AR sahnenin adı
    }
}
