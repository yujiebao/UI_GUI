using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 通过管理多选框(Toggle)来实现单选框
/// 但是该类没有添加[executeAlways]属性 需要执行才能实现效果
/// </summary>
public class ToggleGroup : MonoBehaviour
{
    public CustomToggle[] toggles;
    public CustomToggle front;
    // Start is called before the first frame update
    void Start()
    {
        if(toggles.Length == 0)
        return;
        
        //通过遍历 来为多个 多选框 添加 监事件函数
        //在函数中做 处理
        //当一个为true时 另外两个变成false
        for (int i = 0; i < toggles.Length; i++)
        {
            CustomToggle toggle = toggles[i];
            toggle.changeValue += (value) => {
                //但传入的 value 为 true 时 把另外的变为false
                 if(value)
                 {
                     for (int j = 0; j < toggles.Length; j++)
                     {
                        //  if(j == i)   //闭包
                        //  continue;
                        //  toggles[j].isSel = false;
                        if( toggles[j] != toggle )
                        {
                            toggles[j].isSel = false;
                        }
                     }
                    front = toggle;
                 }
                //如果是 就不应该让它变成false
                //来判断 当前变成false的这个togg1e是不是上一次为true
                 else if(toggle == front)
                 {
                    //强制改为true
                    toggle.isSel = true;   
                 }
            };
        }
        
    }
}
