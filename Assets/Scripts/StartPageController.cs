using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPageController : MonoBehaviour
{
    public void OnClickButtonPortefolio()
    {
        SceneManager.LoadScene("Portefolio", LoadSceneMode.Single);
    }
}
