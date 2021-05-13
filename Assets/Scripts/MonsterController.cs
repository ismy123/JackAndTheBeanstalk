using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public bool isaction;
    public Animator MonsterFalling;
    public AudioSource MonsterSound;
    
    // Start is called before the first frame update
    void Start()
    {
        MonsterFalling = GetComponent<Animator>();
        isaction = false;//처음 실행할때 isaction은 false로 실행
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isaction == true)
        {
            MonsterSound.Play();
            MonsterFalling.Play("MonsterFalling");
        }
    }
}
