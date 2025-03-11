using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum E_Style_OnOff
{
    On,
    Off
}
public abstract class CustomGUIControl : MonoBehaviour
{
    //提取空间的共同表现
    //位置信息
    
    public GUIPosition guiPosition;
    //显示内容信息
    public GUIContent content;
    //自定义样式
    public GUIStyle style;
    //自定义样式是否启用的开关
    public E_Style_OnOff style_OnOff = E_Style_OnOff.Off;

    public void DrawGUI() {
       switch(style_OnOff)
       {
           case E_Style_OnOff.On:
               StyleOnDraw();
               break;
           case E_Style_OnOff.Off:
               StyleOffDraw();
               break;
       }
    }

    protected abstract void StyleOnDraw();

    protected abstract void StyleOffDraw();
}
