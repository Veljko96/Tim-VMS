using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DummyArrowCap))]
public class ArrowCapEditor : Editor
{
    public float arrowSize = 1;

    void OnSceneGUI()
    {
        DummyArrowCap t = target as DummyArrowCap;

        Handles.color = Handles.xAxisColor;
        Handles.ArrowCap(0, t.transform.position, t.transform.rotation * Quaternion.Euler(0, 90, 0), arrowSize);

        Handles.color = Handles.yAxisColor;
        Handles.ArrowCap(0, t.transform.position, t.transform.rotation * Quaternion.Euler(-90, 0, 0), arrowSize);

        Handles.color = Handles.zAxisColor;
        Handles.ArrowCap(0, t.transform.position, t.transform.rotation, arrowSize);
    }
}
