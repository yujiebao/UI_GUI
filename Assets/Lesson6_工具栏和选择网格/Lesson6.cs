using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    private int toolbarIndex = 0;
    private int selectGridIndex = 0;
    [SerializeField] private GUIContent[] gUIContents;
    private void OnGUI() {
    #region 知识点一 工具栏
    toolbarIndex = GUI.Toolbar(new Rect(0,0,100,30),toolbarIndex,gUIContents);
    switch (toolbarIndex)
    {
        case 0:
            break;
        case 1:
            break;
    }
    #endregion       
    
    #region 知识点二 选择网格
    selectGridIndex = GUI.SelectionGrid(new Rect(0,60,100,30),selectGridIndex,gUIContents,3);    //相对于Toolbar多了一个参数---最后一个控制水平方向最多显示的按钮数
    #endregion
    }
}
