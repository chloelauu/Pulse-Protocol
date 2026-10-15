/******************************************************************************/
/**
 * @file        bg_fs.frag
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

#version 450 core
	layout (location=0) in vec4 vColor;
    	layout (location=1) in vec2 vTex;

	layout (location=0) out vec4 color;
    	uniform sampler2D uTex;

	void main () {
        vec4 texColor = texture(uTex, vTex);
        color = texColor * vColor;
        if(color.a < 0.01)
            discard;
	}
