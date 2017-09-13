using UnityEngine;
using UnityEditor;

namespace BeatThat
{

	// Analysis disable ConvertToStaticType
	public class ApplyLayoutEditor : UnityEditor.Editor
	// Analysis restore ConvertToStaticType
	{
		[MenuItem("GameObject/UI/Ape - Layout - Apply (recursively)")]
		public static void ApplyRecursive(MenuCommand cmd)
		{
			var go = cmd.context as GameObject;
			if(go == null) {
				Debug.Log("Must be called with a scene object selected");
				return;
			}

			var list = go.GetComponentsInChildren<IAppliesLayout>(true);
			foreach(var item in list) {
				item.ApplyLayout();
			}
		}
	}
}