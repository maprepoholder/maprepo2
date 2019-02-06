// Made with Amplify Shader Editor
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "AShader/TransportLineUse"
{
	Properties
	{
		_Color("Color", Color) = (0,0,0,0)
		_Mask("Mask", 2D) = "white" {}
		_Speed("Speed", Range( -10 , 10)) = 1
		[Toggle]_Revers("Revers", Float) = 0
		_MultiplyAlpha("MultiplyAlpha", Range( 1 , 10)) = 0
		[HideInInspector] _texcoord( "", 2D ) = "white" {}
		[HideInInspector] __dirty( "", Int ) = 1
	}

	SubShader
	{
		Tags{ "RenderType" = "Transparent"  "Queue" = "AlphaTest+0" "IgnoreProjector" = "True" "IsEmissive" = "true"  }
		Cull Back
		ZWrite Off
		ZTest Always
		Blend SrcAlpha One , SrcAlpha One
		BlendOp Add , Add
		CGPROGRAM
		#include "UnityShaderVariables.cginc"
		#pragma target 3.0
		#pragma surface surf Unlit keepalpha noshadow 
		struct Input
		{
			float2 uv_texcoord;
		};

		uniform float4 _Color;
		uniform sampler2D _Mask;
		uniform float _Speed;
		uniform float _Revers;
		uniform float4 _Mask_ST;
		uniform float _MultiplyAlpha;

		inline half4 LightingUnlit( SurfaceOutput s, half3 lightDir, half atten )
		{
			return half4 ( 0, 0, 0, s.Alpha );
		}

		void surf( Input i , inout SurfaceOutput o )
		{
			o.Emission = _Color.rgb;
			float2 uv_Mask = i.uv_texcoord * _Mask_ST.xy + _Mask_ST.zw;
			float2 panner2 = ( ( _Time.x * _Speed * lerp(-1.0,1.0,_Revers) ) * float2( 1,0 ) + uv_Mask);
			o.Alpha = ( tex2D( _Mask, panner2 ).a * _MultiplyAlpha );
		}

		ENDCG
	}
	CustomEditor "ASEMaterialInspector"
}
/*ASEBEGIN
Version=15401
2716;33;1761;1012;1843.01;369.3665;1.389833;True;True
Node;AmplifyShaderEditor.RangedFloatNode;19;-1689.673,696.6353;Float;False;Constant;_Float1;Float 1;4;0;Create;True;0;0;False;0;1;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;17;-1666.047,582.6693;Float;False;Constant;_Float0;Float 0;4;0;Create;True;0;0;False;0;-1;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.ToggleSwitchNode;18;-1383.911,571.5504;Float;False;Property;_Revers;Revers;4;0;Create;True;0;0;False;0;0;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.TimeNode;1;-1622.566,250.5291;Float;False;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;13;-1663.253,429.1423;Float;False;Property;_Speed;Speed;3;0;Create;True;0;0;False;0;1;-5;-10;10;0;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;14;-1141.746,369.6795;Float;False;3;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;4;-1548.561,22.09688;Float;False;0;3;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.PannerNode;2;-970.964,136.2935;Float;False;3;0;FLOAT2;0,0;False;2;FLOAT2;1,0;False;1;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SamplerNode;3;-613.3949,97.12457;Float;True;Property;_Mask;Mask;2;0;Create;True;0;0;False;0;None;c1ca93b4b62659d469b7493399c57479;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;1;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;21;-545.1429,376.9738;Float;False;Property;_MultiplyAlpha;MultiplyAlpha;5;0;Create;True;0;0;False;0;0;5;1;10;0;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;20;-235.2103,264.3973;Float;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RotatorNode;15;-1182.384,-38.58615;Float;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.ColorNode;5;-599.0273,-111.5879;Float;False;Property;_Color;Color;1;0;Create;True;0;0;False;0;0,0,0,0;0.9411765,0.7921569,0.3764705,1;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.StandardSurfaceOutputNode;0;38.1528,-196.3925;Float;False;True;2;Float;ASEMaterialInspector;0;0;Unlit;AShader/TransportLineUse;False;False;False;False;False;False;False;False;False;False;False;False;False;False;True;False;False;False;False;False;Back;2;False;-1;7;False;-1;False;0;False;-1;0;False;-1;False;0;Custom;0.5;True;False;0;True;Transparent;;AlphaTest;All;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;0;False;-1;False;0;False;-1;255;False;-1;255;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;False;0;4;10;25;False;0.5;False;1;5;False;-1;1;False;-1;1;5;False;-1;1;False;-1;0;False;-1;0;False;-1;0;False;0;0,0,0,0;VertexOffset;True;False;Cylindrical;False;Relative;0;;0;-1;-1;-1;0;False;0;0;False;-1;-1;0;False;-1;0;0;15;0;FLOAT3;0,0,0;False;1;FLOAT3;0,0,0;False;2;FLOAT3;0,0,0;False;3;FLOAT;0;False;4;FLOAT;0;False;6;FLOAT3;0,0,0;False;7;FLOAT3;0,0,0;False;8;FLOAT;0;False;9;FLOAT;0;False;10;FLOAT;0;False;13;FLOAT3;0,0,0;False;11;FLOAT3;0,0,0;False;12;FLOAT3;0,0,0;False;14;FLOAT4;0,0,0,0;False;15;FLOAT3;0,0,0;False;0
WireConnection;18;0;17;0
WireConnection;18;1;19;0
WireConnection;14;0;1;1
WireConnection;14;1;13;0
WireConnection;14;2;18;0
WireConnection;2;0;4;0
WireConnection;2;1;14;0
WireConnection;3;1;2;0
WireConnection;20;0;3;4
WireConnection;20;1;21;0
WireConnection;0;2;5;0
WireConnection;0;9;20;0
ASEEND*/
//CHKSM=E151AEE4591F6A7C2FC84E1C5F25E348237E9A95