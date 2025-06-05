using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UIShaderMaterialAnimator : MonoBehaviour
{
    [Header("Animatable Values")]
    public float blur = 0f;
    public Color tintColor = Color.white;

    private Material runtimeMaterial;

    void Awake()
    {
        // Create an instance of the material to not modify the global one
        Image image = GetComponent<Image>();
        runtimeMaterial = Instantiate(image.material);
        image.material = runtimeMaterial;
    }

    void Update()
    {
        if (runtimeMaterial != null)
        {
            runtimeMaterial.SetFloat("_Multiplier", blur);
            runtimeMaterial.SetColor("_Color", tintColor);
        }
    }
}
