using UnityEngine;
using System.Collections;


public class changeColorPefab : MonoBehaviour

{
    [SerializeField] Renderer rend;
    void Start()
    {
        rend.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
