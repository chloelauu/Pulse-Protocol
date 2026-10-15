/******************************************************************************/
/**
 * @file        font_vs.vert
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

#version 450 core
layout(location=0) in vec2 aPos;
layout(location=1) in vec2 aUV;
out vec2 TexCoords;
uniform mat4 projection;
void main() {
    TexCoords   = aUV;
    gl_Position = projection * vec4(aPos, 0.0, 1.0);
}
