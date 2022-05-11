using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PanelController : MonoBehaviour
{
    public VideoPlayer _videoPlayer;
    public VideoClip _videoClip;

    public void OnClickButtonPlay()
    {
        _videoPlayer.clip = _videoClip;
        _videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        _videoPlayer.EnableAudioTrack(0, true);
        _videoPlayer.Play();
    }

    public void OnClickButtonClose()
    {
        SceneManager.LoadScene("StartPage", LoadSceneMode.Single);
    }

}
