using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR_64||UNITY_EDITOR
using UnityEditor;
using UnityEditor.Callbacks;
#endif
using UnityEngine;

public class AfteBuild : MonoBehaviour {
        [PostProcessBuild(1)]
        public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject)
        {
            Debug.Log(pathToBuiltProject);
        }
}
