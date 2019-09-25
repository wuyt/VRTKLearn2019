using UnityEngine;
using VRTK;

public class HandleEventsLeft : MonoBehaviour
{
    public void TriggerPressed()
    {
        Debug.Log("Button Pressed");
    }
    public void TriggerReleased(object sender, ControllerInteractionEventArgs e)
    {
        Debug.Log(e.buttonPressure);
    }
}
