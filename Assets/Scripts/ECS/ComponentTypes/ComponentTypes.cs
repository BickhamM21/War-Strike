using Unity.Entities;
using Unity.Mathematics;


[InternalBufferCapacity(4096)]
struct VoxelData : IBufferElementData {
    float4 value;
}
