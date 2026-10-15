/******************************************************************************/
/**
 * @file        sprite_vs.vert
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

#version 450 core

layout(location = 0) in vec2 aVertexPosition; // Vertex position
layout(location = 1) in vec4 aVertexColor;    // Tint color (RGBA)
layout(location = 2) in vec2 aTexture;        // Texture coordinates

layout(location = 0) out vec4 vColor;         // Output tint color
layout(location = 1) out vec2 vTex;           // Output texture coordinates

uniform mat3 uModel_to_NDC;                  // Model-to-NDC matrix
uniform vec2 uOffset;                        // UV offset for the current frame
uniform vec2 uScale;                         // UV scale for the current frame

void main() {
    gl_Position = vec4(vec2(uModel_to_NDC * vec3(aVertexPosition, 1.0)), 0.0, 1.0);
    vColor = aVertexColor;
    vTex = aTexture * uScale + uOffset; // Scale and offset UVs for animation
}
