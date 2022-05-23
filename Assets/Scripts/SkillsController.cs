using UnityEngine;
using UnityEngine.SceneManagement;

public class SkillsController : MonoBehaviour
{
    public void OnClickButtonClose()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
}
