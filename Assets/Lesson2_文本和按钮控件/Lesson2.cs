using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Lesson2 : MonoBehaviour
{
    public Texture texture;
    public Rect rect;
    public Rect rect1;
    public  GUIContent content;
    public GUIStyle style;
    public Rect rect2;
    public GUIContent content1;
    public GUIStyle btnStyle;

    private void OnGUI() {
        #region 知识点一 GUI控件绘制的共同点
        //1.他们都是GUI公共类中提供的静态函数 直接调用即可
        //2.他们的参数都大同小异
        // 位置参数:Rect参数 xy位置 w h尺寸
        // 显示文本:string参数
        // 图片信息:Texture参数
        // 综合信息:GUIContent参数
        // 自定义样式:GUIStyle参数
        //3.每一种控件都有多种重载，都是各个参数的排列组合
        // 必备的参数内容 是 位置信息和显示信息
        #endregion   
    
        #region 知识点二 文本控件
        // 基本使用
        GUI.Label(new Rect(0,0,100,20),"Hello World",style);   //第一个参数是位置 第二个参数是显示文本   rect(x,y,width,height)  坐标原点是左上角
        GUI.Label(rect,texture);    //保持原有宽高比进行缩放
        //综合使用
        GUI.Label(rect1,content);
        Debug.Log(GUI.tooltip);  //获取鼠标或键盘选中的GUI控件对应的tooptip信息
        //自定义样式
        #endregion
    
        #region 知识点三 按钮控件
        if(GUI.Button(rect2,content1,btnStyle))   //按下抬起响应
        {
            //用于处理按钮点击
            Debug.Log("按钮被点击了");
        }
        // if(GUI.RepeatButton(rect2,content1,btnStyle))   长按按钮
        #endregion
    }
}
