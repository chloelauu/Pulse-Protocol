/******************************************************************************/
/**
 * @file        test_vs.vert
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

#version 450 core
layout(location = 0) in vec2 aVertexPosition;
layout(location = 1) in vec3 aVertexColor;

layout(location = 0) out vec3 vColor;

uniform mat3 uModel_to_NDC;

void main() {
    gl_Position = vec4(vec2(uModel_to_NDC * vec3(aVertexPosition, 1.0)), 0.0, 1.0);
    vColor = aVertexColor;
}