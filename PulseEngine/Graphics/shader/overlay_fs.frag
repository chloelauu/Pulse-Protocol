/******************************************************************************/
/**
 * @file        overlay_fs.frag
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

#version 450 core

layout(location = 0) out vec4 fragColor;

uniform vec4 uOverlayColor;

void main()
{
    fragColor = uOverlayColor;
}
