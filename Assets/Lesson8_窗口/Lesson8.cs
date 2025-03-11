using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    public Rect rect = new Rect(0,0,100,30);
    public Rect rect1 = new Rect(100,100,100,30);

    private void OnGUI() {
        #region 知识点一 窗口 
        GUI.Window(1,rect,DrowWindow,"测试窗口");    //第一个参数id是窗口的唯一id 第二个参数是绘制窗口的函数 传入即可
        #endregion 
    
        #region 知识点二 模态窗口
        //模态窗口 可以让该其它控件不在有用
        //你可以理解该窗口在最上层 其它按钮都点击不到了    -----警告窗口
        //只能点击该窗口上控件

        // GUI.ModalWindow(2,rect1,DrowWindow,"模态窗口");
        #endregion
    
        #region 知识点三 拖动窗口
        //条件:1.赋值2.在传入的委托中调入GUI.DragWindow();
        //窗口和模态窗口 的返回值是一个rect可以赋值
        rect1 = GUI.Window(2,rect1,DrowWindow,"ssds");
        #endregion
    }
    private void DrowWindow(int id)
    {  
        //窗口中的控件
        GUI.Button(new Rect(0,50,100,30),"测试按钮");
        if(id == 2)
        GUI.DragWindow(); //无参默认都可以拖动  也可以传入一个Rect 来表示可以拖动的范围 

        //通过id可以在该函数内书写多个窗口的控件  使用的时候通过if判断即可
    }
}
