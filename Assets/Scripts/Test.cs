using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue
{
    [TextArea] //������ �� �� �ֵ���
    public string dialogue;
    public Sprite cg; //��ü�� cg ���ĵ� �̹���
}
public class Test : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;

    //�����̽��ٸ� ������ ��ȭ �ѱ��
    //��ȭ ������ ���� ��쿡�� �����̽� �ٸ� ������ ��ȭX
    
    private bool isDialogue = false; //��ȭ�� ���������� �˷���

    private int count = 0;  //��簡 �󸶸�ŭ ����Ǿ����� �˷��� ī��Ʈ
    
    [SerializeField] private Dialogue[] dialogue; //��ȭ,cg�� ���������� �迭�� ����...

    //Ŭ������ ��쿡�� ���̰�..,.(��)Ȱ��ȭ ����..ó��
    //Ŭ������ ��쿡 ȣ��Ǵ� �Լ�
    public void ShowDialogue()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
