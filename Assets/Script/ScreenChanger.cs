using UnityEngine;
using UnityEngine.SceneManagement;


public class ScreenChanger : MonoBehaviour
{
    public Canvas HomeScreen;
    public Canvas OverScreen;

    public void playagain()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
}

