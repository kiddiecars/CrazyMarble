using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCameraController : MonoBehaviour
{
[SerializeField]
    private Transform _target;

    [SerializeField]

    private int _zdistance;
    [SerializeField]

    private int _ydistance;

    // Update is called once per frame
    void Update()
    {
        Vector3 p = _target.position;
        p.z = p.z - 10;
        transform.position = p;
    }
}
