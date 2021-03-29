using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
#if UNITY_EDITOR
public class LightBuilder : MonoBehaviour
{
    [SerializeField] private GameObject lightPrefab = null;
    [SerializeField] private string lampTag = "StreetLamp";
    [SerializeField] private Material lampMaterial = null;
    public void BuildLight()
    {
        foreach (Transform child in transform)
        {
            if (!child.gameObject.activeSelf)
                continue;
            if (lampTag != "")
                child.gameObject.tag = lampTag;
            if (lampMaterial != null)
                child.GetComponent<MeshRenderer>().material = lampMaterial;
            if (lightPrefab == null)
                return;
            if (child.childCount > 0)
            {
                foreach (Transform childsChild in child)
                {
                    DestroyImmediate(childsChild.gameObject);
                }
            }
            GameObject go = (GameObject)PrefabUtility.InstantiatePrefab(lightPrefab);
            if(!child.TryGetComponent<BoxCollider>(out var collider))
            {
                child.gameObject.AddComponent<BoxCollider>();
            }
            go.transform.parent = child;
            go.transform.localPosition = Vector3.zero;
            go.transform.localRotation = Quaternion.identity;
        }
    }

    public void ClearLight()
    {
        foreach (Transform child in transform)
        {
            if (!child.gameObject.activeSelf)
                continue;
            foreach (Transform childsChild in child)
            {
                DestroyImmediate(childsChild.gameObject);
            }
        }
    }

    public void ActivateLight()
    {
        foreach (Transform child in transform)
        {
            if (!child.gameObject.activeSelf)
                continue;
            foreach (Transform childsChild in child)
            {
                childsChild.gameObject.SetActive(true);
            }
        }
    }
    public void DeactivateLight()
    {
        foreach (Transform child in transform)
        {
            if (!child.gameObject.activeSelf)
                continue;
            foreach (Transform childsChild in child)
            {
                childsChild.gameObject.SetActive(false);
            }
        }
    }
}
#endif