using System;
using UnityEngine;

[DisallowMultipleComponent]
public class PerObjectMaterialProperties : MonoBehaviour
{
    private static MaterialPropertyBlock block;
    private static int
        basedColorId = Shader.PropertyToID("_BaseColor"),
        cutoffId = Shader.PropertyToID("_Cutoff"),
        metallicId = Shader.PropertyToID("_Metallic"),
        smoothnessId = Shader.PropertyToID("_Smoothness");

    [SerializeField] Color baseColor = Color.white;
    [SerializeField, Range(0f, 1f)]
    float alphaCutoff = 0.5f, metallic = 0f, smoothness = 0.5f;

    private void OnValidate()
    {
        if (block == null)
        {
            block = new MaterialPropertyBlock();
        }
        block.SetColor(basedColorId, baseColor);
        block.SetFloat(cutoffId, alphaCutoff);
        block.SetFloat(metallicId, metallic);
        block.SetFloat(smoothnessId, smoothness);
        GetComponent<Renderer>().SetPropertyBlock(block);
    }

    private void Awake()
    {
        OnValidate();
    }
}