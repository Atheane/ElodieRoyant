using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PanelVideoController : MonoBehaviour
{
    public string _url;
    public Sprite _cover_image;
    public bool _isMobile;
    private Transform _loader;
    private Transform _buttonPlay;
    private VideoPlayer _videoPlayer;
    private RawImage _rawImage;

    private void Start()
    {
        _buttonPlay = transform.Find("ButtonPlay");
        _loader = transform.Find("Loader_1");
        _loader.gameObject.SetActive(false);
        _rawImage = GetComponentInChildren<RawImage>();
    }

    public void OnClickButtonPlay()
    {
        _buttonPlay.gameObject.SetActive(false);
        _loader.gameObject.SetActive(true);
        GameObject go = Instantiate(Resources.Load("Prefabs/VideoPlayer")) as GameObject;

        if (_isMobile)
        {
            go = Instantiate(Resources.Load("Prefabs/VideoPlayerMobile")) as GameObject;
        }
        _videoPlayer = go.GetComponent<VideoPlayer>();
        _videoPlayer.prepareCompleted += (source) =>
        {
            source.Play();
            _loader.gameObject.SetActive(false);
            _rawImage.texture = Resources.Load("Textures/VideoRenderTexture") as Texture;
            if (_isMobile)
            {
                _rawImage.texture = Resources.Load("Textures/VideoRenderMobileTexture") as Texture;
            }
        };
        _videoPlayer.url = _url;
        _videoPlayer.audioOutputMode = VideoAudioOutputMode.Direct;
        _videoPlayer.EnableAudioTrack(0, true);
        _videoPlayer.Prepare();
    }

    public void StopVideo()
    {
        if (_videoPlayer != null && !_loader.GetComponent<Animator>().isActiveAndEnabled)
        {
            _videoPlayer.Stop();
            _buttonPlay.gameObject.SetActive(true);
            _rawImage.texture = _cover_image.texture;
        }
    }

    public void OnClickButtonClose()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }

}
