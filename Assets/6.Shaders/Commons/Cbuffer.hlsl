#ifndef CBUFFER_INCLUDED
#define CBUFFER_INCLUDED

CBUFFER_START(UnityPerMaterial)
    float4 _MainTex_ST;
    float4 _Color;
    half4 _RendererColor;
    half _Fill;
    half4 _MaxColor;
    half4 _MinColor;
    half _Radius;
    half _Arc;
    half _BarRotation;
    half _Padding;
    half _EmptyBarOpacity;
CBUFFER_END


#endif