﻿using Alchemy.Inspector;
using UnityEngine;

public class UnsignedTest : MonoBehaviour
{
    [Button]
    public void TestUint(uint value)
    {
        Debug.Log("TestLong");
    }

    [Button]
    public void TestULong(ulong value)
    {
        Debug.Log("TestULong");
    }
}