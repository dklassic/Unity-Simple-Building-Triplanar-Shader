using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightActivator : MonoBehaviour
{
    void OnTriggerEnter(Collider co)
    {
        // Debug.Log(co.gameObject.name);
        if (co.gameObject.tag == "StreetLamp")
        {
            co.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    void OnTriggerExit(Collider co)
    {
        // Debug.Log(co.gameObject.name);
        if (co.gameObject.tag == "StreetLamp")
        {
            co.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
