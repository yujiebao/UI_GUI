using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    public Rect beginRect = new Rect(0,0,100,30);
    public Rect buttonRect = new Rect(0,0,100,30);

    public Rect scPos;
    public Vector2 nowPos;
    public Rect showPos;

    private void OnGUI() {
        #region 知识点一 分组
        //用于批量控制控件位置
        // 可以理解为 包裹着的控件加了一个父对象
        // 可以通过控制分组来控制包裹控件的位置
        GUI.BeginGroup(beginRect);
        GUI.Button(buttonRect,"按钮");
        GUI.EndGroup();
        #endregion
    
        #region 知识点二 滚动列表
        nowPos = GUI.BeginScrollView(scPos,nowPos,showPos);
        GUI.Toolbar(new Rect(0,0,300,50),0,new GUIContent[]{new GUIContent("按钮1"),new GUIContent("按钮2"),new GUIContent("按钮3")});
        GUI.EndScrollView();
        #endregion
    }
}
