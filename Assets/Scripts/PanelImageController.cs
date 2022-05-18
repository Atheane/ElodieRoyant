using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PanelImageController : MonoBehaviour
{
    public Sprite _cover_image;
    private RawImage _rawImage;

    private void Start()
    {
        _rawImage = GetComponentInChildren<RawImage>();
        _rawImage.texture = _cover_image.texture;
    }

    public void OnClickButtonClose()
    {
        SceneManager.LoadScene("StartPage", LoadSceneMode.Single);
    }

}
