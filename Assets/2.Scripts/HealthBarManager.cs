using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarManager : MonoBehaviour
{
    [SerializeField]
    private Material healthBarMaterial;

    public float healthBarPercentage = 1f;
    public Color healthBarMaxColor = Color.green;
    public Color healthBarMinColor = Color.red;

    [SerializeField]
    private float radius = 1f;
    [SerializeField]
    private float radialArc = 7f; // Assuming degrees, Unity uses degrees for rotation
    [SerializeField]
    private float radialRotation = 0f; // Assuming degrees
    [SerializeField]
    private float padding = 1f;

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
        healthBarMaterial = GetComponent<SpriteRenderer>().material;
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
