using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    public void GoToScene1()
    {
        SceneManager.LoadScene("MovieRoom1");
    }

    public void GoBackUI1()
    {
        SceneManager.LoadScene("Museum");
    }

    public void Replay()
    {
        SceneManager.LoadScene("Museum");
    }
}
