using UnityEngine;
using UnityEngine.SceneManagement;

public class XpScript : MonoBehaviour
{
    public void OnClickButtonClose()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
}

