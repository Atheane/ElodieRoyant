using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPageController : MonoBehaviour
{
    public void OnClickButtonPortefolio()
    {
        SceneManager.LoadScene("Portfolio", LoadSceneMode.Single);
    }
}
