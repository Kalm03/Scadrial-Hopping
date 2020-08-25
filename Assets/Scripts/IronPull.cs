using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IronPull : MonoBehaviour
{
    SpringJoint2D joint;
    //DistanceJoint2D joint;

    public LayerMask isClip;
    public GameObject player;

    private LineRenderer lr;

    public float distance;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        joint = GetComponent<SpringJoint2D>();
        //joint = GetComponent<DistanceJoint2D>();
        joint.connectedBody = player.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Pull") && VarStorage.iron)
        {
            joint.enabled = true;
            joint.frequency = 1f;
            joint.distance = 0f;
        }

        if (Input.GetButtonUp("Pull") || !VarStorage.iron)
        {
            joint.enabled = false;
        }
    }

    private void LateUpdate()
    {
        if (VarStorage.steel)
        {
            DrawLine();
        }
        else
        {
            lr.SetPosition(0, gameObject.transform.position);
            lr.SetPosition(1, gameObject.transform.position);
        }
    }

    void DrawLine()
    {
        Vector3 currentGrapplePosition = Vector3.Lerp(player.transform.position, gameObject.transform.position, Time.deltaTime * 8f);

        lr.SetPosition(0, gameObject.transform.position);
        lr.SetPosition(1, currentGrapplePosition);
    }
}
