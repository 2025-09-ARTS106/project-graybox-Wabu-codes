using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GrayBox");
    }

}
