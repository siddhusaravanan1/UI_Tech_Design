using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SmoothMoveTextMeshPro : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private float moveDuration = 1f;

    private Vector3 initialPosition;
    private Vector3 targetPosition;

    private void Start()
    {
        initialPosition = textMeshPro.transform.localPosition;
        CalculateTargetPosition();
    }

    private void Update()
    {
        float progress = Mathf.Clamp01(Time.time / moveDuration);
        textMeshPro.transform.localPosition = Vector3.SmoothDamp(initialPosition, targetPosition, ref initialPosition, moveDuration * progress);
    }

    private void CalculateTargetPosition()
    {
        Vector2 referenceResolution = canvas.GetComponent<CanvasScaler>().referenceResolution;
        Vector2 screenResolution = new Vector2(Screen.width, Screen.height);

        float xOffset = (screenResolution.x - referenceResolution.x) / 2f;
        targetPosition = new Vector3(-xOffset, screenResolution.y - textMeshPro.rectTransform.sizeDelta.y - xOffset, textMeshPro.transform.localPosition.z);
    }
}