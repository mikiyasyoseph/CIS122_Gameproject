using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruct_1 : MonoBehaviour
{
    public GameObject destroyedVersion;
    //when clicked it will know it is being clicked
    void onMouseDown()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);

    }
}
