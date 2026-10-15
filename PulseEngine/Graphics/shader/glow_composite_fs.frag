/******************************************************************************/
/**
 * @file        glow_composite_fs.frag
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

#version 450 core

in  vec2 TexCoord;
out vec4 FragColor;

uniform sampler2D uGlowTex;
uniform float     uGlowIntensity;

void main()
{
    vec4 glow = texture(uGlowTex, TexCoord);
    FragColor = glow * uGlowIntensity;
}
