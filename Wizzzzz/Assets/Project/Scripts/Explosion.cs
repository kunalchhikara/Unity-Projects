﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private void FixedUpdate()
    {
        Destroy(gameObject, 1.0f);
    }
}
