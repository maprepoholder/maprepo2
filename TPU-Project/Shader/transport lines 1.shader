// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Shader created with Shader Forge v1.35 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.35;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:False,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.005,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:1,x:33374,y:32522,varname:node_1,prsc:2|emission-7354-OUT,alpha-2-A;n:type:ShaderForge.SFN_Tex2d,id:2,x:32935,y:32849,ptovrint:False,ptlb:Gradient,ptin:_Gradient,varname:node_9515,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7e33f204b09faa6478b77f0fb0640903,ntxv:0,isnm:False|UVIN-87-UVOUT;n:type:ShaderForge.SFN_Color,id:3,x:32469,y:32497,ptovrint:False,ptlb:color,ptin:_color,varname:node_5275,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4016066,c2:0,c3:1,c4:1;n:type:ShaderForge.SFN_Panner,id:87,x:32584,y:32775,varname:node_87,prsc:2,spu:-1,spv:0|UVIN-565-OUT,DIST-5-OUT;n:type:ShaderForge.SFN_TexCoord,id:523,x:32136,y:32613,varname:node_523,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:565,x:32392,y:32775,varname:node_565,prsc:2|A-523-UVOUT,B-9986-OUT;n:type:ShaderForge.SFN_Multiply,id:7354,x:32947,y:32521,varname:node_7354,prsc:2|A-5190-OUT,B-2240-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9986,x:32095,y:32863,ptovrint:False,ptlb:Tile,ptin:_Tile,varname:node_9986,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:3995,x:32237,y:33033,ptovrint:False,ptlb:SpeedMove,ptin:_SpeedMove,varname:node_3995,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Time,id:2957,x:32237,y:33103,varname:node_2957,prsc:2;n:type:ShaderForge.SFN_Multiply,id:5,x:32450,y:33045,varname:node_5,prsc:2|A-3995-OUT,B-2957-T;n:type:ShaderForge.SFN_Slider,id:2240,x:32584,y:32666,ptovrint:False,ptlb:Emission,ptin:_Emission,varname:node_2240,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Tex2d,id:5756,x:32469,y:32315,ptovrint:False,ptlb:Image,ptin:_Image,varname:node_5756,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_SwitchProperty,id:5190,x:32712,y:32497,ptovrint:False,ptlb:UseColor,ptin:_UseColor,varname:node_5190,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-5756-RGB,B-3-RGB;proporder:3-5756-5190-2-9986-3995-2240;pass:END;sub:END;*/

Shader "Sample/TransportLines_new" {
    Properties {
        _color ("color", Color) = (0.4016066,0,1,1)
        _Image ("Image", 2D) = "white" {}
        [MaterialToggle] _UseColor ("UseColor", Float ) = 0
        _Gradient ("Gradient", 2D) = "white" {}
        _Tile ("Tile", Float ) = 1
        _SpeedMove ("SpeedMove", Float ) = 0
        _Emission ("Emission", Range(0, 1)) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _Gradient; uniform float4 _Gradient_ST;
            uniform float4 _color;
            uniform float _Tile;
            uniform float _SpeedMove;
            uniform float _Emission;
            uniform sampler2D _Image; uniform float4 _Image_ST;
            uniform fixed _UseColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos(v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 _Image_var = tex2D(_Image,TRANSFORM_TEX(i.uv0, _Image));
                float3 emissive = (lerp( _Image_var.rgb, _color.rgb, _UseColor )*_Emission);
                float3 finalColor = emissive;
                float4 node_2957 = _Time + _TimeEditor;
                float2 node_87 = ((i.uv0*_Tile)+(_SpeedMove*node_2957.g)*float2(-1,0));
                float4 _Gradient_var = tex2D(_Gradient,TRANSFORM_TEX(node_87, _Gradient));
                fixed4 finalRGBA = fixed4(finalColor,_Gradient_var.a);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
