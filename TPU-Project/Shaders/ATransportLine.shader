// Made with Amplify Shader Editor
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "AShader/TransportLine"
{
	Properties
	{
		[HideInInspector] __dirty( "", Int ) = 1
		_MaskClipValue( "Mask Clip Value", Float ) = 0.5
		_Color("Color", Color) = (0,0,0,0)
		_Mask("Mask", 2D) = "white" {}
		_Speed("Speed", Range( 0 , 100)) = 1
		[HideInInspector] _texcoord( "", 2D ) = "white" {}
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
		uniform float4 _Mask_ST;
		uniform float _MaskClipValue = 0.5;

		inline fixed4 LightingUnlit( SurfaceOutput s, half3 lightDir, half atten )
		{
			return fixed4 ( 0, 0, 0, s.Alpha );
		}

		void surf( Input i , inout SurfaceOutput o )
		{
			o.Emission = _Color.rgb;
			float2 uv_Mask = i.uv_texcoord * _Mask_ST.xy + _Mask_ST.zw;
			o.Alpha = tex2D( _Mask, (abs( uv_Mask+( _Time.x * _Speed ) * float2(1,0 ))) ).a;
		}

		ENDCG
	}
	CustomEditor "ASEMaterialInspector"
}
/*ASEBEGIN
Version=12101
466;746;1377;642;1907.782;49.4843;1.6;False;True
Node;AmplifyShaderEditor.TimeNode;1;-1493.849,263.8883;Float;False;0;5;FLOAT4;FLOAT;FLOAT;FLOAT;FLOAT
Node;AmplifyShaderEditor.RangedFloatNode;13;-1560.088,467.0694;Float;False;Property;_Speed;Speed;3;0;1;0;100;0;1;FLOAT
Node;AmplifyShaderEditor.TextureCoordinatesNode;4;-1497.137,56.84271;Float;False;0;3;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;FLOAT;FLOAT;FLOAT;FLOAT
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;14;-940.8625,282.5692;Float;False;2;2;0;FLOAT;0.0;False;1;FLOAT;0,0;False;1;FLOAT
Node;AmplifyShaderEditor.PannerNode;2;-822.9763,120.646;Float;False;1;0;2;0;FLOAT2;0,0;False;1;FLOAT;0.0;False;1;FLOAT2
Node;AmplifyShaderEditor.ColorNode;5;-509.4969,-94.9997;Float;False;Property;_Color;Color;1;0;0,0,0,0;0;5;COLOR;FLOAT;FLOAT;FLOAT;FLOAT
Node;AmplifyShaderEditor.SamplerNode;3;-556.4118,105.4635;Float;True;Property;_Mask;Mask;2;0;Assets/AmplifyShaderEditor/Examples/Community/2Sided/2smask.png;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;1.0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1.0;False;5;FLOAT4;FLOAT;FLOAT;FLOAT;FLOAT
Node;AmplifyShaderEditor.StandardSurfaceOutputNode;0;-155,-135.2399;Float;False;True;2;Float;ASEMaterialInspector;0;Unlit;AShader/TransportLine;False;False;False;False;False;False;False;False;False;False;False;False;False;False;True;False;False;Back;2;7;False;0;0;Custom;0.5;True;False;0;False;Transparent;AlphaTest;All;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;False;0;255;255;0;0;0;0;False;0;4;10;25;False;0.5;False;1;SrcAlpha;One;1;SrcAlpha;One;Add;Add;0;False;0;0,0,0,0;VertexOffset;False;Cylindrical;False;Relative;0;;0;-1;-1;-1;0;0;14;0;FLOAT3;0,0,0;False;1;FLOAT3;0,0,0;False;2;FLOAT3;0,0,0;False;3;FLOAT;0.0;False;4;FLOAT;0.0;False;6;FLOAT3;0,0,0;False;7;FLOAT3;0,0,0;False;8;FLOAT;0.0;False;9;FLOAT;0.0;False;10;OBJECT;0.0;False;11;FLOAT3;0,0,0;False;12;FLOAT3;0,0,0;False;14;FLOAT4;0,0,0,0;False;15;FLOAT3;0,0,0;False;0
WireConnection;14;0;1;1
WireConnection;14;1;13;0
WireConnection;2;0;4;0
WireConnection;2;1;14;0
WireConnection;3;1;2;0
WireConnection;0;2;5;0
WireConnection;0;9;3;4
ASEEND*/
//CHKSM=DEB361395869C133140D8624F046AB8CD7DCA69A