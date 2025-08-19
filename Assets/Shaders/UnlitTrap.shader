// Spherical Spiral Shader 2023 - Copyright © MyDragonBreath 2025, All Rights Reserved
Shader "Custom/UnlitTrap"
{
    Properties
    {
		_ForegroundColor("Foreground Color", Color) = (1,1,1,1)
		_BackgroundColor("Background Color", Color) = (0,0,0,1)
		_Density("Density", Range(0.1,500)) = 30
		_Tiling("Tiling", Range(1, 500)) = 10
		_Direction("Direction", Range(0, 1)) = 0
		_Speed("Speed", Range(0.1, 50)) = 30
		_OutlineColor("Outline Color", Color) = (1,0,1,1)
		_OutlineThickness("Outline Thickness", Range(0,1)) = 0.1
    }
    SubShader
    {
		Tags {"Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Transparent"}
		ZWrite Off
		Blend SrcAlpha OneMinusSrcAlpha
        LOD 100

		Pass {
				//OUTLINE OVERLAY
			CGPROGRAM
				#include "UnityCG.cginc"
				#pragma vertex vert alpha
				#pragma fragment frag alpha

				fixed4 _OutlineColor;
				float _OutlineThickness;

				struct appdata {
					float4 vertex : POSITION;
					float4 normal : NORMAL;
				};

				struct v2f {
					float4 position : SV_POSITION;
				};

				v2f vert(appdata v) {
					v2f o;
					o.position = UnityObjectToClipPos(v.vertex + normalize(v.normal) * _OutlineThickness);
					return o;
				}

				fixed4 frag(v2f i) : SV_TARGET{
					return _OutlineColor;
				};
			ENDCG
		}

        Pass
        {
				//STRIPES
            CGPROGRAM
			#pragma vertex vert alpha
			#pragma fragment frag alpha
			#include "UnityCG.cginc"



			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			float _Density;
			float _Direction;
			int _Tiling;
			float _Speed;
			fixed4 _ForegroundColor;
			fixed4 _BackgroundColor;

			v2f vert(float4 pos : POSITION, float2 uv : TEXCOORD0)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(pos);
				o.uv = uv * _Density;
				return o;
			}

			fixed4 frag(v2f i) : SV_Target
			{
				float t = _Time * _Speed;
				float pos = lerp(i.uv.x + t, i.uv.y + t, _Direction) * _Tiling;
				fixed value = floor(frac(pos) + 0.5);
				return lerp(_ForegroundColor, _BackgroundColor, value);
			}

            ENDCG
        }

		
    }
}
