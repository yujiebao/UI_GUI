using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
      private string inputText = "输入框"; 
      private string password = "密码框";
      private float value = 50;
     private void OnGUI() {
        #region 知识点一 输入框
        #region 普通输入
        inputText = GUI.TextField(new Rect(0,0,100,30),inputText,10);   //重要参数   第一个参数是位置 第二个参数是显示文本 第三个参数是字符最大长度
        #endregion
        
        #region 密码输入
        password = GUI.PasswordField(new Rect(0,50,100,30),password,'*');
        #endregion
        #endregion

        #region 知识点二 滑动条
        #region 水平拖动条
        value = GUI.HorizontalSlider(new Rect(0,100,100,30),value,0,100);  //第一个参数是位置 第二个参数是当前值 第三个参数是最小值 第四个参数是最大值  后面最多可以有三个style
        #endregion

        #region 垂直拖动条
        value = GUI.VerticalSlider(new Rect(0,150,30,100),value,0,100);  //第一个参数是位置 第二个参数是当前值 第三个参数是最小值 第四个参数是最大值  后面最多可以有三个style
        #endregion
        #endregion
     }
}
