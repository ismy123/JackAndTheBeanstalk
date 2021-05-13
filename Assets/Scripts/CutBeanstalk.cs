using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutBeanstalk : MonoBehaviour
{    
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider col) // 충돌했을 시 애니메이션 재생
    {
        Debug.Log("Col");
        if (col.CompareTag("Beanstalk")) //태그 이름을 찾음
        {
           anim.Play("Cutting");
        }
    }
}
