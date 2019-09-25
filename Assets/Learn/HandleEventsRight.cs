using UnityEngine;
using VRTK;

public class HandleEventsRight : MonoBehaviour
{
    private VRTK_ControllerEvents controllerEvents;

    void Awake()
    {
        controllerEvents = GetComponent<VRTK_ControllerEvents>();
    }
    void OnEnable()
    {
        controllerEvents.TriggerPressed += DoTriggerPressed;
        controllerEvents.TriggerReleased += DoTriggerReleased;
    }
    void OnDisable()
    {
        controllerEvents.TriggerPressed -= DoTriggerPressed;
        controllerEvents.TriggerReleased -= DoTriggerReleased;
    }
    private void DoTriggerPressed(object sender, ControllerInteractionEventArgs e)
    {
        Debug.Log(VRTK_ControllerReference.GetRealIndex(e.controllerReference));
        Debug.Log(e.controllerReference.hand);
    }
    private void DoTriggerReleased(object sender, ControllerInteractionEventArgs e)
    {
        Debug.Log(VRTK_ControllerReference.GetRealIndex(e.controllerReference));
        Debug.Log(e.controllerReference.hand);
    }
}
