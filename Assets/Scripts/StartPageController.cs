using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPageController : MonoBehaviour
{
    public void OnClickButtonPortefolio()
    {
        SceneManager.LoadScene("ExampleScene", LoadSceneMode.Single);
    }
}
