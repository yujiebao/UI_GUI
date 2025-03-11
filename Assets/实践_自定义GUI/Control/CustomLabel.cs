using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomLabel : CustomGUIControl
{
    protected override void StyleOffDraw()
    {
        GUI.Label(guiPosition.Pos, content);
    }

    protected override void StyleOnDraw()
    {
        GUI.Label(guiPosition.Pos, content, style);
    }
}
