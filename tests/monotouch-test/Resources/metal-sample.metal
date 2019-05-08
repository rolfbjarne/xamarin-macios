#include <metal_stdlib>
#include <simd/simd.h>

using namespace metal;

typedef struct
{
    float4 anArray [[position]];
    float4 aValue;

} SomeData;

typedef struct
{
    vector_float2 position;
    vector_float2 textureCoordinate;
} SomeVertex;

fragment float4 fragmentShader(SomeData in [[stage_in]])
{
    return in.aValue;
}

kernel void
grayscaleKernel(texture2d<half, access::read>  inTexture  [[texture(0)]],
                texture2d<half, access::write> outTexture [[texture(1)]],
                uint2                          gid         [[thread_position_in_grid]])
{
}

struct Foo {
	int h;
};

kernel void
kernelWithArgumentBuffer (constant Foo & f [[buffer(0)]])
{
}

struct arguments {
	int cmd_buffer;
};
kernel void
kernelWithArgumentBuffer2 (device arguments &args [[buffer(0)]])
{
}


vertex SomeData
vertexShader (uint vertexID [[ vertex_id ]],
             constant SomeVertex *vertexArray [[ buffer(0) ]],
             constant vector_uint2 *viewportSizePointer  [[ buffer(1) ]])

{
    SomeData out;
    return out;
}













struct SomeData2
{
    float4 position [[ position ]];
    float2 texcoord;
};

struct SomeInputs {
    texture2d<float> snapshotTexture;
    texture2d<float> cameraTexture;
    sampler textureSampler;
    float time;
};

fragment float4
fragmentShader2(SomeData2 in [[ stage_in ]], constant SomeInputs &inputs [[ buffer(0) ]])
{
    float4 color = { 0 };
    return color;
}