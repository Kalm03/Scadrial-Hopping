using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteelPush : MonoBehaviour
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
        if (Input.GetButtonDown("Push") && VarStorage.steel)
        {
            joint.enabled = true;
            joint.frequency = 5f;
            joint.distance = distance;
        }

        if (Input.GetButtonUp("Push") || !VarStorage.steel)
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
    }

    void DrawLine()
    {
        Vector3 currentGrapplePosition = Vector3.Lerp(player.transform.position, gameObject.transform.position, Time.deltaTime * 8f);

        lr.SetPosition(0, gameObject.transform.position);
        lr.SetPosition(1, currentGrapplePosition);
    }
}
