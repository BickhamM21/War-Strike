using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;

using Unity.Mathematics;


using UnityEngine;

public class ChunkManagementSystem : SystemBase
{

    const int viewDistance = 100; //max view distance in terms of chunks, each chunk is 16mx16m. this results in a view distance of 1.6km in each direction

    NativeHashMap<int2,Entity> chunks;

    protected override void OnCreate()
    {
        chunks = new NativeHashMap<int2, Entity>(viewDistance * viewDistance, Allocator.Persistent);
    }
    protected override void OnUpdate()
    {



    }


    protected override void OnDestroy()
    {
        chunks.Dispose();


    }
    
}
