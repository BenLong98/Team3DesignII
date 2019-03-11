using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Attack")]
public class AttackAction : Action 
{
    public override void Act(StateController controller)
    {
        Attack(controller);
    }

    private void Attack(StateController controller)
    {
        if (Vector3.Distance(controller.navMeshAgent.nextPosition, controller.chaseTarget.position) < 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
