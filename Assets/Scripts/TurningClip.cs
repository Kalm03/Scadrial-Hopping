using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurningClip : MonoBehaviour
{
    public GameObject bodyClip;

    public GameObject clip;
    public float launchForce;
    public Transform shotPoint;
    public static int numClips = 0;
    public float offset;

    public TextMeshProUGUI text;

    void Update()
    {
        Vector2 clipPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - clipPosition;
        transform.right = direction;

        if (Input.GetMouseButtonDown(1) && numClips > 0 && VarStorage.steel)
        {
            Shoot();
            numClips--;
        }

        if (VarStorage.steel && numClips>0)
            bodyClip.SetActive(true);
        else
            bodyClip.SetActive(false);

        text.text = numClips.ToString();
    }

    void Shoot()
    {
        GameObject newClip = Instantiate(clip, shotPoint.position, shotPoint.rotation);
        newClip.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
    }
}
