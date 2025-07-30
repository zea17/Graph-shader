using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class PlayModeViewSetter
{
    static PlayModeViewSetter()
    {
        EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
    }

    private static void OnPlayModeStateChanged(PlayModeStateChange state)
    {
        if (state == PlayModeStateChange.EnteredPlayMode)
        {
            // Set the scene view to look down the Z-axis
            SceneView.lastActiveSceneView.LookAt(
                SceneView.lastActiveSceneView.pivot,
                Quaternion.LookRotation(Vector3.forward),
                SceneView.lastActiveSceneView.size,
                true
            );

            // Alternative method that might work better in some cases:
            // SceneView.lastActiveSceneView.rotation = Quaternion.LookRotation(Vector3.forward);
        }
    }
}