using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarStorage : MonoBehaviour
{
    public static bool pewter = false; public static bool steel = true; public static bool iron = true;  public static bool tin = false; public static bool zinc = false;

    public static float pewterTot = 1130f;
    public static float steelTot = 1130f;
    public static float ironTot = 1130f;
    public static float tinTot = 11100f;
    public static float zincTot = 1130f;

    public static float pewterTime = 1130f;
    public static float steelTime = 1130f;
    public static float ironTime = 1130f;
    public static float tinTime = 11100f;
    public static float zincTime = 1130f;

    void Update()
    {
        if (Input.GetButtonDown("Pewter"))
        {
            pewter = !pewter;
        }
        if (pewter)
        {
            pewterTime -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Steel"))
        {
            steel = !steel;
        }
        if (steel)
        {
            steelTime -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Iron"))
        {
            iron = !iron;
        }
        if (iron)
        {
            ironTime -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Tin"))
        {
           tin = !tin;
        }
        if (tin)
        {
            tinTime -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Zinc"))
        {
            zinc = !zinc;
        }
        if (zinc)
        {
            zincTime -= Time.deltaTime;
        }

        if (pewterTime <= 0)
            pewter = false;
        if (steelTime <= 0)
            steel = false;
        if (ironTime <= 0)
            iron = false;
        if (tinTime <= 0)
            tin = false;
        if (zincTime <= 0)
            zinc = false;
    }//toggle metals
}
