using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcPoint : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameManager GM;
    Material _Material;
    public static bool isGreen = false;


    private void OnTriggerEnter()
    {
        Debug.Log("Reach ArcPoint!");
        GM.arcPoint = transform.position;
        _Material.color = Color.green;
        isGreen = true;
    }
    private void Awake()
    {
        _Material = transform.GetComponent<Renderer>().materials[0];
    }
}
