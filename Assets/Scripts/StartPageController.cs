using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPageController : MonoBehaviour
{
    public void OnClickButtonPortefolio()
    {
        SceneManager.LoadScene("Portfolio", LoadSceneMode.Single);
    }
    public void OnClickButtonAbout()
    {
        SceneManager.LoadScene("About", LoadSceneMode.Single);
    }
}
