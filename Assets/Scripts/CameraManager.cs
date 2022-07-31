using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Camera[] cameras = new Camera[2];
    int activeCameraIdx = 0;

    void Start()
    {
        cameras[0].enabled = true;
        cameras[1].enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            CycleCamera();
    }

    void CycleCamera()
    {
        cameras[activeCameraIdx].enabled = false;
        activeCameraIdx++;
        activeCameraIdx %= 2;
        cameras[activeCameraIdx].enabled = true;
    }


}
