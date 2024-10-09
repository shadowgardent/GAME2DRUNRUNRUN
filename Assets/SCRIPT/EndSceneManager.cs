using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class EndSceneManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        // ผูกฟังก์ชันให้ทำงานเมื่อวิดีโอจบ
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // ฟังก์ชันนี้จะถูกเรียกเมื่อวิดีโอจบ
    void OnVideoEnd(VideoPlayer vp)
    {
        // เปลี่ยนกลับไปยังหน้าหลัก (SampleSceneMenu)
        SceneManager.LoadScene("SampleSceneMenu");
    }
}

