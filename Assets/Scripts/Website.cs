using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Website : MonoBehaviour
{
    public void OpenURL() //URL로 이동시켜줌
    {
        Application.OpenURL("http://www.ibookland.com/main.html?retRef=Y&source=https://search.naver.com/search.naver%3Fwhere=nexearch%26query=%EC%95%84%EC%9D%B4%EB%B6%81%EB%9E%9C%EB%93%9C%26ie=utf8%26sm=tab_she%26qdt=0"); //어플리케이션을 통해 해당 URL로 이동
    }
}
