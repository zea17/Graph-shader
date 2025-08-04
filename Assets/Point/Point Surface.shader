Shader "Graph/PointSurface" {
    SubShader {
        CGPROGRAM
        #pragma surface ConfigureSurface Standard fullforwardshadows

        struct Input {
            float3 worldPos;
        };

        void ConfigureSurface (Input IN, inout SurfaceOutputStandard o) {

            o.Albedo.rgb = saturate(IN.worldPos * 0.5 + 0.5);
            o.Smoothness = 0.5;
        }
        ENDCG
    }
    FallBack "Diffuse"
}