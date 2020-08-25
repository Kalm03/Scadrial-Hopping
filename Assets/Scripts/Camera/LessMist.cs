using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessMist : MonoBehaviour
{
    public float tinMult = 0.4f;
    void Update()
    {
        if(VarStorage.tin)
        {
            Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
            tmp.a = tinMult;
            gameObject.GetComponent<SpriteRenderer>().color = tmp;
        }
        else
        {
            Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
            tmp.a = 0.8f;
            gameObject.GetComponent<SpriteRenderer>().color = tmp;
        }
    }
}
