using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomInput : CustomGUIControl
{
    public event UnityAction OnInputChange;
    private string oldString = "";
    protected override void StyleOffDraw()
    {
        content.text = GUI.TextField(guiPosition.Pos,content.text);
        if(oldString != content.text)
        {
            OnInputChange?.Invoke();
            oldString = content.text;
        }
    }

    protected override void StyleOnDraw()
    {
         content.text = GUI.TextField(guiPosition.Pos,content.text,style);
        if(oldString != content.text)
        {
            OnInputChange?.Invoke();
            oldString = content.text;
        }
    }
}
