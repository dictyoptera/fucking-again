using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obscure : MonoBehaviour
{
    // Start is called before the first frame update
    function Start()
    {
        // get all renderers in this object and its children:
        var renders = GetComponentsInChildren(Renderer);
        for (var rendr: Renderer in renders)
        {
            rendr.material.renderQueue = 2002; // set their renderQueue
        }
    }
}
