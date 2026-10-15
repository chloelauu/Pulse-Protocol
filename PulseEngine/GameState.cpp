/******************************************************************************/
/**
 * @file        GameState.cpp
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

#include "GameState.h"

namespace Framework
{
    static bool gPlaying = false;

    bool GameState::IsPlaying() { return gPlaying; }
    void GameState::SetPlaying(bool playing) { gPlaying = playing; }
}