#include <metal_stdlib>
#include <simd/simd.h>

using namespace metal;

typedef struct
{
    float4 anArray [[position]];
    float4 aValue;

} SomeData;

fragment float4 fragmentShader(SomeData in [[stage_in]])
{
    return in.aValue;
}
