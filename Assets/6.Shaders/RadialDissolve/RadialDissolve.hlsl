// HLSL Pixel Shader for Radial Health Bar

float4 RadialHealthBar(float2 uvs,        // UV coordinates of the current pixel
                       float health,      // Current health value, normalized [0, 1]
                       float radius,      // Radius of the health bar
                       float arc,         // Total arc angle of the health bar (in radians)
                       float3 maxHealthColor, // Color when health is full
                       float3 minHealthColor, // Color when health is at minimum
                       float rotation,    // Rotation of the health bar (in radians)
                       float padding)     // Padding inside the health bar circle
                       : SV_Target
{
    // Center the UV coordinates (assuming input UVs are [0, 1])
    float2 centeredUV = uvs * 2.0 - 1.0; // Now in range [-1, 1]

    // Calculate angle for the current pixel from the center
    float angle = atan2(centeredUV.y, centeredUV.x) + rotation;

    // Normalize angle to [0, 1]
    if(angle < 0.0) angle += 2.0 * 3.14159265359; // Add 2PI if negative
    angle /= arc; // Assuming arc is not more than 2PI

    // Calculate distance from center
    float dist = length(centeredUV);

    // Determine if the pixel is within the health bar's arc and radius
    bool inArc = angle <= health && dist <= radius && dist >= (radius - padding);

    // Calculate color based on health
    float3 color = lerp(minHealthColor, maxHealthColor, health);

    // Return color with alpha based on whether the pixel is in the arc
    return float4(inArc ? color : float3(0,0,0), inArc ? 1.0 : 0.0);
}
