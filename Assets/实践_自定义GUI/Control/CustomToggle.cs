using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CustomToggle : CustomGUIControl
{
    public bool isSel;
    public event UnityAction<bool> changeValue;
    private bool isOldSel;
    protected override void StyleOffDraw()
    {
        isSel = GUI.Toggle(guiPosition.Pos,isSel,content);
        //只有变化才执行changeValue函数
        if(isOldSel != isSel)
        {
            changeValue?.Invoke(isSel);
            isOldSel = isSel;
        }
    }

    protected override void StyleOnDraw()
    {
        isSel = GUI.Toggle(guiPosition.Pos,isSel,content,style);
        if(isOldSel != isSel)
        {
            changeValue?.Invoke(isSel);
            isOldSel = isSel;
        }
    }
}
