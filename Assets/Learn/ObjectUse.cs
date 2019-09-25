using UnityEngine;
using VRTK;

[RequireComponent(typeof(VRTK_InteractableObject))]
public class ObjectUse : MonoBehaviour
{
    /// <summary>
    /// 交互物体
    /// </summary>
    private VRTK_InteractableObject interactableObject;

    void Awake()
    {
        interactableObject = GetComponent<VRTK_InteractableObject>();
    }
    /// <summary>
    /// 激活
    /// </summary>
    void OnEnable()
    {
        //激活时候注册事件响应方法
        interactableObject.InteractableObjectUsed += InteractableObjectUsed;
        interactableObject.InteractableObjectUnused += InteractableObjectUnused;
    }
    /// <summary>
    /// 禁用
    /// </summary>
    void OnDisable()
    {
        //禁用的时候注销事件响应方法
        interactableObject.InteractableObjectUsed -= InteractableObjectUsed;
        interactableObject.InteractableObjectUnused -= InteractableObjectUnused;
    }
    /// <summary>
    /// 交互物体使用
    /// </summary>
    void InteractableObjectUsed(object sender, InteractableObjectEventArgs e)
    {
        Debug.Log(e.interactingObject.name + "--Used--" + transform.name);
    }
    /// <summary>
    /// 交互物体使用完成
    /// </summary>
    void InteractableObjectUnused(object sender, InteractableObjectEventArgs e)
    {
        Debug.Log(e.interactingObject.name + "--Unused--" + transform.name);
    }
}
