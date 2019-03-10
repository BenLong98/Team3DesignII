using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dancing : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] float timeBetweenDances;
    [SerializeField] Animator myAnim;

    public void Start()
    {
        StartCoroutine("StartDances");
    }

    public IEnumerator StartDances() {

        for (int i = 0; i < player.GetComponent<PlayerController>().collectedDances.Count; i++) {

            switch (player.GetComponent<PlayerController>().collectedDances[i]) {
                case 1:
                    myAnim.SetTrigger("ID1");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 2:
                    myAnim.SetTrigger("ID2");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 3:
                    myAnim.SetTrigger("ID3");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 4:
                    myAnim.SetTrigger("ID4");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 5:
                    myAnim.SetTrigger("ID5");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 6:
                    myAnim.SetTrigger("ID6");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 7:
                    myAnim.SetTrigger("ID7");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 8:
                    myAnim.SetTrigger("ID8");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 9:
                    myAnim.SetTrigger("ID9");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 10:
                    myAnim.SetTrigger("ID10");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 11:
                    myAnim.SetTrigger("ID11");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 12:
                    myAnim.SetTrigger("ID12");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 13:
                    myAnim.SetTrigger("ID13");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 14:
                    myAnim.SetTrigger("ID14");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 15:
                    myAnim.SetTrigger("ID15");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 16:
                    myAnim.SetTrigger("ID16");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 17:
                    myAnim.SetTrigger("ID17");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 18:
                    myAnim.SetTrigger("ID18");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 19:
                    myAnim.SetTrigger("ID19");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 20:
                    myAnim.SetTrigger("ID20");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 21:
                    myAnim.SetTrigger("ID21");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 22:
                    myAnim.SetTrigger("ID22");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 23:
                    myAnim.SetTrigger("ID23");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 24:
                    myAnim.SetTrigger("ID24");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 25:
                    myAnim.SetTrigger("ID25");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 26:
                    myAnim.SetTrigger("ID26");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 27:
                    myAnim.SetTrigger("ID27");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 28:
                    myAnim.SetTrigger("ID28");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 29:
                    myAnim.SetTrigger("ID29");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 30:
                    myAnim.SetTrigger("ID30");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 31:
                    myAnim.SetTrigger("ID31");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 32:
                    myAnim.SetTrigger("ID32");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 33:
                    myAnim.SetTrigger("ID33");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 34:
                    myAnim.SetTrigger("ID34");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 35:
                    myAnim.SetTrigger("ID35");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 36:
                    myAnim.SetTrigger("ID36");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 37:
                    myAnim.SetTrigger("ID37");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 38:
                    myAnim.SetTrigger("ID38");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 39:
                    myAnim.SetTrigger("ID39");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 40:
                    myAnim.SetTrigger("ID40");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 41:
                    myAnim.SetTrigger("ID41");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 42:
                    myAnim.SetTrigger("ID42");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 43:
                    myAnim.SetTrigger("ID43");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 44:
                    myAnim.SetTrigger("ID44");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 45:
                    myAnim.SetTrigger("ID45");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                case 46:
                    myAnim.SetTrigger("ID46");
                    yield return new WaitForSeconds(timeBetweenDances);
                    continue;
                default:
                    continue;

            }



        }

        StartCoroutine("StartDances");

    }
}

