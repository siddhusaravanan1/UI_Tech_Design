// HLSL Pixel Shader for Radial Health Bar

float4 RadialHealthBar(float2 uvs,        
                       float health,     
                       float radius,      
                       float arc,         
                       float3 maxHealthColor, 
                       float3 minHealthColor,
                       float rotation,
                       float padding)     
                       : SV_Target
{
    float2 centeredUV = uvs * 2.0 - 1.0;

    float angle = atan2(centeredUV.y, centeredUV.x) + rotation;

    if(angle < 0.0) angle += 2.0 * 3.14159265359; 
    angle /= arc;

    float dist = length(centeredUV);

    bool inArc = angle <= health && dist <= radius && dist >= (radius - padding);

    float3 color = lerp(minHealthColor, maxHealthColor, health);

    return float4(inArc ? color : float3(0,0,0), inArc ? 1.0 : 0.0);
}
