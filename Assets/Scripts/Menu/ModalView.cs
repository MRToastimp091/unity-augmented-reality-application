using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalView : MonoBehaviour
{
    [SerializeField] private GameObject[] objs;

    private void Start()
    {
#if !UNITY_EDITOR
        HideAll();
#endif
    }

    public void View(int index)
    {
        for(int i = 0; i < objs.Length; i++)
        {
            objs[i].SetActive(i == index);
        }
    }

    public void HideAll()
    {
        for(int i = 0; i < objs.Length; i++)
        {
            objs[i].SetActive(false);
        }
    }
}
