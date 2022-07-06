using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backround : MonoBehaviour
{
    public static float backgroundSpeed;
    public Renderer backgroundRenderer;
    public Renderer planets;
    
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed*Time.deltaTime,0f);
        backgroundRenderer.material.mainTextureOffset+= new Vector2(backgroundSpeed*Time.deltaTime,0f);
        
    }
}
