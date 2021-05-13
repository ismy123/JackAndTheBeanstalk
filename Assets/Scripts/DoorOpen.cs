using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour // 
{
    public AudioSource DoorSound;
    [SerializeField] private GameObject popup0;
    private GameObject popup1; //키로 열어보세요
    private GameObject popup2;// 도끼를 터치해보세요

    public float currentAngle = 0;
    public float lastAngle = 0;

    private void Awake()
    {
        popup0 = GameObject.Find("Canvas/TouchGround");
        popup1 = GameObject.Find("Canvas/CloseToDoor");
        popup2 = GameObject.Find("Canvas/TouchAx");
    }
    // Update is called once per frame
    
    void Start()
    {
        popup0.SetActive(true);
        popup1.SetActive(false);
        popup2.SetActive(false);

        StartCoroutine(POPUP());
    }

    void Update()
    {
        currentAngle = Mathf.LerpAngle(currentAngle,lastAngle,Time.deltaTime * 3f);//애니메이션처럼 보여줌
        transform.localEulerAngles = new Vector3(0,currentAngle,0);

        Debug.Log(currentAngle);
    }

    IEnumerator POPUP()
    {
        yield return new WaitForSeconds(5); // 5초 있다가 popup0은 사라지고 popup1은 생김
        popup0.SetActive(false);
        popup1.SetActive(true);
    }

    void OpenLoop() // 문열림
    {
        DoorSound.Play();
        lastAngle = -180f;
        popup2.SetActive(true);
    }

    void CloseLoop() // 문닫힘
    {
        DoorSound.Play();
        lastAngle = 0f;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("MainCamera")) //MainCamera라는 태그를 가진 오브젝트와 충돌시 문 열림
        {
            OpenLoop();
            popup1.SetActive(false);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("MainCamera")) //MainCamera라는 태그를 가진 오브젝트와 충돌시 문 닫힘
        {
            CloseLoop();
        }
    }
}
