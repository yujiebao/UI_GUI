using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [ExecuteAlways]      //在编辑模式下执行所有的函数
public class Lesson_alwaysExe : MonoBehaviour
{
    
    private void OnEnable() {
        Debug.Log("OnEnable() called.");
    }
    
    private void Awake() {
        Debug.Log("Awake() called.");
    }
    void Start()
    {
        Debug.Log("Start() called.");
    }

    private void FixedUpdate() {
        Debug.Log("FixedUpdate() called.");
    }
     
    void Update()
    {
        Debug.Log("Update() called.");
    }
    private void LateUpdate() {
        Debug.Log("LateUpdate() called.");
    }
    private void OnDisable() {
        Debug.Log("OnDisable() called.");
    }
    private void OnDestroy() {
        Debug.Log("OnDestroy() called.");
    }

}
