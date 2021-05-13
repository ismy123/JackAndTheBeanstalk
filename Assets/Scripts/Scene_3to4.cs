using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_3to4 : MonoBehaviour
{
    public AudioSource ButtonSound;
    public void ChangeScene() // 도끼 터치시 버튼 생성됌
    {
        ButtonSound.Play();
        SceneManager.LoadScene("Scene_04");
    }
}
