using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decision/ModifiedActiveState")]
public class ModifiedActiveDecision : Decision
{
	public override bool Decide(StateController controller)
	{
		PlayerController player = controller.chaseTarget.gameObject.GetComponent<PlayerController>();
		bool chaseTargetIsActive = player.GetIsInVent();
		return !chaseTargetIsActive;
	}
}
