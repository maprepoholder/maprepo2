// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:3,dpts:6,wrdp:False,dith:0,atcv:True,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.005,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:1,x:33307,y:32587,varname:node_1,prsc:2|emission-3-RGB,alpha-2-A;n:type:ShaderForge.SFN_Tex2d,id:2,x:32957,y:32778,ptovrint:False,ptlb:gradient,ptin:_gradient,varname:node_7754,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-87-UVOUT;n:type:ShaderForge.SFN_Color,id:3,x:32881,y:32432,ptovrint:False,ptlb:color,ptin:_color,varname:node_7606,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4016066,c2:0,c3:1,c4:1;n:type:ShaderForge.SFN_Panner,id:87,x:32719,y:32778,varname:node_87,prsc:2,spu:0,spv:-0.85|UVIN-565-OUT;n:type:ShaderForge.SFN_TexCoord,id:523,x:32285,y:32750,varname:node_523,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:565,x:32546,y:32868,varname:node_565,prsc:2|A-523-U,B-566-OUT;n:type:ShaderForge.SFN_Vector2,id:566,x:32363,y:32958,varname:node_566,prsc:2,v1:1,v2:6;proporder:3-2;pass:END;sub:END;*/

Shader "CustomShader/TransportLines" {
    Properties {
        _color ("color", Color) = (0.4016066,0,1,1)
        _gradient ("gradient", 2D) = "white" {}
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
            Blend One SrcAlpha
            ZTest Always
            ZWrite Off
            
            AlphaToMask On
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            uniform sampler2D _gradient; uniform float4 _gradient_ST;
            uniform float4 _color;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float3 emissive = _color.rgb;
                float3 finalColor = emissive;
                float4 node_5251 = _Time;
                float2 node_87 = ((i.uv0.r*float2(1,6))+node_5251.g*float2(0,-0.85));
                float4 _gradient_var = tex2D(_gradient,TRANSFORM_TEX(node_87, _gradient));
                return fixed4(finalColor,_gradient_var.a);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
