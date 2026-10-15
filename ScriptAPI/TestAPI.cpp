/******************************************************************************/
/**
 * @file        TestAPI.cpp
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

#include "TestAPI.h"

#include <iostream>

namespace ScriptAPI
{
    void TestAPI::SayHello()
    {
        std::cout << "[C++/CLI Bridge] Hello from ScriptAPI!" << std::endl;
    }

}