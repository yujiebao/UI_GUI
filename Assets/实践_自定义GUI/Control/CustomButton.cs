using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomButton : CustomGUIControl
{
    //提供给外部 用于相应 按钮点击的事件 只要在外部给予了相应函数 就会执行
    public event UnityAction onClick;
    protected override void StyleOffDraw()
    {
        if(GUI.Button(guiPosition.Pos,content))
        {
            onClick?.Invoke();
        }
    }

    protected override void StyleOnDraw()
    {
         if(GUI.Button(guiPosition.Pos,content,style))
        {
            onClick?.Invoke();
        }
    }
}
