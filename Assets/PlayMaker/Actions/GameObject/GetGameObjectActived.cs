using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory(ActionCategory.GameObject)]
	public class GetGameObjectActived : FsmStateAction
	{
		public FsmGameObject TargetObject;
		[UIHint(UIHint.Variable)]
		public FsmBool Result;


		// Code that runs on entering the state.
		public override void OnEnter()
		{
			Result.Value = TargetObject.Value.activeInHierarchy;
			
			Finish();
		}


	}

}
