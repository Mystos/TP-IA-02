using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera mainCamera;

    void Update()
    {
        CheckDoubleClick();
    }

    void CheckDoubleClick()
    {

        if (Input.GetMouseButtonUp(0))
        {

            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                mainCamera.enabled = false;
                mainCamera = hit.collider.GetComponentInChildren<Camera>();
                mainCamera.enabled = true;
            }

        }
    }

}
