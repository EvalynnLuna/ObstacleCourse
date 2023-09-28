using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("You have bumped into something this many times: " + hits);
    }
}
