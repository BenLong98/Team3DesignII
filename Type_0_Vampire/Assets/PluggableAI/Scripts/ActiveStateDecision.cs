using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decision/ActiveState")]
public class ActiveStateDecision : Decision
{
	public override bool Decide(StateController controller)
	{
		PlayerController player = controller.chaseTarget.gameObject.GetComponent<PlayerController>();
		bool isBat = player.GetIsBat();
		return !isBat;
	}
}
