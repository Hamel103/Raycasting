using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseFollow : MonoBehaviour
{
    // VARIABLES

    public Transform objectFollowing;
    public Camera sceneCamera;
    
    public LayerMask mask;


    // METHODS

    // Update is called once per frame
    void Update()
    {
        FollowMouse();
    }

    private void FollowMouse()
    {
        Ray ray = sceneCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, 1000, mask))
        {
            objectFollowing.position = hitInfo.point;
            objectFollowing.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
    }

    
}
