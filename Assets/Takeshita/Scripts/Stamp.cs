using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Stamp : MonoBehaviour
{
    public Action OnStampExploded;

    public void Boom()
    {
        if (OnStampExploded != null)
        {
            OnStampExploded();
        }
    }
}
