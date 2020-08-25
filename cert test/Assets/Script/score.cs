using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public int scorecount = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Enemy"))
        {
            Destroy(other.gameObject);
            scorecount = scorecount + 1;
        }
    }
}
