using System.Collections;
using UnityEngine;
using UnityEngine.UI;//Ui를 이용하는 스크립트

public class TypeWriterEffect : MonoBehaviour
{
    public float delay = 0.15f;//글자가 나타나는 속도 조절
    public string fullText; //글자수를 셀 때 사용함
    private string currentText = "";
    public GameObject Button;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText()); //글자보여주기
        Button.SetActive(false);//글자가 다 보여지기 전엔 버튼을 보여주지 않게 함
    }

    IEnumerator ShowText() //글자 한개씩 보여주는 함수
    {
        GetComponent<AudioSource>().Play(); //글자가 보여지기 시작할 때 효과음 실행
        for (int i=0; i<fullText.Length;i++)//글자수가 FULLTEXT인지 세는 함수
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);//한글자씩 쳐지고 멈추고를 반복하여 텍스트가 쳐지는 걸 같이 보여짐
        }
        Button.SetActive(true);// 글자가 다 보여지고 나면 다음 씬으로 이동할 수 있는 버튼 활성화
        GetComponent<AudioSource>().Stop();//글자가 fulltext면 효과음 실행 멈춤
        
    }
}
