using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetsSee : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Wooden_Crate")
        {
            Destroy(col.gameObject);
        }
    }
}
