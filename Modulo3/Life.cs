using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(UnityEngine.Collider wallBlock)
    {
        if (wallBlock.name != "Plane")
        {
            Destroy(this.gameObject);
        }
    }
}
