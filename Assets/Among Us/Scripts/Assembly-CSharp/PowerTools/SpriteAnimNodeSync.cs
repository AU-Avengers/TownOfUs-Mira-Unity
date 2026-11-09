using UnityEngine;

namespace PowerTools
{
	[ExecuteInEditMode]
	public class SpriteAnimNodeSync : MonoBehaviour
	{
		public int NodeId;

		public SpriteAnimNodes Parent;

		public SpriteRenderer ParentRenderer;

		public SpriteRenderer Renderer;

		[HideInInspector]
		public Vector3 flipOffset;

		[HideInInspector]
		public Vector3 normalOffset;

		public void LateUpdate()
		{
		}
	}
}
