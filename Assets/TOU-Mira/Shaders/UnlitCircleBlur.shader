Shader "Custom/UnlitCircleBlur"
{
    Properties
    {
        _Radius ("Radius", Float) = 1.0
        _Thickness ("Thickness", Float) = 0.1
        _InnerColor ("InnerColor", Color) = (1,1,1,0.5)
        _OuterColor ("OuterColor", Color) = (1,1,1,1)
    }
    SubShader
    {
        Tags
        {
            "RenderType"="Opaque"
        }
        LOD 100

        ZWrite Off
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            float _Radius;
            float _Thickness;
            float4 _InnerColor;
            float4 _OuterColor;

            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            float4 Ellipse(float2 UV, float Scale)
            {
                const float d = length((UV * 2 - 1) / float2(Scale, Scale));
                return saturate((1 - d) / fwidth(d));
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float4 bigger = Ellipse(i.uv, _Radius);
                float4 smaller = Ellipse(i.uv, _Radius - _Thickness);

                float4 border = (bigger - smaller) * _OuterColor;
                float4 inner = smaller * _InnerColor;
                return border + inner;
            }
            ENDCG
        }
    }
}