# ============================================================================
# @file        Utilities.cmake
# @project     Pulse Protocol
#
# @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
#              Reproduction or disclosure of this file or its contents without the
#              prior written consent of DigiPen Institute of Technology is prohibited.
# ============================================================================

# Define a macro to group source and header files by directory
macro(GROUP_FILES_BY_FOLDER all_files)
    foreach(FILE ${ALL_FILES}) 
        # Get the directory of the file
        get_filename_component(PARENT_DIR "${FILE}" PATH)

        # Replace '/' with '\' for Visual Studio group formatting
        string(REPLACE "/" "\\" GROUP "${PARENT_DIR}")

        # Classify files into Source or Header groups based on their extension
        #if ("${FILE}" MATCHES ".*\\.cpp")
        #set(GROUP "Source Files\\${GROUP}")
        #elseif("${FILE}" MATCHES ".*\\.h")
        #set(GROUP "Header Files\\${GROUP}")
        #endif()

        # Add the file to the corresponding source group
        source_group("${GROUP}" FILES "${FILE}")
    endforeach()
endmacro()