using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Jobs;
using Unity.Collections;
using Unity.Mathematics;

using static Unity.Mathematics.math;
using Unity.Burst;

[BurstCompile]
public class CPUNoiseJob : IJobParallelFor
{
    int SizeX;

   [WriteOnly] NativeArray<float4> voxelData;

    public void Execute(int i)
    {
        int x = i % SizeX;
        int y = i / SizeX;

        float3 density;


        density = noise.srdnoise(float2(x, y)/16);

        voxelData[x + y * SizeX] = float4(density,0);

    }
}
