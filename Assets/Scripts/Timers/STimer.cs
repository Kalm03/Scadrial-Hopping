using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STimer : MonoBehaviour
{
    Image Bar;
    void Start()
    {
        Bar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Bar.fillAmount = VarStorage.steelTime / VarStorage.steelTot;
    }
}
