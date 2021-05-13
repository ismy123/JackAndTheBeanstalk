using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public Text score;
    public Animator anim;
    public AudioSource AX;
    public AudioSource ClickSound;
    public int scoreValue;
    public TreeController script;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (scoreValue >= 5) //scoreValue가 5이상일때 
        {
            script.isaction = true; // 다른 스크립트의 isaction을 true로 바꿈
            score.text = "나쁜 거인을 무찔렀어요!"; // 화면에 있었던 count 텍스트 대신 나쁜거인을 무찔렀어요라고 나오게 하기
            StartCoroutine(ChangeScene());
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Beanstalk")) //태그 이름을 찾음
        {
            AX.Play();
            anim.Play("Cutting");
            scoreValue = scoreValue +1;// 충돌할떄마다 scoreValue 1씩 증가하게 하기
            Debug.Log(scoreValue);
            anim.Play("New State");
            score.text = "Score : " + scoreValue; // 화면에 얼마나 도끼질을 했는지 알려줌
        }
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(10); // 10초 있다가 화면 전환
        SceneManager.LoadScene("Scene_05");
    }
}
