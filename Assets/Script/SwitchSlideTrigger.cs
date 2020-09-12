using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSlideTrigger : MonoBehaviour
{
    public GameObject slideTrigger;
    Material _Material;
    public static bool isGreen = false;

    private void Awake()
    {
        _Material = this.transform.GetComponentInParent<Renderer>().materials[0];
    }
    private void OnTriggerEnter()
    {
        Debug.Log("Enter switch slide Trigger!");
        if (!isGreen)
        {
            _Material.color = Color.green;
            isGreen = true;
        }
    }

    private void Update()
    {
        if (isGreen)         // 开关变绿色时才激活该 Trigger
            slideTrigger.SetActive(true);
    }
}
