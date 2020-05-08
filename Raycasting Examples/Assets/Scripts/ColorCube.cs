using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class ColorCube : MonoBehaviour
{
    // VARIABLES

    public Transform cube;
    public LayerMask maskOne;
    public LayerMask maskTwo;


    // METHODS

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = cube.position - transform.position;
        CubeColor(direction);
    }

    private void CubeColor(Vector3 direction)
    {
        Ray ray = new Ray(transform.position, direction);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, 1000, maskTwo))
        {
            cube.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (Physics.Raycast(ray, out hitInfo, 1000, maskOne))
        {
            hitInfo.transform.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        
    }
}
