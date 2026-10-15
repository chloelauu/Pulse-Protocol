/******************************************************************************/
/**
 * @file        font_fs.frag
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

#version 450 core
in vec2 TexCoords;
out vec4 color;
uniform sampler2D text;
uniform vec4 textColor;
void main() {
    float mask = texture(text, TexCoords).r;   // <- RED channel
    color = vec4(textColor.rgb, textColor.a * mask);
}
