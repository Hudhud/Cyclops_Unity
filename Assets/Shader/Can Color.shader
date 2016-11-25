Shader "Shader/Can Color" {
	Properties{
		_CanTexture("Texture", 2D) = "red" {}
	}
		SubShader{
		Tags{ "RenderType" = "Opaque" }
		CGPROGRAM
#pragma surface surf Lambert
		struct Input {
		float2 uv_CanTexture;
	};
	sampler2D _CanTexture;
	void surf(Input IN, inout SurfaceOutput o) {
		o.Albedo = tex2D(_CanTexture, IN.uv_CanTexture).rgb;
	}
	ENDCG
	}
		Fallback "Diffuse"
}