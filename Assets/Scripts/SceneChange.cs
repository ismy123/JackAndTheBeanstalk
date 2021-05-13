using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour // 씬전환 스크립트
{
    public AudioSource ClickSound;
    public void SceneChange_1to2() 
    {
        ClickSound.Play();
        SceneManager.LoadScene("Scene_02");
    }

    public void SceneChange_1to3()
    {
        ClickSound.Play();
        SceneManager.LoadScene("Scene_03-2");
    }

    public void SceneChange_2to3()
    {
        ClickSound.Play();
        SceneManager.LoadScene("Scene_03-2");
    }

    public void SceneChange_5to1()
    {
        ClickSound.Play();
        SceneManager.LoadScene("Scene_01");
    }
}
