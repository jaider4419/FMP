using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName;

    void Start()
    { videoPlayer.loopPointReached += OnVideoEnd; }

    void OnVideoEnd(VideoPlayer vp)
    {
        if (vp == videoPlayer)
        { LoadNextScene(); }
    }
    void LoadNextScene()
    { SceneManager.LoadScene(nextSceneName); }
}
