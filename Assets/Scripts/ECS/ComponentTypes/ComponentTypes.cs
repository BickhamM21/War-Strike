using Unity.Entities;
using Unity.Mathematics;


[InternalBufferCapacity(4096)]
struct VoxelData : IBufferElementData {
    float value;
    float3 normal;
    int material;
}
