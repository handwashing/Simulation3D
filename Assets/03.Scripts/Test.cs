using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea] //여러줄 쓸 수 있도록
    public string dialogue;
    public Sprite cg; //교체될 cg 스탠딩 이미지
}
public class Test : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;

    //스페이스바를 눌러서 대화 넘기기
    //대화 내용이 없을 경우에는 스페이스 바를 눌러도 변화X
    
    private bool isDialogue = false; //대화가 진행중인지 알려줌

    private int count = 0;  //대사가 얼마만큼 진행되었는지 알려줄 카운트
    
    [SerializeField] private Dialogue[] dialogue; //대화,cg들 여러개여서 배열로 쓰기...

    //클릭했을 경우에만 보이게..,.(비)활성화 여부..처리
    //클릭했을 경우에 호출되는 함수
    public void ShowDialogue()
    {
        //Sprite_DialogueBox.gameObject.SetActive(true); //SetActive(true)로 활성화 시키기
        //sprite_StandingCG.gameObject.SetActive(true);
        //txt_Dialogue.gameObject.SetActive(true); 
        //isDialogue = true;
        //=> OnOff함수로 대체

        OnOff(true); //Dialogue가 증가할 때 true
        count = 0; //대화 시작함-> 카운트 0으로 다시 초기화
        //처음 호출 하자마자 텍스트가 뜨도록
        //호출 되자마자 Next Dialogue를 실행
        NextDialogue();
    } 
     
    private void OnOff(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);  
        sprite_StandingCG.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
        isDialogue = _flag;
        //대화가 시작될 때는 트루를 넘겨줌 
    }

    // 스페이스바를 누를 때마다 대화 진행되도록...
    //대화 진행 함수
    private void NextDialogue()
    {//배열에 인덱스가 증가 / 다른 대화와 cg 출력
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_StandingCG.sprite = dialogue[count].cg;
        count++;
    }

    //NextDialogue가 스페이스 바를 누를 때마다 또 호출되도록
    void Update()
    {//false일때 스페이스바가 눌러지지 않도록 isDialogue가 true인지 확인
        
        if (isDialogue) 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {//다음에 넘어갈 수 있는 대화가 존재할 경우에만 NextDialogue 실행
                if (count < dialogue.Length)
                    NextDialogue();
                else //더이상 진행할 대화가 없다면 끝내기
                    OnOff(false);
            }
        }
    }
}
