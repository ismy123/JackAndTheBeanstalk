using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    public Animator FallingTree;
    public bool isaction;
    public HouseController script; //housecontroller 스크립트안에 있는 bool 요소를 true로 바꿀거임

    

    
    // Start is called before the first frame update
    void Start()
    {
        FallingTree = GetComponent<Animator>();
        isaction = false;

    }

    void Update()
    {        
        if (isaction == true)
        {
            script.isaction = true;
            FallingTree.Play("FallingTree");
        }
    }

    /*void OnTriggerEnter(Collider col)
    {
        if (AX == col.CompareTag("Beanstalk")) //태그 이름을 찾음
        {
            scoreValue = scoreValue +1;
        }
    }
    */
}
