using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum E_Slider_Type
{
    Horizontal,
    Vertical
}
public class CustomSlider : CustomGUIControl
{

    [SerializeField] private float min_Value = 0;
    [SerializeField] private float max_Value = 1;
    [SerializeField] private float now_Value = 0;
    [SerializeField] private E_Slider_Type slider_Type = E_Slider_Type.Horizontal;
    [SerializeField] private GUIStyle styleThumb;
    private float old_Value;
    public event UnityAction onValueChange;
    protected override void StyleOffDraw()
    {
       switch(slider_Type)
        {
            case E_Slider_Type.Horizontal:
            now_Value = GUI.HorizontalSlider(guiPosition.Pos,now_Value,min_Value,max_Value);
                break;
            case E_Slider_Type.Vertical:
            now_Value = GUI.VerticalSlider(guiPosition.Pos,now_Value,min_Value,max_Value);
                break;
   
        }
        if(old_Value!=now_Value)
        {
            old_Value = now_Value;
            onValueChange?.Invoke();
        }
       
    }

    protected override void StyleOnDraw()
    {
        switch(slider_Type)
        {
            case E_Slider_Type.Horizontal:
            now_Value = GUI.HorizontalSlider(guiPosition.Pos,now_Value,min_Value,max_Value,style,styleThumb);
                break;
            case E_Slider_Type.Vertical:
            now_Value = GUI.VerticalSlider(guiPosition.Pos,now_Value,min_Value,max_Value,style,styleThumb);
                break;
        }
        if(old_Value!=now_Value)
        {
            old_Value = now_Value;
            onValueChange?.Invoke();
        }
    }
}
