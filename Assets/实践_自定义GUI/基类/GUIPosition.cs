using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//对齐方式的枚举
public enum E_Alignment_Type
{
    Up,Down,Left,Right,Center,Left_Up,Left_Down,Right_Up,Right_Down
}

/// <summary>
/// 该类是用来表示位置 计算位置相关信息的 不需要继承MonoBehaviour
/// </summary>  
[Serializable]
public class GUIPosition 
{
    //主要处理 控件位置相关的内容
    //要完成 分辨率自适应的相关计算

    //该位置信息 会用来返回给外部 用于绘制控件
    // //需要对它进行 计算
   private Rect scPos = new Rect(0,0,100,100);


   public E_Alignment_Type screen_Alignment = E_Alignment_Type.Center;  //屏幕对齐方式

   public E_Alignment_Type control_Alignment = E_Alignment_Type.Center;    //控件对齐方式
   public Vector2 pos;  //偏移位置
   //宽高
   public float width;
   public float height;
   
    private Vector2 centerPos;    //用于计算的 中心点 成员变量   ----控件

    //计算中心点偏移   ----控件
    private void CalcCenterPos()
    {
        switch (control_Alignment)
        {
             case E_Alignment_Type.Up:
                centerPos.x = -width/2;  
                centerPos.y = 0;
                break;
            case E_Alignment_Type.Down:
                centerPos.x = -width/2;
                centerPos.y = -height;
                break;
            case E_Alignment_Type.Left:
                centerPos.x = 0;
                centerPos.y = -height/2;
                break;                
            case E_Alignment_Type.Right:
                centerPos.x = -width;
                centerPos.y = -height/2;
                break;   
            case E_Alignment_Type.Center:
                centerPos.x = -width/2;
                centerPos.y = -height/2;
                break;             
            case E_Alignment_Type.Left_Up:
                centerPos.x = 0;
                centerPos.y = 0;
                break;   
            case E_Alignment_Type.Left_Down:
                centerPos.x = 0;
                centerPos.y = -height;
                break;               
            case E_Alignment_Type.Right_Up:
                centerPos.x = -width;
                centerPos.y = 0;
                break;          
            case E_Alignment_Type.Right_Down:
                centerPos.x = -width;
                centerPos.y = -height;
                break;                
        }
    }

    //计算控件的屏幕坐标点
    private void CalcPos()
    {
        switch (screen_Alignment)
        {
            case E_Alignment_Type.Up:
                scPos.x = Screen.width / 2 + centerPos.x + pos.x;
                scPos.y = 0 + pos.y + centerPos.y ;
                break;
            case E_Alignment_Type.Down:
                scPos.x = Screen.width/2 + centerPos.x + pos.x;
                scPos.y = Screen.height + centerPos.y - pos.y;
                break;
            case E_Alignment_Type.Left:
                scPos.x = 0 + centerPos.x + pos.x;
                scPos.y = Screen.height/2 + centerPos.y + pos.y;
                break;                
            case E_Alignment_Type.Right:
                scPos.x = Screen.width + centerPos.x - pos.x;
                scPos.y = Screen.height/2 + centerPos.y + pos.y;
                break;   
            case E_Alignment_Type.Center:
                scPos.x = Screen.width/2 + centerPos.x + pos.x;
                scPos.y = Screen.height/2 + centerPos.y + pos.y;
                break;             
            case E_Alignment_Type.Left_Up:
                scPos.x = 0 + centerPos.x + pos.x;
                scPos.y = 0 + centerPos.y + pos.y;
                break;   
            case E_Alignment_Type.Left_Down:
                scPos.x = 0 + centerPos.x + pos.x;
                scPos.y = Screen.height + centerPos.y - pos.y;
                break;               
            case E_Alignment_Type.Right_Up:
                scPos.x = Screen.width + centerPos.x - pos.x;
                scPos.y = 0 + centerPos.y + pos.y;
                break;          
            case E_Alignment_Type.Right_Down:
                scPos.x = Screen.width + centerPos.x - pos.x;
                scPos.y = Screen.height + centerPos.y - pos.y;
                break;  
        }                
             
    }
    /// <summary>
    /// 得到最终绘制的位置和宽高
    /// </summary>
    /// <value></value>
   public Rect Pos
   {
        get{
            //进行计算
            //计算控件中心点
            CalcCenterPos();
            //计算 相对屏幕坐标点
            CalcPos();
            //宽高直接赋值  返回给外部  别人直接使用来绘制控件
            scPos.width = width;
            scPos.height = height;
            return scPos;
        }
   }

}
