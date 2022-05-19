using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{//SerializeField -> �ܺ� ��ũ��Ʈ���� ���� �Ұ���,  inspectorâ���� ���� ����
    [SerializeField] Transform tf_Crosshair;

    //private void Awake()
    //{
    //    Screen.sleepTimeout = SleepTimeout.NeverSleep; //���� ���� �� ȭ���� ������ �ʵ���...
    //    Screen.SetResolution(720, 1080, true); //ȭ�� ����
    //}
    void Update()
    {//�� �����Ӹ��� ���콺�� �����ӿ� ���� �����̵���...
        CrosshairMoving();
    }

    void CrosshairMoving()
    {//���콺�� (��ǥ��)���� ��ǥ�� �����̱�
        //tf_Crosshair.localPosition = Input.mousePosition;
        //-> ���� ���콺Ŀ���� ��ġ�� ȭ����� Ŀ�� ��ġ�� �ʹ� �ִ�...
        tf_Crosshair.localPosition = new Vector2(Input.mousePosition.x - (Screen.width / 2),
                                                 Input.mousePosition.y - (Screen.height / 2));
        float t_cursorPosX = tf_Crosshair.localPosition.x; //���콺 Ŀ���� ȭ�� ������
        float t_cursorPosY = tf_Crosshair.localPosition.y; //����� �ʵ���                                                    

        t_cursorPosX = Mathf.Clamp(t_cursorPosX, (-Screen.width / 2 + 50), (Screen.width / 2 - 50));
        t_cursorPosY = Mathf.Clamp(t_cursorPosY, (-Screen.height / 2 + 50), (Screen.height / 2 - 50));

        tf_Crosshair.localPosition = new Vector2(t_cursorPosX, t_cursorPosY);
    }
}