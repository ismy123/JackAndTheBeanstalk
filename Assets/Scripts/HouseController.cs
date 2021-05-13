using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseController : MonoBehaviour
{
    public Animator HouseFall;
    public bool isaction;
    public MonsterController script;

    // Start is called before the first frame update
    void Start()
    {
        HouseFall = GetComponent<Animator>();
        isaction = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (isaction == true)// isaction = true 일때 실행
        {
            script.isaction = true; // 다른 스크립트의 isaction도 true로 바꿈
            HouseFall.Play("HouseFall");
        }
    }
}
