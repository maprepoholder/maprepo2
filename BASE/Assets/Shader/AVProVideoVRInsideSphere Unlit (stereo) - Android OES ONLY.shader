Shader "AVProVideo/VR/InsideSphere Unlit (stereo) - Android OES ONLY" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "black" {}
		_Color ("Color", Vector) = (0,1,0,1)
		[KeywordEnum(None, Top_Bottom, Left_Right, Custom_UV)] Stereo ("Stereo Mode", Float) = 0
		[Toggle(STEREO_DEBUG)] _StereoDebug ("Stereo Debug Tinting", Float) = 0
		[Toggle(APPLY_GAMMA)] _ApplyGamma ("Apply Gamma", Float) = 0
	}
	SubShader {
		Tags { "QUEUE" = "Geometry" }
		Pass {
			Tags { "QUEUE" = "Geometry" }
			ZWrite Off
			Cull Front
			GpuProgramID 9024
		}
	}
	Fallback "AVProVideo/VR/InsideSphere Unlit (stereo+fog)"
}