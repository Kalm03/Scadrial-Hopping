using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZTimer : MonoBehaviour
{
    Image Bar;
    void Start()
    {
        Bar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Bar.fillAmount = VarStorage.zincTime / VarStorage.zincTot;
    }
}
