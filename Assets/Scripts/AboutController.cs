using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutController : MonoBehaviour
{
    public void OnClickMalt()
    {
        Application.OpenURL("https://www.malt.fr/profile/elodieroyant");
    }
    public void OnClickLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/elodie-royant-472b00b");
    }
    public void OnClickButtonClose()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
}
