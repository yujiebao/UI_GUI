using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    private void OnGUI() {
        #region 知识点一 全局颜色
        //全局颜色 影响背景和文本的颜色    但是设置全局颜色后再对控件赋予制件颜色会叠加
        GUI.color = Color.red;
        GUI.Button(new Rect(10, 10, 100, 30), "Button");
        GUI.color = Color.blue;  //更改之后控件的颜色
        GUI.Label(new Rect(10, 50, 100, 30), "Label");

        #endregion
    
        #region 知识点二 整体皮肤样式
        GUI.skin = null;   //GUI控件的样式的集合(Button label .....)   整套设置规则

        #endregion
    }
}
