using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AXKey : MonoBehaviour
{
    private GameObject Btn;
    public GameObject AttachAx; 
    public AudioSource ItemSound;
    public GameObject ax;
    private GameObject popup1; //도끼를 찾아보세요
    private GameObject popup2;// 콩나무를 베러 가봐요
    public GameObject Lt_AX;

    private void Awake()
    {
        popup1 = GameObject.Find("Canvas/FindAX"); // 스크립트를 통해 오브젝트 찾음
        popup2 = GameObject.Find("Canvas/LetsGo");
    }
    void Start()
    {
        Btn = GameObject.Find("Canvas/Button");
        AttachAx.SetActive(false); // 카메라에 있는 도끼 취소시켜놓음
        Btn.SetActive(false);
        popup1.SetActive(true);
        popup2.SetActive(false);
    
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
                    AttachAx.SetActive(true); // 카메라에 Ax 부착
                    Btn.SetActive(true); // 다음씬으로 넘어갈 수 있는 버튼 생성
                    ItemSound.Play();
                    ax.SetActive(false);
                    popup1.SetActive(false);
                    popup2.SetActive(true); // 텍스트 변환
                    Lt_AX.SetActive(false);
                }
            }
        }
    }
}
