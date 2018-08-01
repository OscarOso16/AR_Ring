Shader "Custom/CrossSectionShader" {
	Properties {
		_Color ("Main Color", Color) = (1,1,1,1)
		_MainTex ("Main Texture", 2D) = "white" {}

		_ClippingX ("Clipping X", Float) = 0.0
		_ClippingY ("Clipping Y", Float) = 0.0
		_ClippingZ ("Clipping Z", Float) = 0.0

		_DirectionX ("Direction of Clipping on X", Range(-1,1)) = -1.0
		_DirectionY ("Direction of Clipping on Y", Range(-1,1)) = -1.0
		_DirectionZ ("Direction of Clipping on Z", Range(-1,1)) = -1.0

		//_BumpMap ("BumpMap", 2D) = "bump" {}
		//_Glossiness ("Smoothness", Range(0,1)) = 0.5
		//_Metallic ("Metallic", Range(0,1)) = 0.0
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		Cull Off
		
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Lambert vertex:vert

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0
	
		sampler2D _MainTex;
		//sampler2D _BumpMap;
		fixed4 _Color;
		float _ClippingX;
		float _ClippingY;
		float _ClippingZ;
		float _DirectionX;
		float _DirectionY;
		float _DirectionZ;

		struct Input {
			float2 uv_MainTex;
			float2 uv_BumpMap;
			float3 localPos;
		};


		void vert (inout appdata_full v, out Input o){
			UNITY_INITIALIZE_OUTPUT(Input, o);
			o.localPos = v.vertex.xyz;
		}

		void surf (Input IN, inout SurfaceOutput o) {
			IN.localPos.x = (IN.localPos.x - _ClippingX) * _DirectionX;
			IN.localPos.y = (IN.localPos.y - _ClippingY) * _DirectionY;
			IN.localPos.z = (IN.localPos.z - _ClippingZ) * _DirectionZ;
			clip(IN.localPos);
			
			//fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = _Color.rgb;
			o.Alpha = _Color.a;
			//o.Albedo = tex2D(_MainTex, IN.uv_MainTex).rgb;
			//o.Normal = UnpackNormal(tex2D (_BumpMap, IN.uv_BumpMap));
		}
		ENDCG
	}
	FallBack "Diffuse"
}
