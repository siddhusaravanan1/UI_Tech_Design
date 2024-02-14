using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
    private Material healthBarMaterial;

    [Range(0,1)]
    public float healthBarPercentage = 1f;
    public Color healthBarMaxColor = new(0f, 0.6f, 1f);
    public Color healthBarMinColor = new(1.0f, 0.2f, 0f);

    private float radius = 1.55f;
    private float radialArc = 1.6f;
    private float radialRotation = 111.9193f;
    private float padding = 2.31f;

    private readonly string healthBar = "_Fill";
    private readonly string healthBarColorDirective = "_Color";
    private readonly string healthBarMaxColorDirective = "_MaxColor";
    private readonly string healthBarMinColorDirective = "_MinColor";
    private readonly string radiusDirective = "_Radius";
    private readonly string radialArcDirective = "_Arc";
    private readonly string radialRotationDirective = "_Rotation";
    private readonly string paddingDirective = "_Padding";

    void Start()
    {
        healthBarMaterial = GetComponent<RawImage>().material;
        healthBarMaterial.SetFloat(radiusDirective, radius);
        healthBarMaterial.SetFloat(radialArcDirective, radialArc);
        healthBarMaterial.SetFloat(radialRotationDirective, radialRotation);
        healthBarMaterial.SetFloat(paddingDirective, padding);
        healthBarMaterial.SetColor(healthBarMaxColorDirective, healthBarMaxColor);
        healthBarMaterial.SetColor(healthBarMinColorDirective, healthBarMinColor);
    }

    void Update()
    {
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        Color healthBarColor = Color.Lerp(healthBarMinColor, healthBarMaxColor, healthBarPercentage);
        healthBarMaterial.SetColor(healthBarColorDirective, healthBarColor);
        healthBarMaterial.SetFloat(healthBar, healthBarPercentage);

    }
}
