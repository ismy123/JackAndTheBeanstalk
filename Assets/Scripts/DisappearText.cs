using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearText : MonoBehaviour
{
    [SerializeField] private GameObject Howto; // 텍스트가 보여졌다가 일정한 시간있다가 사라짐
    // Start is called before the first frame update

    private void Awake()
    {
        Howto = GameObject.Find("Canvas/Howto"); // 오브젝트를 찾음
    }
    void Start()
    {
        Howto.SetActive(true);
        StartCoroutine(Disappear());//Disappear 함수 실행
    }

    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(3);//3초 있다가 사라짐
        Howto.SetActive(false);
    }

}
