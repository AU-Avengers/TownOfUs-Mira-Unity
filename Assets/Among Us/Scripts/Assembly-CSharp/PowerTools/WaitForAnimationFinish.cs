using System.Collections;
using UnityEngine;

namespace PowerTools
{
	public class WaitForAnimationFinish : IEnumerator
	{
		private SpriteAnim animator;

		private AnimationClip clip;

		private bool first;

		private int stopFrame;

		public object Current => null;

		public WaitForAnimationFinish(SpriteAnim animator, AnimationClip clip, bool restartIfAlreadyPlaying = true, int stopAtFrame = -1)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}
}
