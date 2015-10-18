using UnityEngine;
using System.Collections;

public class Opacity : MonoBehaviour {
    
    void OnTriggerEnter(Collider col)
    {
        GameObject obj = col.gameObject;
        if (col.tag == "Board")
        {
            MeshRenderersEnable(obj, true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        GameObject obj = col.gameObject;
        if (col.tag == "Board")
        {
            MeshRenderersEnable(obj, false);
        }
    }

    void MeshRenderersEnable(GameObject objs, bool enable)
    {
        if (objs.transform.childCount > 0)
        {
            for(int i = 0; i < objs.transform.childCount; ++i)
            {
                objs.transform.GetChild(i).gameObject.SetActive(enable);
            }
        }
        else
        {
            objs.SetActive(enable);
        }
    }
}
