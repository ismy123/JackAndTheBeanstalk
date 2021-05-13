using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AXTouch : MonoBehaviour
{
    public GameObject AttachAx; 
    private GameObject popup;

    private GameObject Btn;
    public AudioSource ButtonSound;

    void Start()
    {
        popup = GameObject.Find("Canvas/TouchAx"); //도끼를 찾으라는 텍스트가 보여짐
        Btn = GameObject.Find("Canvas/Btn_CutBeanstalk");
        AttachAx.SetActive(false); // 카메라에 있는 도끼 취소시켜놓음
        Btn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) // 도끼 터치시 카메라에 부착
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;

            if(Physics.Raycast(raycast, out raycastHit))// 오브젝트 터치 감지
            {
                if(raycastHit.collider.CompareTag("AX")) //AX 터치시 카메라에 부착
                {
                    popup.SetActive(false);
                    AttachAx.SetActive(true);
                    Btn.SetActive(true);
                }
            }
        }
    }

    public void ChangeScene() // 도끼 터치시 버튼 생성됌
    {
        ButtonSound.Play();
        SceneManager.LoadScene("Scene4");
    }
}
