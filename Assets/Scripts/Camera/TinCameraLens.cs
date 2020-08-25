using UnityEngine;
using Cinemachine;

public class TinCameraLens : MonoBehaviour
{
    public float lens = 5f;
    public float tinMult = 1.25f;

    public CinemachineVirtualCamera vcam;

    void Update()
    {
        if(VarStorage.tin)
        {
            vcam.m_Lens.OrthographicSize = lens * tinMult;
        }
        else
        {
            vcam.m_Lens.OrthographicSize = lens;
        }
    }
}
