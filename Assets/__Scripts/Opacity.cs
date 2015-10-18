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
            foreach(var meshRenderer in objs.transform.GetComponentsInChildren<MeshRenderer>())
            {
                meshRenderer.enabled = enable;
            }
        }
        else
        {
            objs.GetComponent<MeshRenderer>().enabled = enable;
        }
    }
}
