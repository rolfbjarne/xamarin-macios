#include <metal_stdlib>
#include <simd/simd.h>

using namespace metal;

/* structs */

struct SomeData
{
    float4 anArray [[position]];
    float4 aValue;
};

struct SomeVertex
{
    vector_float2 position;
    vector_float2 textureCoordinate;
};

struct SomeData2
{
    float4 position [[ position ]];
    float2 texcoord;
};

struct SomeInputs {
    texture2d<float> texture;
    texture2d<float> anotherTexture;
    sampler textureSampler;
    float time;
};

/* functions */

kernel void
grayscaleKernel(texture2d<half, access::read>  inTexture  [[texture(0)]],
                texture2d<half, access::write> outTexture [[texture(1)]],
                uint2                          gid         [[thread_position_in_grid]])
{
}

vertex SomeData
vertexShader (uint vertexID [[ vertex_id ]],
              constant SomeVertex *vertexArray [[buffer(0)]],
              constant vector_uint2 *viewportSizePointer  [[buffer(1)]])
{
    SomeData out;
    return out;
}

// The following function needs min iOS version 10.0+, so we can't use it in monotouch-test (which currently has min iOS version 6.0)
// fragment float4
// fragmentShader2 (SomeData2 in [[stage_in]],
//                  constant SomeInputs &inputs [[buffer(0)]])
// {
//     float4 color = { 0, 0, 0, 0 };
//     return color;
// }
