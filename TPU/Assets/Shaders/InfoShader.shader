// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'
// Upgrade NOTE: replaced '_World2Object' with 'unity_WorldToObject'

// Shader created with Shader Forge Beta 0.27 
// Shader Forge (c) Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:0.27;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,limd:1,uamb:True,mssp:True,lmpd:False,lprd:False,enco:False,frtr:True,vitr:True,dbil:False,rmgx:True,hqsc:True,hqlp:False,blpr:3,bsrc:0,bdst:6,culm:0,dpts:6,wrdp:False,ufog:False,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.0025,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:1,x:32119,y:32432|emission-462-OUT;n:type:ShaderForge.SFN_Tex2d,id:75,x:33007,y:32731,ptlb:dot map,ptin:_dotmap,tex:e56750f2f616a484681cc22eb8fe1530,ntxv:0,isnm:False|UVIN-82-OUT;n:type:ShaderForge.SFN_ScreenPos,id:81,x:33656,y:32628,sctp:0;n:type:ShaderForge.SFN_Multiply,id:82,x:33221,y:32678|A-100-UVOUT,B-83-OUT;n:type:ShaderForge.SFN_Vector2,id:83,x:33420,y:32830,v1:5,v2:5;n:type:ShaderForge.SFN_Panner,id:100,x:33476,y:32628,spu:0,spv:0.02|UVIN-81-UVOUT;n:type:ShaderForge.SFN_Color,id:395,x:33007,y:32558,ptlb:diff color,ptin:_diffcolor,glob:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:396,x:32749,y:32692|A-395-RGB,B-75-A;n:type:ShaderForge.SFN_Fresnel,id:427,x:32811,y:32346|EXP-451-OUT;n:type:ShaderForge.SFN_Multiply,id:438,x:32603,y:32326|A-440-RGB,B-427-OUT;n:type:ShaderForge.SFN_Color,id:440,x:32899,y:32176,ptlb:fresnel color,ptin:_fresnelcolor,glob:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Slider,id:451,x:33028,y:32402,ptlb:fresnel pow,ptin:_fresnelpow,min:0,cur:0.2126882,max:1;n:type:ShaderForge.SFN_Add,id:462,x:32579,y:32531|A-438-OUT,B-396-OUT;proporder:75-395-440-451;pass:END;sub:END;*/

Shader "CustomShader/InfoShader" {
    Properties {
        _dotmap ("dot map", 2D) = "white" {}
        _diffcolor ("diff color", Color) = (1,0,0,1)
        _fresnelcolor ("fresnel color", Color) = (1,0,0,1)
        _fresnelpow ("fresnel pow", Range(0, 1)) = 0.2126882
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "ForwardBase"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One OneMinusSrcColor
            ZTest Always
            ZWrite Off
            
            Fog {Mode Off}
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers xbox360 ps3 flash 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _dotmap; uniform float4 _dotmap_ST;
            uniform float4 _diffcolor;
            uniform float4 _fresnelcolor;
            uniform float _fresnelpow;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float4 screenPos : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o;
                o.normalDir = mul(float4(v.normal,0), unity_WorldToObject).xyz;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos(v.vertex);
                o.screenPos = o.pos;
                return o;
            }
            fixed4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
/////// Normals:
                float3 normalDirection =  i.normalDir;
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
////// Lighting:
////// Emissive:
                float4 node_471 = _Time + _TimeEditor;
                float2 node_82 = ((i.screenPos.rg+node_471.g*float2(0,0.02))*float2(5,5));
                float3 emissive = ((_fresnelcolor.rgb*pow(1.0-max(0,dot(normalDirection, viewDirection)),_fresnelpow))+(_diffcolor.rgb*tex2D(_dotmap,TRANSFORM_TEX(node_82, _dotmap)).a));
                float3 finalColor = emissive;
/// Final Color:
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
