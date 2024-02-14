float4 RadialHealthBar(float2 uvs,        
                       float health,     
                       float radius,      
                       float arc,         
                       float3 maxHealthColor, 
                       float3 minHealthColor,
                       float padding,
                       float mask,
                       float maskOpacity)     // Added mask parameter for alpha control
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

    // Use mask for alpha. If inArc is true, use mask value; otherwise, make it fully transparent.
    float alpha = inArc ? mask : lerp(0, maskOpacity, mask);

    // Return color with alpha based on inArc condition and mask
    return float4(color, alpha);
}
