float4 RadialHealthBar(float2 uvs,        
                       float health,     
                       float radius,      
                       float arc,         
                       float3 maxHealthColor, 
                       float3 minHealthColor,
                       float padding)     
                       : SV_Target
{
    float2 centeredUV = uvs * 2.0 - 1.0;

    float angle = atan2(centeredUV.y, centeredUV.x);

    // Normalize angle to [0, 2*PI]
    if(angle < 0.0) angle += 2.0 * 3.14159265359; 
    if(angle > 2.0 * 3.14159265359) angle -= 2.0 * 3.14159265359;

    // Scale the angle based on the arc size
    angle /= (2.0 * 3.14159265359 / arc);

    float dist = length(centeredUV); // Distance from center

    // Calculate symmetric health coverage
    float startHealthAngle = 0.5 - (health / 2.0);
    float endHealthAngle = 0.5 + (health / 2.0);

    // Check if within symmetric health arc
    bool inArc = angle >= startHealthAngle && angle <= endHealthAngle && dist <= radius && dist >= (radius - padding);

    // Lerp color based on health
    float3 color = lerp(minHealthColor, maxHealthColor, health);

    // Return color with alpha based on inArc condition
    return float4(inArc ? color : float3(0,0,0), inArc ? 1.0 : 0.0);
}
