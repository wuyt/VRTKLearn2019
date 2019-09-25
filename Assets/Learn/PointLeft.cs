using UnityEngine;
using VRTK;
using VRTK.Highlighters;

public class PointLeft : MonoBehaviour
{
    /// <summary>
    /// 外框组件
    /// </summary>
    private VRTK_BaseHighlighter highlighter;

    /// <summary>
    /// 显示外框
    /// </summary>
    public void DisplayLine(object sender, DestinationMarkerEventArgs e)
    {
        highlighter = e.target.GetComponent<VRTK_BaseHighlighter>();
        if (highlighter != null)
        {
            highlighter.Initialise();
            highlighter.Highlight(Color.yellow);
        }
    }
    /// <summary>
    /// 隐藏外框
    /// </summary>
    public void HideLine(object sender, DestinationMarkerEventArgs e)
    {
        if (highlighter != null)
        {
            highlighter.Initialise();
            highlighter.Unhighlight();
            highlighter = null;
        }
    }
}
