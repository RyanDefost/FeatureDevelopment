using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField]
    private bool _isBuildable;

    public bool GetisBuildable()
    {
        return _isBuildable;
    }
}
