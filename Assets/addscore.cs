using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class addscore : MonoBehaviour
{
    public void OnTriggerEnter(Collider collision){
        score.sc++;
    }
}
