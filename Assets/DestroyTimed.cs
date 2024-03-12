using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimed : MonoBehaviour
{



    private void DestroyObject()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", 5f);
    }


}
