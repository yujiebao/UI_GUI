using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomTexture : CustomGUIControl
{
    //图片的缩放模式
    [SerializeField] ScaleMode scaleMode = ScaleMode.StretchToFill;
    protected override void StyleOffDraw()
    {
        GUI.DrawTexture(guiPosition.Pos, content.image, scaleMode);
    }

    protected override void StyleOnDraw()
    {
        GUI.DrawTexture(guiPosition.Pos, content.image, scaleMode);

    }
}
