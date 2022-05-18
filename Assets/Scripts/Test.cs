using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
