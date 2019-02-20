using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieSpaceLava : MonoBehaviour
{
    public GameObject Respawn;
    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Character")
        {
            coll.transform.position = Respawn.transform.position;

        }
    }

}
