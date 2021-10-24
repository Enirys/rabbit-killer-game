using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color[] colors;
    public MeshRenderer headRender;
    
    // Start is called before the first frame update
    void Start()
    {
        int randColor = Random.Range(0, colors.Length);
        GetComponent<MeshRenderer>().materials[0].color = colors[randColor];
        headRender.materials[0].color = colors[randColor];
    }
}
