using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour 
{
    public Light Lt;
    // Start is called before the first frame update
    void Start()
    {
        Lt = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f); //0.5f 마다 문이 꺼졌다 켜졌다 함
            Lt.enabled =! Lt.enabled;
        }
    }
}
