using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Football : MonoBehaviour
{
    public GameController Controller;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Goal")
        {
            Controller.IncrementScore();
            
        }
    }
}
