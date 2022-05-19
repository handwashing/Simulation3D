using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{//SerializeField -> 외부 스크립트에서 접근 불가능,  inspector창에서 접근 가능
    [SerializeField] Transform tf_Crosshair;

    //private void Awake()
    //{
    //    Screen.sleepTimeout = SleepTimeout.NeverSleep; //게임 실행 중 화면이 꺼지지 않도록...
    //    Screen.SetResolution(720, 1080, true); //화면 설정
    //}
    void Update()
    {//매 프레임마다 마우스의 움직임에 따라 움직이도록...
        CrosshairMoving();
    }

    void CrosshairMoving()
    {//마우스의 (좌표값)으로 좌표값 움직이기
        //tf_Crosshair.localPosition = Input.mousePosition;
        //-> 실제 마우스커서의 위치와 화면상의 커서 위치가 너무 멀다...
        tf_Crosshair.localPosition = new Vector2(Input.mousePosition.x - (Screen.width / 2),
                                                 Input.mousePosition.y - (Screen.height / 2));
        float t_cursorPosX = tf_Crosshair.localPosition.x; //마우스 커서가 화면 밖으로
        float t_cursorPosY = tf_Crosshair.localPosition.y; //벗어나지 않도록                                                    

        t_cursorPosX = Mathf.Clamp(t_cursorPosX, (-Screen.width / 2 + 50), (Screen.width / 2 - 50));
        t_cursorPosY = Mathf.Clamp(t_cursorPosY, (-Screen.height / 2 + 50), (Screen.height / 2 - 50));

        tf_Crosshair.localPosition = new Vector2(t_cursorPosX, t_cursorPosY);
    }
}
