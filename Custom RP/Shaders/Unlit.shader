Shader "Custom RP/Unlit"
{
    Properties
    {
        _BaseColor("Color", color) = (1.0,1.0,1.0,1.0)
    }
    SubShader
    {
        Pass
        {
            HLSLPROGRAM
            #include "UnlitPass.hlsl"
            #pragma multi_compile_instancing
            #pragma vertex UnlitPassVertex
            #pragma fragment UnlitPassFragment
            ENDHLSL
        }
    }
}