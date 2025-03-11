using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    public Rect rect = new Rect(0,0,100,30);
    public Texture texture;
    public ScaleMode scaleMode = ScaleMode.StretchToFill;
    public bool alpha = true;
    public float wh = 0;
    private void OnGUI() {
        #region 知识点一 图片绘制
        //ScaleMode的三种
        //StretchToFill:保持原有宽高比进行缩放
        //ScaleToFit:保持原有宽高比进行缩放，如果图片的宽高比和屏幕的宽高比不一致，则图片会缩放至屏幕的宽高比   
        //ScaleAndCrop:缩放至屏幕的宽高比，并裁剪掉超出屏幕的部分
        GUI.DrawTexture(rect,texture,scaleMode,alpha,wh); ////第一个参数是位置 第二个参数是图片 第三个参数是缩放模式 第四个参数是是否透明 第五个参数是宽高比
        #endregion

        #region 知识点二 框绘制
        GUI.Box(new Rect(0,30,100,30),"");
        #endregion
    }
}
