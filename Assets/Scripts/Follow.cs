using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    void Start()
    {

    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = target.transform.position;
    }
}

