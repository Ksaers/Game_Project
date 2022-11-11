using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public float offset;

    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWoldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Radd2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
    }

}
