/******************************************************************************/
/**
 * @file        TestAPI.h
 * @project     Pulse Protocol
 *
 * @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
 *              Reproduction or disclosure of this file or its contents without the
 *              prior written consent of DigiPen Institute of Technology is prohibited.
 */
/******************************************************************************/

#ifndef TESTAPI_H
#define TESTAPI_H

namespace ScriptAPI
{
    // This is a C++/CLI class (note the "ref class")
    public ref class TestAPI
    {
    public:
        static void SayHello();
    };
}

#endif // !TESTAPI_H