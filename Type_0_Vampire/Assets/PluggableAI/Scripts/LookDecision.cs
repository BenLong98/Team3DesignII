using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decision/Look")]
public class LookDecision : Decision
{
	private static float _t = 0;
	private float maximum = 0.3f;
	private float minimum = 0.0f;
	public override bool Decide(StateController controller)
	{
		bool targetVisible = Look(controller);
		return targetVisible;
	}

	private bool Look(StateController controller)
	{
		RaycastHit hit;
		
		_t += .4f * Time.deltaTime;
		
		Vector3 direction = new Vector3(controller.eyes.forward.x, Mathf.Lerp(minimum, maximum, _t), controller.eyes.forward.z);
		if (_t > 1.0f)
		{
			float temp = maximum;
			maximum = minimum;
			minimum = temp;
			_t = 0.0f;
		}
		
		Debug.DrawRay(controller.eyes.position, direction.normalized * controller.enemyStats.lookRange, Color.green);

		if (Physics.SphereCast(controller.eyes.position, controller.enemyStats.lookSphereCastRadius,
			    direction, out hit, controller.enemyStats.lookRange) && hit.collider.CompareTag("Player"))
		{
			controller.chaseTarget = hit.transform;
			return true;
		}
		else
		{
			return false;
		}
	}
}
