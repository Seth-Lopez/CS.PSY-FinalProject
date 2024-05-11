using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnCollide : MonoBehaviour
{
    //static ScoreCounter scoreCnt = GetComponent<ScoreCounter>();
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Collider")
        {
            //scoreCnt.incrementScore();
        }
    }
}
