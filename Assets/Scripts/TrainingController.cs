using UnityEngine;
using UnityEngine.SceneManagement;

public class TrainingController : MonoBehaviour
{
    public void OnClickProjectIfocop1()
    {
        Application.OpenURL("http://spacelovsasteroids.herokuapp.com/");
    }
    public void OnClickProjectIfocop2()
    {
        Application.OpenURL("https://desolate-plateau-61253.herokuapp.com/");
    }
    public void OnClickProjectIfocop3()
    {
        Application.OpenURL("https://expo.dev/accounts/atheane/projects/parkin-rn");
    }
    public void OnClickTrainingLeWagon()
    {
        Application.OpenURL("https://www.lewagon.com/fr/program");
    }
    public void OnClickTrainingENSAE()
    {
        Application.OpenURL("https://www.ensae.fr/formation/cycle-ingenieur/");
    }
    public void OnClickButtonClose()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
}
