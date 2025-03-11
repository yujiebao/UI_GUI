using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class Lesson3 : MonoBehaviour
{ 
    public Rect rect = new Rect(0,0,100,30);
    private bool isSelect;
    private bool isSelect2;
    public GUIStyle style;
    private int nowSelIndex = 1; 
    private void OnGUI() {
        #region 知识点一 多选框
        #region 普通样式
        isSelect =  GUI.Toggle(rect,isSelect,"效果开关");     //isSelect实时更新返回值
        #endregion
        
        #region  自定义样式
        //修改固定宽高 fixedwidth和fixedHeight
        //修改从GuIstyle边缘到内容起始处的空间 padding(填充)  
        isSelect2 = GUI.Toggle(new Rect(0,40,100,30),isSelect2,"效果开关",style);
        #endregion
        #endregion
    
        #region 知识点二 单选框
        //单选框是基于 多选框的实现
        if(GUI.Toggle(new Rect(0,60,100,30),nowSelIndex == 1,"选项一"))
        {
            nowSelIndex = 1;
        }
        if(GUI.Toggle(new Rect(0,100,100,30),nowSelIndex == 2,"选项二"))
        {
            nowSelIndex = 2;
        }
        if(GUI.Toggle(new Rect(0,140,100,30),nowSelIndex == 3,"选项三"))
        {
            nowSelIndex = 3;
        }
        #endregion
    }
}
