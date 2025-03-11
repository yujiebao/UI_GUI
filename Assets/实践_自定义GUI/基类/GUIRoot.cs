using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class GUIRoot : MonoBehaviour
{
    private CustomGUIControl[] allGUIControls;
    // Start is called before the first frame update
    void Start()
    {
        //运行是只获取一次  ----这里默认为运行时不添加制件了
        allGUIControls = GetComponentsInChildren<CustomGUIControl>();            
    }

    //在这统一绘制子对象的内容
    private void OnGUI() {
        //每一次绘制前获得是所有子对象控件的脚本
        //这句语句浪费性能
        //只在编辑模式下一直执行来实时显示组件
        if(!Application.isPlaying)
        {
            allGUIControls = GetComponentsInChildren<CustomGUIControl>();    //按照子对象的顺序来获取组件  保证了绘制控件的顺序
        }
        for (int i = 0; i < allGUIControls.Length; i++) {
            //绘制控件
            allGUIControls[i].DrawGUI();
        }
    }
}
