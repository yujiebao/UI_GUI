using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    private void OnGUI() {
        #region 知识点一 GUILayout自动布局
        //重要用于编辑器开发 如果又来做游戏UI不太合适
        //GUILayout.BeginHorizontal();   改为横向布局  配合EndHorizontal()   也可以传入一个rect来设置范围
        GUILayout.Button("按钮1");
        GUILayout.Button("按钮2");
        GUILayout.Button("按钮3");
        GUILayout.Button("按钮4");
        GUILayout.Button("按钮5");
        GUILayout.Button("按钮6");
        GUILayout.Label("标签",GUILayout.Width (100));
        //GUILayout.EndHorizontal();
        #endregion
    
        #region 知识点二 GUILayoutOption 布局选项
        //控件的固定宽高
        GUILayout.Width (100);
        GUILayout.Height(100);
        //允许控件的最小宽高
        GUILayout.MinWidth (100);
        GUILayout.MinHeight(100);
        //允许控件的最大宽高
        GUILayout.MaxWidth (100);
        GUILayout.MaxHeight(100);
        //允许或禁止水平拓展
        GUILayout.ExpandWidth(true);
        GUILayout.ExpandHeight(true);
        GUILayout.ExpandWidth(false);
        GUILayout.ExpandHeight(false);
        #endregion
    }
}
