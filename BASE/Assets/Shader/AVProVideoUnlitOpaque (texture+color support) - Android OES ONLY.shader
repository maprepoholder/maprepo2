Shader "AVProVideo/Unlit/Opaque (texture+color support) - Android OES ONLY" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "black" {}
		_ChromaTex ("Chroma", 2D) = "gray" {}
		_Color ("Main Color", Vector) = (1,1,1,1)
		[KeywordEnum(None, Top_Bottom, Left_Right)] Stereo ("Stereo Mode", Float) = 0
		[Toggle(APPLY_GAMMA)] _ApplyGamma ("Apply Gamma", Float) = 0
	}
	SubShader {
		LOD 100
		Tags { "IGNOREPROJECTOR" = "False" "QUEUE" = "Geometry" "RenderType" = "Opaque" }
		Pass {
			LOD 100
			Tags { "IGNOREPROJECTOR" = "False" "QUEUE" = "Geometry" "RenderType" = "Opaque" }
			Cull Off
			GpuProgramID 29609
		}
	}
	Fallback "AVProVideo/Unlit/Opaque (texture+color+fog+stereo support)"
}