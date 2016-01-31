
' ========================================================================================== 

'                                                                                            

' FMOD Studio - C# Wrapper . Copyright (c), Firelight Technologies Pty, Ltd. 2004-2016.      

'                                                                                            

' ========================================================================================== 


Imports System.Text
Imports System.Runtime.InteropServices

Namespace FMOD
    '
    '        FMOD version number.  Check this against FMOD::System::getVersion / System_GetVersion
    '        0xaaaabbcc -> aaaa = major version number.  bb = minor version number.  cc = development version number.
    '    

    Public Class VERSION
        Public Const number As Integer = &H10705
#If WIN64 Then
		Public Const dll As String = "fmod64"
#Else
        Public Const dll As String = "fmod"
#End If
    End Class

    Public Class CONSTANTS
        Public Const MAX_CHANNEL_WIDTH As Integer = 32
        Public Const MAX_LISTENERS As Integer = 8
    End Class

    '
    '        FMOD types
    '    


    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        error codes.  Returned from every function.
    '
    '        [REMARKS]
    '
    '        [SEE_ALSO]
    '    ]
    '    

    Public Enum RESULT As Integer
        OK
        ' No errors. 
        ERR_BADCOMMAND
        ' Tried to call a function on a data type that does not allow this type of functionality (ie calling Sound::lock on a streaming sound). 
        ERR_CHANNEL_ALLOC
        ' Error trying to allocate a channel. 
        ERR_CHANNEL_STOLEN
        ' The specified channel has been reused to play another sound. 
        ERR_DMA
        ' DMA Failure.  See debug output for more information. 
        ERR_DSP_CONNECTION
        ' DSP connection error.  Connection possibly caused a cyclic dependency or connected dsps with incompatible buffer counts. 
        ERR_DSP_DONTPROCESS
        ' DSP return code from a DSP process query callback.  Tells mixer not to call the process callback and therefore not consume CPU.  Use this to optimize the DSP graph. 
        ERR_DSP_FORMAT
        ' DSP Format error.  A DSP unit may have attempted to connect to this network with the wrong format, or a matrix may have been set with the wrong size if the target unit has a specified channel map. 
        ERR_DSP_INUSE
        ' DSP is already in the mixer's DSP network. It must be removed before being reinserted or released. 
        ERR_DSP_NOTFOUND
        ' DSP connection error.  Couldn't find the DSP unit specified. 
        ERR_DSP_RESERVED
        ' DSP operation error.  Cannot perform operation on this DSP as it is reserved by the system. 
        ERR_DSP_SILENCE
        ' DSP return code from a DSP process query callback.  Tells mixer silence would be produced from read, so go idle and not consume CPU.  Use this to optimize the DSP graph. 
        ERR_DSP_TYPE
        ' DSP operation cannot be performed on a DSP of this type. 
        ERR_FILE_BAD
        ' Error loading file. 
        ERR_FILE_COULDNOTSEEK
        ' Couldn't perform seek operation.  This is a limitation of the medium (ie netstreams) or the file format. 
        ERR_FILE_DISKEJECTED
        ' Media was ejected while reading. 
        ERR_FILE_EOF
        ' End of file unexpectedly reached while trying to read essential data (truncated?). 
        ERR_FILE_ENDOFDATA
        ' End of current chunk reached while trying to read data. 
        ERR_FILE_NOTFOUND
        ' File not found. 
        ERR_FORMAT
        ' Unsupported file or audio format. 
        ERR_HEADER_MISMATCH
        ' There is a version mismatch between the FMOD header and either the FMOD Studio library or the FMOD Low Level library. 
        ERR_HTTP
        ' A HTTP error occurred. This is a catch-all for HTTP errors not listed elsewhere. 
        ERR_HTTP_ACCESS
        ' The specified resource requires authentication or is forbidden. 
        ERR_HTTP_PROXY_AUTH
        ' Proxy authentication is required to access the specified resource. 
        ERR_HTTP_SERVER_ERROR
        ' A HTTP server error occurred. 
        ERR_HTTP_TIMEOUT
        ' The HTTP request timed out. 
        ERR_INITIALIZATION
        ' FMOD was not initialized correctly to support this function. 
        ERR_INITIALIZED
        ' Cannot call this command after System::init. 
        ERR_INTERNAL
        ' An error occurred that wasn't supposed to.  Contact support. 
        ERR_INVALID_FLOAT
        ' Value passed in was a NaN, Inf or denormalized float. 
        ERR_INVALID_HANDLE
        ' An invalid object handle was used. 
        ERR_INVALID_PARAM
        ' An invalid parameter was passed to this function. 
        ERR_INVALID_POSITION
        ' An invalid seek position was passed to this function. 
        ERR_INVALID_SPEAKER
        ' An invalid speaker was passed to this function based on the current speaker mode. 
        ERR_INVALID_SYNCPOINT
        ' The syncpoint did not come from this sound handle. 
        ERR_INVALID_THREAD
        ' Tried to call a function on a thread that is not supported. 
        ERR_INVALID_VECTOR
        ' The vectors passed in are not unit length, or perpendicular. 
        ERR_MAXAUDIBLE
        ' Reached maximum audible playback count for this sound's soundgroup. 
        ERR_MEMORY
        ' Not enough memory or resources. 
        ERR_MEMORY_CANTPOINT
        ' Can't use FMOD_OPENMEMORY_POINT on non PCM source data, or non mp3/xma/adpcm data if FMOD_CREATECOMPRESSEDSAMPLE was used. 
        ERR_NEEDS3D
        ' Tried to call a command on a 2d sound when the command was meant for 3d sound. 
        ERR_NEEDSHARDWARE
        ' Tried to use a feature that requires hardware support. 
        ERR_NET_CONNECT
        ' Couldn't connect to the specified host. 
        ERR_NET_SOCKET_ERROR
        ' A socket error occurred.  This is a catch-all for socket-related errors not listed elsewhere. 
        ERR_NET_URL
        ' The specified URL couldn't be resolved. 
        ERR_NET_WOULD_BLOCK
        ' Operation on a non-blocking socket could not complete immediately. 
        ERR_NOTREADY
        ' Operation could not be performed because specified sound/DSP connection is not ready. 
        ERR_OUTPUT_ALLOCATED
        ' Error initializing output device, but more specifically, the output device is already in use and cannot be reused. 
        ERR_OUTPUT_CREATEBUFFER
        ' Error creating hardware sound buffer. 
        ERR_OUTPUT_DRIVERCALL
        ' A call to a standard soundcard driver failed, which could possibly mean a bug in the driver or resources were missing or exhausted. 
        ERR_OUTPUT_FORMAT
        ' Soundcard does not support the specified format. 
        ERR_OUTPUT_INIT
        ' Error initializing output device. 
        ERR_OUTPUT_NODRIVERS
        ' The output device has no drivers installed.  If pre-init, FMOD_OUTPUT_NOSOUND is selected as the output mode.  If post-init, the function just fails. 
        ERR_PLUGIN
        ' An unspecified error has been returned from a plugin. 
        ERR_PLUGIN_MISSING
        ' A requested output, dsp unit type or codec was not available. 
        ERR_PLUGIN_RESOURCE
        ' A resource that the plugin requires cannot be found. (ie the DLS file for MIDI playback) 
        ERR_PLUGIN_VERSION
        ' A plugin was built with an unsupported SDK version. 
        ERR_RECORD
        ' An error occurred trying to initialize the recording device. 
        ERR_REVERB_CHANNELGROUP
        ' Reverb properties cannot be set on this channel because a parent channelgroup owns the reverb connection. 
        ERR_REVERB_INSTANCE
        ' Specified instance in FMOD_REVERB_PROPERTIES couldn't be set. Most likely because it is an invalid instance number or the reverb doesn't exist. 
        ERR_SUBSOUNDS
        ' The error occurred because the sound referenced contains subsounds when it shouldn't have, or it doesn't contain subsounds when it should have.  The operation may also not be able to be performed on a parent sound. 
        ERR_SUBSOUND_ALLOCATED
        ' This subsound is already being used by another sound, you cannot have more than one parent to a sound.  Null out the other parent's entry first. 
        ERR_SUBSOUND_CANTMOVE
        ' Shared subsounds cannot be replaced or moved from their parent stream, such as when the parent stream is an FSB file. 
        ERR_TAGNOTFOUND
        ' The specified tag could not be found or there are no tags. 
        ERR_TOOMANYCHANNELS
        ' The sound created exceeds the allowable input channel count.  This can be increased using the 'maxinputchannels' parameter in System::setSoftwareFormat. 
        ERR_TRUNCATED
        ' The retrieved string is too long to fit in the supplied buffer and has been truncated. 
        ERR_UNIMPLEMENTED
        ' Something in FMOD hasn't been implemented when it should be! contact support! 
        ERR_UNINITIALIZED
        ' This command failed because System::init or System::setDriver was not called. 
        ERR_UNSUPPORTED
        ' A command issued was not supported by this object.  Possibly a plugin without certain callbacks specified. 
        ERR_VERSION
        ' The version number of this file format is not supported. 
        ERR_EVENT_ALREADY_LOADED
        ' The specified bank has already been loaded. 
        ERR_EVENT_LIVEUPDATE_BUSY
        ' The live update connection failed due to the game already being connected. 
        ERR_EVENT_LIVEUPDATE_MISMATCH
        ' The live update connection failed due to the game data being out of sync with the tool. 
        ERR_EVENT_LIVEUPDATE_TIMEOUT
        ' The live update connection timed out. 
        ERR_EVENT_NOTFOUND
        ' The requested event, bus or vca could not be found. 
        ERR_STUDIO_UNINITIALIZED
        ' The Studio::System object is not yet initialized. 
        ERR_STUDIO_NOT_LOADED
        ' The specified resource is not loaded, so it can't be unloaded. 
        ERR_INVALID_STRING
        ' An invalid string was passed to this function. 
        ERR_ALREADY_LOCKED
        ' The specified resource is already locked. 
        ERR_NOT_LOCKED
        ' The specified resource is not locked, so it can't be unlocked. 
        ERR_RECORD_DISCONNECTED
        ' The specified recording driver has been disconnected. 
        ERR_TOOMANYSAMPLES
        ' The length provided exceed the allowable limit. 
    End Enum


    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        Used to distinguish if a FMOD_CHANNELCONTROL parameter is actually a channel or a channelgroup.
    '
    '        [REMARKS]
    '        Cast the FMOD_CHANNELCONTROL to an FMOD_CHANNEL/FMOD::Channel, or FMOD_CHANNELGROUP/FMOD::ChannelGroup if specific functionality is needed for either class.
    '        Otherwise use as FMOD_CHANNELCONTROL/FMOD::ChannelControl and use that API.
    '
    '        [SEE_ALSO]
    '        Channel::setCallback
    '        ChannelGroup::setCallback
    '    ]
    '    

    Public Enum CHANNELCONTROL_TYPE As Integer
        CHANNEL
        CHANNELGROUP
    End Enum

    '
    '    [STRUCTURE]
    '    [
    '        [DESCRIPTION]
    '        Structure describing a point in 3D space.
    '
    '        [REMARKS]
    '        FMOD uses a left handed co-ordinate system by default.
    '        To use a right handed co-ordinate system specify FMOD_INIT_3D_RIGHTHANDED from FMOD_INITFLAGS in System::init.
    '
    '        [SEE_ALSO]
    '        System::set3DListenerAttributes
    '        System::get3DListenerAttributes
    '        Channel::set3DAttributes
    '        Channel::get3DAttributes
    '        Geometry::addPolygon
    '        Geometry::setPolygonVertex
    '        Geometry::getPolygonVertex
    '        Geometry::setRotation
    '        Geometry::getRotation
    '        Geometry::setPosition
    '        Geometry::getPosition
    '        Geometry::setScale
    '        Geometry::getScale
    '        FMOD_INITFLAGS
    '    ]
    '    

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure VECTOR
        Public x As Single
        ' X co-ordinate in 3D space. 
        Public y As Single
        ' Y co-ordinate in 3D space. 
        Public z As Single
        ' Z co-ordinate in 3D space. 
    End Structure

    '
    '    [STRUCTURE]
    '    [
    '        [DESCRIPTION]
    '        Structure describing a position, velocity and orientation.
    '
    '        [REMARKS]
    '
    '        [SEE_ALSO]
    '        FMOD_VECTOR
    '        FMOD_DSP_PARAMETER_3DATTRIBUTES
    '    ]
    '    

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure _3D_ATTRIBUTES
        Private position As VECTOR
        Private velocity As VECTOR
        Private forward As VECTOR
        Private up As VECTOR
    End Structure

    '
    '    [STRUCTURE]
    '    [
    '        [DESCRIPTION]
    '        Structure that is passed into FMOD_FILE_ASYNCREAD_CALLBACK.  Use the information in this structure to perform
    '
    '        [REMARKS]
    '        Members marked with [r] mean the variable is modified by FMOD and is for reading purposes only.  Do not change this value.<br>
    '        Members marked with [w] mean the variable can be written to.  The user can set the value.<br>
    '        <br>
    '        Instructions: write to 'buffer', and 'bytesread' <b>BEFORE</b> setting 'result'.<br>
    '        As soon as result is set, FMOD will asynchronously continue internally using the data provided in this structure.<br>
    '        <br>
    '        Set 'result' to the result expected from a normal file read callback.<br>
    '        If the read was successful, set it to FMOD_OK.<br>
    '        If it read some data but hit the end of the file, set it to FMOD_ERR_FILE_EOF.<br>
    '        If a bad error occurred, return FMOD_ERR_FILE_BAD<br>
    '        If a disk was ejected, return FMOD_ERR_FILE_DISKEJECTED.<br>
    '
    '        [SEE_ALSO]
    '        FMOD_FILE_ASYNCREAD_CALLBACK
    '        FMOD_FILE_ASYNCCANCEL_CALLBACK
    '    ]
    '    

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure ASYNCREADINFO
        Public handle As IntPtr
        ' [r] The file handle that was filled out in the open callback. 
        Public offset As UInteger
        ' [r] Seek position, make sure you read from this file offset. 
        Public sizebytes As UInteger
        ' [r] how many bytes requested for read. 
        Public priority As Integer
        ' [r] 0 = low importance.  100 = extremely important (ie 'must read now or stuttering may occur') 

        Public userdata As IntPtr
        ' [r] User data pointer. 
        Public buffer As IntPtr
        ' [w] Buffer to read file data into. 
        Public bytesread As UInteger
        ' [w] Fill this in before setting result code to tell FMOD how many bytes were read. 
        Public done As ASYNCREADINFO_DONE_CALLBACK
        ' [r] FMOD file system wake up function.  Call this when user file read is finished.  Pass result of file read as a parameter. 

    End Structure

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        These output types are used with System::setOutput / System::getOutput, to choose which output method to use.
    '
    '        [REMARKS]
    '        To pass information to the driver when initializing fmod use the *extradriverdata* parameter in System::init for the following reasons.
    '
    '        - FMOD_OUTPUTTYPE_WAVWRITER     - extradriverdata is a pointer to a char * file name that the wav writer will output to.
    '        - FMOD_OUTPUTTYPE_WAVWRITER_NRT - extradriverdata is a pointer to a char * file name that the wav writer will output to.
    '        - FMOD_OUTPUTTYPE_DSOUND        - extradriverdata is cast to a HWND type, so that FMOD can set the focus on the audio for a particular window.
    '        - FMOD_OUTPUTTYPE_PS3           - extradriverdata is a pointer to a FMOD_PS3_EXTRADRIVERDATA struct. This can be found in fmodps3.h.
    '        - FMOD_OUTPUTTYPE_XBOX360       - extradriverdata is a pointer to a FMOD_360_EXTRADRIVERDATA struct. This can be found in fmodxbox360.h.
    '
    '        Currently these are the only FMOD drivers that take extra information.  Other unknown plugins may have different requirements.
    '    
    '        Note! If FMOD_OUTPUTTYPE_WAVWRITER_NRT or FMOD_OUTPUTTYPE_NOSOUND_NRT are used, and if the System::update function is being called
    '        very quickly (ie for a non realtime decode) it may be being called too quickly for the FMOD streamer thread to respond to.
    '        The result will be a skipping/stuttering output in the captured audio.
    '    
    '        To remedy this, disable the FMOD streamer thread, and use FMOD_INIT_STREAM_FROM_UPDATE to avoid skipping in the output stream,
    '        as it will lock the mixer and the streamer together in the same thread.
    '    
    '        [SEE_ALSO]
    '            System::setOutput
    '            System::getOutput
    '            System::setSoftwareFormat
    '            System::getSoftwareFormat
    '            System::init
    '            System::update
    '            FMOD_INITFLAGS
    '    ]
    '    

    Public Enum OUTPUTTYPE As Integer
        AUTODETECT
        ' Picks the best output mode for the platform. This is the default. 

        UNKNOWN
        ' All - 3rd party plugin, unknown. This is for use with System::getOutput only. 
        NOSOUND
        ' All - Perform all mixing but discard the final output. 
        WAVWRITER
        ' All - Writes output to a .wav file. 
        NOSOUND_NRT
        ' All - Non-realtime version of FMOD_OUTPUTTYPE_NOSOUND. User can drive mixer with System::update at whatever rate they want. 
        WAVWRITER_NRT
        ' All - Non-realtime version of FMOD_OUTPUTTYPE_WAVWRITER. User can drive mixer with System::update at whatever rate they want. 

        DSOUND
        ' Win                  - Direct Sound.                        (Default on Windows XP and below) 
        WINMM
        ' Win                  - Windows Multimedia. 
        WASAPI
        ' Win/WinStore/XboxOne - Windows Audio Session API.           (Default on Windows Vista and above, Xbox One and Windows Store Applications) 
        ASIO
        ' Win                  - Low latency ASIO 2.0. 
        PULSEAUDIO
        ' Linux                - Pulse Audio.                         (Default on Linux if available) 
        ALSA
        ' Linux                - Advanced Linux Sound Architecture.   (Default on Linux if PulseAudio isn't available) 
        COREAUDIO
        ' Mac/iOS              - Core Audio.                          (Default on Mac and iOS) 
        XBOX360
        ' Xbox 360             - XAudio.                              (Default on Xbox 360) 
        PS3
        ' PS3                  - Audio Out.                           (Default on PS3) 
        AUDIOTRACK
        ' Android              - Java Audio Track.                    (Default on Android 2.2 and below) 
        OPENSL
        ' Android              - OpenSL ES.                           (Default on Android 2.3 and above) 
        WIIU
        ' Wii U                - AX.                                  (Default on Wii U) 
        AUDIOOUT
        ' PS4/PSVita           - Audio Out.                           (Default on PS4 and PS Vita) 

        MAX
        ' Maximum number of output types supported. 
    End Enum

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        Specify the destination of log output when using the logging version of FMOD.
    '
    '        [REMARKS]
    '        TTY destination can vary depending on platform, common examples include the
    '        Visual Studio / Xcode output window, stderr and LogCat.
    '
    '        [SEE_ALSO]
    '        FMOD_Debug_Initialize
    '    ]
    '    

    Public Enum DEBUG_MODE As Integer
        TTY
        ' Default log location per platform, i.e. Visual Studio output window, stderr, LogCat, etc 
        FILE
        ' Write log to specified file path 
        CALLBACK
        ' Call specified callback with log information 
    End Enum

    '
    '    [DEFINE]
    '    [
    '        [NAME]
    '        FMOD_DEBUG_FLAGS
    '
    '        [DESCRIPTION]
    '        Specify the requested information to be output when using the logging version of FMOD.
    '
    '        [REMARKS]
    '
    '        [SEE_ALSO]
    '        FMOD_Debug_Initialize
    '    ]
    '    

    <Flags()> _
    Public Enum DEBUG_FLAGS As UInteger
        NONE = &H0
        ' Disable all messages 
        [ERROR] = &H1
        ' Enable only error messages. 
        WARNING = &H2
        ' Enable warning and error messages. 
        LOG = &H4
        ' Enable informational, warning and error messages (default). 

        TYPE_MEMORY = &H100
        ' Verbose logging for memory operations, only use this if you are debugging a memory related issue. 
        TYPE_FILE = &H200
        ' Verbose logging for file access, only use this if you are debugging a file related issue. 
        TYPE_CODEC = &H400
        ' Verbose logging for codec initialization, only use this if you are debugging a codec related issue. 
        TYPE_TRACE = &H800
        ' Verbose logging for internal errors, use this for tracking the origin of error codes. 

        DISPLAY_TIMESTAMPS = &H10000
        ' Display the time stamp of the log message in milliseconds. 
        DISPLAY_LINENUMBERS = &H20000
        ' Display the source code file and line number for where the message originated. 
        DISPLAY_THREAD = &H40000
        ' Display the thread ID of the calling function that generated the message. 
    End Enum

    '
    '    [DEFINE]
    '    [
    '        [NAME]
    '        FMOD_MEMORY_TYPE
    '
    '        [DESCRIPTION]
    '        Bit fields for memory allocation type being passed into FMOD memory callbacks.
    '
    '        [REMARKS]
    '        Remember this is a bitfield.  You may get more than 1 bit set (ie physical + persistent) so do not simply switch on the types!  You must check each bit individually or clear out the bits that you do not want within the callback.<br>
    '        Bits can be excluded if you want during Memory_Initialize so that you never get them.
    '
    '        [SEE_ALSO]
    '        FMOD_MEMORY_ALLOC_CALLBACK
    '        FMOD_MEMORY_REALLOC_CALLBACK
    '        FMOD_MEMORY_FREE_CALLBACK
    '        Memory_Initialize
    '    ]
    '    

    <Flags()> _
    Public Enum MEMORY_TYPE As UInteger
        NORMAL = &H0
        ' Standard memory. 
        STREAM_FILE = &H1
        ' Stream file buffer, size controllable with System::setStreamBufferSize. 
        STREAM_DECODE = &H2
        ' Stream decode buffer, size controllable with FMOD_CREATESOUNDEXINFO::decodebuffersize. 
        SAMPLEDATA = &H4
        ' Sample data buffer.  Raw audio data, usually PCM/MPEG/ADPCM/XMA data. 
        DSP_BUFFER = &H8
        ' DSP memory block allocated when more than 1 output exists on a DSP node. 
        PLUGIN = &H10
        ' Memory allocated by a third party plugin. 
        XBOX360_PHYSICAL = &H100000
        ' Requires XPhysicalAlloc / XPhysicalFree. 
        PERSISTENT = &H200000
        ' Persistent memory. Memory will be freed when System::release is called. 
        SECONDARY = &H400000
        ' Secondary memory. Allocation should be in secondary memory. For example RSX on the PS3. 
        ALL = &HFFFFFFFFUI
    End Enum

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        These are speaker types defined for use with the System::setSoftwareFormat command.
    '
    '        [REMARKS]
    '        Note below the phrase 'sound channels' is used.  These are the subchannels inside a sound, they are not related and
    '        have nothing to do with the FMOD class "Channel".<br>
    '        For example a mono sound has 1 sound channel, a stereo sound has 2 sound channels, and an AC3 or 6 channel wav file have 6 "sound channels".<br>
    '        <br>
    '        FMOD_SPEAKERMODE_RAW<br>
    '        ---------------------<br>
    '        This mode is for output devices that are not specifically mono/stereo/quad/surround/5.1 or 7.1, but are multichannel.<br>
    '        Use System::setSoftwareFormat to specify the number of speakers you want to address, otherwise it will default to 2 (stereo).<br>
    '        Sound channels map to speakers sequentially, so a mono sound maps to output speaker 0, stereo sound maps to output speaker 0 & 1.<br>
    '        The user assumes knowledge of the speaker order.  FMOD_SPEAKER enumerations may not apply, so raw channel indices should be used.<br>
    '        Multichannel sounds map input channels to output channels 1:1. <br>
    '        Channel::setPan and Channel::setPanLevels do not work.<br>
    '        Speaker levels must be manually set with Channel::setPanMatrix.<br>
    '        <br>
    '        FMOD_SPEAKERMODE_MONO<br>
    '        ---------------------<br>
    '        This mode is for a 1 speaker arrangement.<br>
    '        Panning does not work in this speaker mode.<br>
    '        Mono, stereo and multichannel sounds have each sound channel played on the one speaker unity.<br>
    '        Mix behavior for multichannel sounds can be set with Channel::setPanMatrix.<br>
    '        Channel::setPanLevels does not work.<br>
    '        <br>
    '        FMOD_SPEAKERMODE_STEREO<br>
    '        -----------------------<br>
    '        This mode is for 2 speaker arrangements that have a left and right speaker.<br>
    '        <li>Mono sounds default to an even distribution between left and right.  They can be panned with Channel::setPan.<br>
    '        <li>Stereo sounds default to the middle, or full left in the left speaker and full right in the right speaker.
    '        <li>They can be cross faded with Channel::setPan.<br>
    '        <li>Multichannel sounds have each sound channel played on each speaker at unity.<br>
    '        <li>Mix behavior for multichannel sounds can be set with Channel::setPanMatrix.<br>
    '        <li>Channel::setPanLevels works but only front left and right parameters are used, the rest are ignored.<br>
    '        <br>
    '        FMOD_SPEAKERMODE_QUAD<br>
    '        ------------------------<br>
    '        This mode is for 4 speaker arrangements that have a front left, front right, surround left and a surround right speaker.<br>
    '        <li>Mono sounds default to an even distribution between front left and front right.  They can be panned with Channel::setPan.<br>
    '        <li>Stereo sounds default to the left sound channel played on the front left, and the right sound channel played on the front right.<br>
    '        <li>They can be cross faded with Channel::setPan.<br>
    '        <li>Multichannel sounds default to all of their sound channels being played on each speaker in order of input.<br>
    '        <li>Mix behavior for multichannel sounds can be set with Channel::setPanMatrix.<br>
    '        <li>Channel::setPanLevels works but rear left, rear right, center and lfe are ignored.<br>
    '        <br>
    '        FMOD_SPEAKERMODE_SURROUND<br>
    '        ------------------------<br>
    '        This mode is for 5 speaker arrangements that have a left/right/center/surround left/surround right.<br>
    '        <li>Mono sounds default to the center speaker.  They can be panned with Channel::setPan.<br>
    '        <li>Stereo sounds default to the left sound channel played on the front left, and the right sound channel played on the front right.
    '        <li>They can be cross faded with Channel::setPan.<br>
    '        <li>Multichannel sounds default to all of their sound channels being played on each speaker in order of input.
    '        <li>Mix behavior for multichannel sounds can be set with Channel::setPanMatrix.<br>
    '        <li>Channel::setPanLevels works but rear left / rear right are ignored.<br>
    '        <br>
    '        FMOD_SPEAKERMODE_5POINT1<br>
    '        ---------------------------------------------------------<br>
    '        This mode is for 5.1 speaker arrangements that have a left/right/center/surround left/surround right and a subwoofer speaker.<br>
    '        <li>Mono sounds default to the center speaker.  They can be panned with Channel::setPan.<br>
    '        <li>Stereo sounds default to the left sound channel played on the front left, and the right sound channel played on the front right.
    '        <li>They can be cross faded with Channel::setPan.<br>
    '        <li>Multichannel sounds default to all of their sound channels being played on each speaker in order of input.
    '        <li>Mix behavior for multichannel sounds can be set with Channel::setPanMatrix.<br>
    '        <li>Channel::setPanLevels works but rear left / rear right are ignored.<br>
    '        <br>
    '        FMOD_SPEAKERMODE_7POINT1<br>
    '        ------------------------<br>
    '        This mode is for 7.1 speaker arrangements that have a left/right/center/surround left/surround right/rear left/rear right
    '        and a subwoofer speaker.<br>
    '        <li>Mono sounds default to the center speaker.  They can be panned with Channel::setPan.<br>
    '        <li>Stereo sounds default to the left sound channel played on the front left, and the right sound channel played on the front right.
    '        <li>They can be cross faded with Channel::setPan.<br>
    '        <li>Multichannel sounds default to all of their sound channels being played on each speaker in order of input.
    '        <li>Mix behavior for multichannel sounds can be set with Channel::setPanMatrix.<br>
    '        <li>Channel::setPanLevels works and every parameter is used to set the balance of a sound in any speaker.<br>
    '        <br>
    '
    '        [SEE_ALSO]
    '        System::setSoftwareFormat
    '        System::getSoftwareFormat
    '        DSP::setChannelFormat
    '    ]
    '    

    Public Enum SPEAKERMODE As Integer
        [DEFAULT]
        ' Default speaker mode based on operating system/output mode.  Windows = control panel setting, Xbox = 5.1, PS3 = 7.1 etc. 
        RAW
        ' There is no specific speakermode.  Sound channels are mapped in order of input to output.  Use System::setSoftwareFormat to specify speaker count. See remarks for more information. 
        MONO
        ' The speakers are monaural. 
        STEREO
        ' The speakers are stereo. 
        QUAD
        ' 4 speaker setup.  This includes front left, front right, surround left, surround right.  
        SURROUND
        ' 5 speaker setup.  This includes front left, front right, center, surround left, surround right. 
        _5POINT1
        ' 5.1 speaker setup.  This includes front left, front right, center, surround left, surround right and an LFE speaker. 
        _7POINT1
        ' 7.1 speaker setup.  This includes front left, front right, center, surround left, surround right, back left, back right and an LFE speaker. 

        MAX
        ' Maximum number of speaker modes supported. 
    End Enum

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        Assigns an enumeration for a speaker index.
    '
    '        [REMARKS]
    '
    '        [SEE_ALSO]
    '        System::setSpeakerPosition
    '        System::getSpeakerPosition
    '    ]
    '    

    Public Enum SPEAKER As Integer
        FRONT_LEFT
        FRONT_RIGHT
        FRONT_CENTER
        LOW_FREQUENCY
        SURROUND_LEFT
        SURROUND_RIGHT
        BACK_LEFT
        BACK_RIGHT

        MAX
        ' Maximum number of speaker types supported. 
    End Enum

    '
    '    [DEFINE]
    '    [
    '        [NAME]
    '        FMOD_CHANNELMASK
    '
    '        [DESCRIPTION]
    '        These are bitfields to describe for a certain number of channels in a signal, which channels are being represented.<br>
    '        For example, a signal could be 1 channel, but contain the LFE channel only.<br>
    '
    '        [REMARKS]
    '        FMOD_CHANNELMASK_BACK_CENTER is not represented as an output speaker in fmod - but it is encountered in input formats and is down or upmixed appropriately to the nearest speakers.<br>
    '
    '        [SEE_ALSO]
    '        DSP::setChannelFormat
    '        DSP::getChannelFormat
    '        FMOD_SPEAKERMODE
    '    ]
    '    

    <Flags()> _
    Public Enum CHANNELMASK As UInteger
        FRONT_LEFT = &H1
        FRONT_RIGHT = &H2
        FRONT_CENTER = &H4
        LOW_FREQUENCY = &H8
        SURROUND_LEFT = &H10
        SURROUND_RIGHT = &H20
        BACK_LEFT = &H40
        BACK_RIGHT = &H80
        BACK_CENTER = &H100

        MONO = (FRONT_LEFT)
        STEREO = (FRONT_LEFT Or FRONT_RIGHT)
        LRC = (FRONT_LEFT Or FRONT_RIGHT Or FRONT_CENTER)
        QUAD = (FRONT_LEFT Or FRONT_RIGHT Or SURROUND_LEFT Or SURROUND_RIGHT)
        SURROUND = (FRONT_LEFT Or FRONT_RIGHT Or FRONT_CENTER Or SURROUND_LEFT Or SURROUND_RIGHT)
        _5POINT1 = (FRONT_LEFT Or FRONT_RIGHT Or FRONT_CENTER Or LOW_FREQUENCY Or SURROUND_LEFT Or SURROUND_RIGHT)
        _5POINT1_REARS = (FRONT_LEFT Or FRONT_RIGHT Or FRONT_CENTER Or LOW_FREQUENCY Or BACK_LEFT Or BACK_RIGHT)
        _7POINT0 = (FRONT_LEFT Or FRONT_RIGHT Or FRONT_CENTER Or SURROUND_LEFT Or SURROUND_RIGHT Or BACK_LEFT Or BACK_RIGHT)
        _7POINT1 = (FRONT_LEFT Or FRONT_RIGHT Or FRONT_CENTER Or LOW_FREQUENCY Or SURROUND_LEFT Or SURROUND_RIGHT Or BACK_LEFT Or BACK_RIGHT)
    End Enum

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        When creating a multichannel sound, FMOD will pan them to their default speaker locations, for example a 6 channel sound will default to one channel per 5.1 output speaker.<br>
    '        Another example is a stereo sound.  It will default to left = front left, right = front right.<br>
    '        <br>
    '        This is for sounds that are not 'default'.  For example you might have a sound that is 6 channels but actually made up of 3 stereo pairs, that should all be located in front left, front right only.
    '
    '        [REMARKS]
    '
    '        [SEE_ALSO]
    '        FMOD_CREATESOUNDEXINFO
    '    ]
    '    

    Public Enum CHANNELORDER As Integer
        [DEFAULT]
        ' Left, Right, Center, LFE, Surround Left, Surround Right, Back Left, Back Right (see FMOD_SPEAKER enumeration)   
        WAVEFORMAT
        ' Left, Right, Center, LFE, Back Left, Back Right, Surround Left, Surround Right (as per Microsoft .wav WAVEFORMAT structure master order) 
        PROTOOLS
        ' Left, Center, Right, Surround Left, Surround Right, LFE 
        ALLMONO
        ' Mono, Mono, Mono, Mono, Mono, Mono, ... (each channel all the way up to 32 channels are treated as if they were mono) 
        ALLSTEREO
        ' Left, Right, Left, Right, Left, Right, ... (each pair of channels is treated as stereo all the way up to 32 channels) 
        ALSA
        ' Left, Right, Surround Left, Surround Right, Center, LFE (as per Linux ALSA channel order) 

        MAX
        ' Maximum number of channel orderings supported. 
    End Enum

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        These are plugin types defined for use with the System::getNumPlugins,
    '        System::getPluginInfo and System::unloadPlugin functions.
    '
    '        [REMARKS]
    '
    '        [SEE_ALSO]
    '        System::getNumPlugins
    '        System::getPluginInfo
    '        System::unloadPlugin
    '    ]
    '    

    Public Enum PLUGINTYPE As Integer
        OUTPUT
        ' The plugin type is an output module.  FMOD mixed audio will play through one of these devices 
        CODEC
        ' The plugin type is a file format codec.  FMOD will use these codecs to load file formats for playback. 
        DSP
        ' The plugin type is a DSP unit.  FMOD will use these plugins as part of its DSP network to apply effects to output or generate sound in realtime. 

        MAX
        ' Maximum number of plugin types supported. 
    End Enum



    '
    '    [DEFINE]
    '    [
    '        [NAME]
    '        FMOD_INITFLAGS
    '
    '        [DESCRIPTION]
    '        Initialization flags.  Use them with System::init in the *flags* parameter to change various behavior.
    '
    '        [REMARKS]
    '        Use System::setAdvancedSettings to adjust settings for some of the features that are enabled by these flags.
    '
    '        [SEE_ALSO]
    '        System::init
    '        System::update
    '        System::setAdvancedSettings
    '        Channel::set3DOcclusion
    '    ]
    '    

    <Flags()> _
    Public Enum INITFLAGS As UInteger
        NORMAL = &H0
        ' Initialize normally 
        STREAM_FROM_UPDATE = &H1
        ' No stream thread is created internally.  Streams are driven from System::update.  Mainly used with non-realtime outputs. 
        MIX_FROM_UPDATE = &H2
        ' Win/Wii/PS3/Xbox/Xbox 360 Only - FMOD Mixer thread is woken up to do a mix when System::update is called rather than waking periodically on its own timer. 
        _3D_RIGHTHANDED = &H4
        ' FMOD will treat +X as right, +Y as up and +Z as backwards (towards you). 
        CHANNEL_LOWPASS = &H100
        ' All FMOD_3D based voices will add a software lowpass filter effect into the DSP chain which is automatically used when Channel::set3DOcclusion is used or the geometry API.   This also causes sounds to sound duller when the sound goes behind the listener, as a fake HRTF style effect.  Use System::setAdvancedSettings to disable or adjust cutoff frequency for this feature. 
        CHANNEL_DISTANCEFILTER = &H200
        ' All FMOD_3D based voices will add a software lowpass and highpass filter effect into the DSP chain which will act as a distance-automated bandpass filter. Use System::setAdvancedSettings to adjust the center frequency. 
        PROFILE_ENABLE = &H10000
        ' Enable TCP/IP based host which allows FMOD Designer or FMOD Profiler to connect to it, and view memory, CPU and the DSP network graph in real-time. 
        VOL0_BECOMES_VIRTUAL = &H20000
        ' Any sounds that are 0 volume will go virtual and not be processed except for having their positions updated virtually.  Use System::setAdvancedSettings to adjust what volume besides zero to switch to virtual at. 
        GEOMETRY_USECLOSEST = &H40000
        ' With the geometry engine, only process the closest polygon rather than accumulating all polygons the sound to listener line intersects. 
        PREFER_DOLBY_DOWNMIX = &H80000
        ' When using FMOD_SPEAKERMODE_5POINT1 with a stereo output device, use the Dolby Pro Logic II downmix algorithm instead of the SRS Circle Surround algorithm. 
        THREAD_UNSAFE = &H100000
        ' Disables thread safety for API calls. Only use this if FMOD low level is being called from a single thread, and if Studio API is not being used! 
        PROFILE_METER_ALL = &H200000
        ' Slower, but adds level metering for every single DSP unit in the graph.  Use DSP::setMeteringEnabled to turn meters off individually. 
    End Enum


    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        These definitions describe the type of song being played.
    '
    '        [REMARKS]
    '
    '        [SEE_ALSO]
    '        Sound::getFormat
    '    ]
    '    

    Public Enum SOUND_TYPE
        UNKNOWN
        ' 3rd party / unknown plugin format. 
        AIFF
        ' AIFF. 
        ASF
        ' Microsoft Advanced Systems Format (ie WMA/ASF/WMV). 
        DLS
        ' Sound font / downloadable sound bank. 
        FLAC
        ' FLAC lossless codec. 
        FSB
        ' FMOD Sample Bank. 
        IT
        ' Impulse Tracker. 
        MIDI
        ' MIDI. extracodecdata is a pointer to an FMOD_MIDI_EXTRACODECDATA structure. 
        [MOD]
        ' Protracker / Fasttracker MOD. 
        MPEG
        ' MP2/MP3 MPEG. 
        OGGVORBIS
        ' Ogg vorbis. 
        PLAYLIST
        ' Information only from ASX/PLS/M3U/WAX playlists 
        RAW
        ' Raw PCM data. 
        S3M
        ' ScreamTracker 3. 
        USER
        ' User created sound. 
        WAV
        ' Microsoft WAV. 
        XM
        ' FastTracker 2 XM. 
        XMA
        ' Xbox360 XMA 
        AUDIOQUEUE
        ' iPhone hardware decoder, supports AAC, ALAC and MP3. extracodecdata is a pointer to an FMOD_AUDIOQUEUE_EXTRACODECDATA structure. 
        AT9
        ' PS4 / PSVita ATRAC 9 format 
        VORBIS
        ' Vorbis 
        MEDIA_FOUNDATION
        ' Windows Store Application built in system codecs 
        MEDIACODEC
        ' Android MediaCodec 
        FADPCM
        ' FMOD Adaptive Differential Pulse Code Modulation 

        MAX
        ' Maximum number of sound types supported. 
    End Enum

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        These definitions describe the native format of the hardware or software buffer that will be used.
    '
    '        [REMARKS]
    '        This is the format the native hardware or software buffer will be or is created in.
    '
    '        [SEE_ALSO]
    '        System::createSoundEx
    '        Sound::getFormat
    '    ]
    '    

    Public Enum SOUND_FORMAT As Integer
        NONE
        ' Unitialized / unknown 
        PCM8
        ' 8bit integer PCM data 
        PCM16
        ' 16bit integer PCM data  
        PCM24
        ' 24bit integer PCM data  
        PCM32
        ' 32bit integer PCM data  
        PCMFLOAT
        ' 32bit floating point PCM data  
        BITSTREAM
        ' Sound data is in its native compressed format. 

        MAX
        ' Maximum number of sound formats supported. 
    End Enum


    '
    '    [DEFINE]
    '    [
    '        [NAME]
    '        FMOD_MODE
    '
    '        [DESCRIPTION]
    '        Sound description bitfields, bitwise OR them together for loading and describing sounds.
    '
    '        [REMARKS]
    '        By default a sound will open as a static sound that is decompressed fully into memory to PCM. (ie equivalent of FMOD_CREATESAMPLE)<br>
    '        To have a sound stream instead, use FMOD_CREATESTREAM, or use the wrapper function System::createStream.<br>
    '        Some opening modes (ie FMOD_OPENUSER, FMOD_OPENMEMORY, FMOD_OPENMEMORY_POINT, FMOD_OPENRAW) will need extra information.<br>
    '        This can be provided using the FMOD_CREATESOUNDEXINFO structure.
    '        <br>
    '        Specifying FMOD_OPENMEMORY_POINT will POINT to your memory rather allocating its own sound buffers and duplicating it internally.<br>
    '        <b><u>This means you cannot free the memory while FMOD is using it, until after Sound::release is called.</b></u>
    '        With FMOD_OPENMEMORY_POINT, for PCM formats, only WAV, FSB, and RAW are supported.  For compressed formats, only those formats supported by FMOD_CREATECOMPRESSEDSAMPLE are supported.<br>
    '        With FMOD_OPENMEMORY_POINT and FMOD_OPENRAW or PCM, if using them together, note that you must pad the data on each side by 16 bytes.  This is so fmod can modify the ends of the data for looping/interpolation/mixing purposes.  If a wav file, you will need to insert silence, and then reset loop points to stop the playback from playing that silence.<br>
    '        <br>
    '        <b>Xbox 360 memory</b> On Xbox 360 Specifying FMOD_OPENMEMORY_POINT to a virtual memory address will cause FMOD_ERR_INVALID_ADDRESS
    '        to be returned.  Use physical memory only for this functionality.<br>
    '        <br>
    '        FMOD_LOWMEM is used on a sound if you want to minimize the memory overhead, by having FMOD not allocate memory for certain
    '        features that are not likely to be used in a game environment.  These are :<br>
    '        1. Sound::getName functionality is removed.  256 bytes per sound is saved.<br>
    '
    '        [SEE_ALSO]
    '        System::createSound
    '        System::createStream
    '        Sound::setMode
    '        Sound::getMode
    '        Channel::setMode
    '        Channel::getMode
    '        Sound::set3DCustomRolloff
    '        Channel::set3DCustomRolloff
    '        Sound::getOpenState
    '    ]
    '    

    <Flags()> _
    Public Enum MODE As UInteger
        [DEFAULT] = &H0
        ' Default for all modes listed below. FMOD_LOOP_OFF, FMOD_2D, FMOD_3D_WORLDRELATIVE, FMOD_3D_INVERSEROLLOFF 
        LOOP_OFF = &H1
        ' For non looping sounds. (default).  Overrides FMOD_LOOP_NORMAL / FMOD_LOOP_BIDI. 
        LOOP_NORMAL = &H2
        ' For forward looping sounds. 
        LOOP_BIDI = &H4
        ' For bidirectional looping sounds. (only works on software mixed static sounds). 
        _2D = &H8
        ' Ignores any 3d processing. (default). 
        _3D = &H10
        ' Makes the sound positionable in 3D.  Overrides FMOD_2D. 
        CREATESTREAM = &H80
        ' Decompress at runtime, streaming from the source provided (standard stream).  Overrides FMOD_CREATESAMPLE. 
        CREATESAMPLE = &H100
        ' Decompress at loadtime, decompressing or decoding whole file into memory as the target sample format. (standard sample). 
        CREATECOMPRESSEDSAMPLE = &H200
        ' Load MP2, MP3, IMAADPCM or XMA into memory and leave it compressed.  During playback the FMOD software mixer will decode it in realtime as a 'compressed sample'.  Can only be used in combination with FMOD_SOFTWARE. 
        OPENUSER = &H400
        ' Opens a user created static sample or stream. Use FMOD_CREATESOUNDEXINFO to specify format and/or read callbacks.  If a user created 'sample' is created with no read callback, the sample will be empty.  Use FMOD_Sound_Lock and FMOD_Sound_Unlock to place sound data into the sound if this is the case. 
        OPENMEMORY = &H800
        ' "name_or_data" will be interpreted as a pointer to memory instead of filename for creating sounds. 
        OPENMEMORY_POINT = &H10000000
        ' "name_or_data" will be interpreted as a pointer to memory instead of filename for creating sounds.  Use FMOD_CREATESOUNDEXINFO to specify length.  This differs to FMOD_OPENMEMORY in that it uses the memory as is, without duplicating the memory into its own buffers.  Cannot be freed after open, only after Sound::release.   Will not work if the data is compressed and FMOD_CREATECOMPRESSEDSAMPLE is not used. 
        OPENRAW = &H1000
        ' Will ignore file format and treat as raw pcm.  User may need to declare if data is FMOD_SIGNED or FMOD_UNSIGNED 
        OPENONLY = &H2000
        ' Just open the file, dont prebuffer or read.  Good for fast opens for info, or when sound::readData is to be used. 
        ACCURATETIME = &H4000
        ' For FMOD_CreateSound - for accurate FMOD_Sound_GetLength / FMOD_Channel_SetPosition on VBR MP3, AAC and MOD/S3M/XM/IT/MIDI files.  Scans file first, so takes longer to open. FMOD_OPENONLY does not affect this. 
        MPEGSEARCH = &H8000
        ' For corrupted / bad MP3 files.  This will search all the way through the file until it hits a valid MPEG header.  Normally only searches for 4k. 
        NONBLOCKING = &H10000
        ' For opening sounds and getting streamed subsounds (seeking) asyncronously.  Use Sound::getOpenState to poll the state of the sound as it opens or retrieves the subsound in the background. 
        UNIQUE = &H20000
        ' Unique sound, can only be played one at a time 
        _3D_HEADRELATIVE = &H40000
        ' Make the sound's position, velocity and orientation relative to the listener. 
        _3D_WORLDRELATIVE = &H80000
        ' Make the sound's position, velocity and orientation absolute (relative to the world). (DEFAULT) 
        _3D_INVERSEROLLOFF = &H100000
        ' This sound will follow the inverse rolloff model where mindistance = full volume, maxdistance = where sound stops attenuating, and rolloff is fixed according to the global rolloff factor.  (DEFAULT) 
        _3D_LINEARROLLOFF = &H200000
        ' This sound will follow a linear rolloff model where mindistance = full volume, maxdistance = silence.  
        _3D_LINEARSQUAREROLLOFF = &H400000
        ' This sound will follow a linear-square rolloff model where mindistance = full volume, maxdistance = silence.  Rolloffscale is ignored. 
        _3D_INVERSETAPEREDROLLOFF = &H800000
        ' This sound will follow the inverse rolloff model at distances close to mindistance and a linear-square rolloff close to maxdistance. 
        _3D_CUSTOMROLLOFF = &H4000000
        ' This sound will follow a rolloff model defined by Sound::set3DCustomRolloff / Channel::set3DCustomRolloff.  
        _3D_IGNOREGEOMETRY = &H40000000
        ' Is not affect by geometry occlusion.  If not specified in Sound::setMode, or Channel::setMode, the flag is cleared and it is affected by geometry again. 
        IGNORETAGS = &H2000000
        ' Skips id3v2/asf/etc tag checks when opening a sound, to reduce seek/read overhead when opening files (helps with CD performance). 
        LOWMEM = &H8000000
        ' Removes some features from samples to give a lower memory overhead, like Sound::getName. 
        LOADSECONDARYRAM = &H20000000
        ' Load sound into the secondary RAM of supported platform.  On PS3, sounds will be loaded into RSX/VRAM. 
        VIRTUAL_PLAYFROMSTART = &H80000000UI
        ' For sounds that start virtual (due to being quiet or low importance), instead of swapping back to audible, and playing at the correct offset according to time, this flag makes the sound play from the start. 
    End Enum


    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        These values describe what state a sound is in after FMOD_NONBLOCKING has been used to open it.
    '
    '        [REMARKS]
    '        With streams, if you are using FMOD_NONBLOCKING, note that if the user calls Sound::getSubSound, a stream will go into FMOD_OPENSTATE_SEEKING state and sound related commands will return FMOD_ERR_NOTREADY.<br>
    '        With streams, if you are using FMOD_NONBLOCKING, note that if the user calls Channel::getPosition, a stream will go into FMOD_OPENSTATE_SETPOSITION state and sound related commands will return FMOD_ERR_NOTREADY.<br>
    '
    '        [SEE_ALSO]
    '        Sound::getOpenState
    '        FMOD_MODE
    '    ]
    '    

    Public Enum OPENSTATE As Integer
        READY = 0
        ' Opened and ready to play 
        LOADING
        ' Initial load in progress 
        [ERROR]
        ' Failed to open - file not found, out of memory etc.  See return value of Sound::getOpenState for what happened. 
        CONNECTING
        ' Connecting to remote host (internet sounds only) 
        BUFFERING
        ' Buffering data 
        SEEKING
        ' Seeking to subsound and re-flushing stream buffer. 
        PLAYING
        ' Ready and playing, but not possible to release at this time without stalling the main thread. 
        SETPOSITION
        ' Seeking within a stream to a different position. 

        MAX
        ' Maximum number of open state types. 
    End Enum

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        These flags are used with SoundGroup::setMaxAudibleBehavior to determine what happens when more sounds
    '        are played than are specified with SoundGroup::setMaxAudible.
    '
    '        [REMARKS]
    '        When using FMOD_SOUNDGROUP_BEHAVIOR_MUTE, SoundGroup::setMuteFadeSpeed can be used to stop a sudden transition.
    '        Instead, the time specified will be used to cross fade between the sounds that go silent and the ones that become audible.
    '
    '        [SEE_ALSO]
    '        SoundGroup::setMaxAudibleBehavior
    '        SoundGroup::getMaxAudibleBehavior
    '        SoundGroup::setMaxAudible
    '        SoundGroup::getMaxAudible
    '        SoundGroup::setMuteFadeSpeed
    '        SoundGroup::getMuteFadeSpeed
    '    ]
    '    

    Public Enum SOUNDGROUP_BEHAVIOR As Integer
        BEHAVIOR_FAIL
        ' Any sound played that puts the sound count over the SoundGroup::setMaxAudible setting, will simply fail during System::playSound. 
        BEHAVIOR_MUTE
        ' Any sound played that puts the sound count over the SoundGroup::setMaxAudible setting, will be silent, then if another sound in the group stops the sound that was silent before becomes audible again. 
        BEHAVIOR_STEALLOWEST
        ' Any sound played that puts the sound count over the SoundGroup::setMaxAudible setting, will steal the quietest / least important sound playing in the group. 

        MAX
        ' Maximum number of sound group behaviors. 
    End Enum

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        These callback types are used with Channel::setCallback.
    '
    '        [REMARKS]
    '        Each callback has commanddata parameters passed as int unique to the type of callback.<br>
    '        See reference to FMOD_CHANNELCONTROL_CALLBACK to determine what they might mean for each type of callback.<br>
    '        <br>
    '        <b>Note!</b>  Currently the user must call System::update for these callbacks to trigger!
    '
    '        [SEE_ALSO]
    '        Channel::setCallback
    '        ChannelGroup::setCallback
    '        FMOD_CHANNELCONTROL_CALLBACK
    '        System::update
    '    ]
    '    

    Public Enum CHANNELCONTROL_CALLBACK_TYPE As Integer
        [END]
        ' Called when a sound ends. 
        VIRTUALVOICE
        ' Called when a voice is swapped out or swapped in. 
        SYNCPOINT
        ' Called when a syncpoint is encountered.  Can be from wav file markers. 
        OCCLUSION
        ' Called when the channel has its geometry occlusion value calculated.  Can be used to clamp or change the value. 

        MAX
        ' Maximum number of callback types supported. 
    End Enum

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        These enums denote special types of node within a DSP chain.
    '
    '        [REMARKS]
    '
    '        [SEE_ALSO]
    '        Channel::getDSP
    '        ChannelGroup::getDSP
    '    ]
    '    

    Public Structure CHANNELCONTROL_DSP_INDEX
        Public Const HEAD As Integer = -1
        ' Head of the DSP chain. 
        Public Const FADER As Integer = -2
        ' Built in fader DSP. 
        Public Const PANNER As Integer = -3
        ' Built in panner DSP. 
        Public Const TAIL As Integer = -4
        ' Tail of the DSP chain. 
    End Structure

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        Used to distinguish the instance type passed into FMOD_ERROR_CALLBACK.
    '
    '        [REMARKS]
    '        Cast the instance of FMOD_ERROR_CALLBACK to the appropriate class indicated by this enum.
    '
    '        [SEE_ALSO]
    '    ]
    '    

    Public Enum ERRORCALLBACK_INSTANCETYPE
        NONE
        SYSTEM
        CHANNEL
        CHANNELGROUP
        CHANNELCONTROL
        SOUND
        SOUNDGROUP
        DSP
        DSPCONNECTION
        GEOMETRY
        REVERB3D
        STUDIO_SYSTEM
        STUDIO_EVENTDESCRIPTION
        STUDIO_EVENTINSTANCE
        STUDIO_PARAMETERINSTANCE
        STUDIO_CUEINSTANCE
        STUDIO_BUS
        STUDIO_VCA
        STUDIO_BANK
        STUDIO_COMMANDREPLAY
    End Enum

    '
    '    [STRUCTURE]
    '    [
    '        [DESCRIPTION]
    '        Structure that is passed into FMOD_SYSTEM_CALLBACK for the FMOD_SYSTEM_CALLBACK_ERROR callback type.
    '
    '        [REMARKS]
    '        The instance pointer will be a type corresponding to the instanceType enum.
    '
    '        [SEE_ALSO]
    '        FMOD_ERRORCALLBACK_INSTANCETYPE
    '    ]
    '    

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure ERRORCALLBACK_INFO
        Public result As RESULT
        ' Error code result 
        Public instancetype As ERRORCALLBACK_INSTANCETYPE
        ' Type of instance the error occurred on 
        Public instance As IntPtr
        ' Instance pointer 
        Private functionname_internal As IntPtr
        ' Function that the error occurred on 
        Private functionparams_internal As IntPtr
        ' Function parameters that the error ocurred on 

        Public ReadOnly Property functionname() As String
            Get
                Return Marshal.PtrToStringAnsi(functionname_internal)
            End Get
        End Property
        Public ReadOnly Property functionparams() As String
            Get
                Return Marshal.PtrToStringAnsi(functionparams_internal)
            End Get
        End Property
    End Structure

    '
    '    [DEFINE]
    '    [
    '        [NAME]
    '        FMOD_SYSTEM_CALLBACK_TYPE
    '
    '        [DESCRIPTION]
    '        These callback types are used with System::setCallback.
    '
    '        [REMARKS]
    '        Each callback has commanddata parameters passed as void* unique to the type of callback.<br>
    '        See reference to FMOD_SYSTEM_CALLBACK to determine what they might mean for each type of callback.<br>
    '        <br>
    '        <b>Note!</b> Using FMOD_SYSTEM_CALLBACK_DEVICELISTCHANGED (on Mac only) requires the application to be running an event loop which will allow external changes to device list to be detected by FMOD.<br>
    '        <br>
    '        <b>Note!</b> The 'system' object pointer will be null for FMOD_SYSTEM_CALLBACK_THREADCREATED and FMOD_SYSTEM_CALLBACK_MEMORYALLOCATIONFAILED callbacks.
    '
    '        [SEE_ALSO]
    '        System::setCallback
    '        System::update
    '        DSP::addInput
    '    ]
    '    

    <Flags()> _
    Public Enum SYSTEM_CALLBACK_TYPE As UInteger
        DEVICELISTCHANGED = &H1
        ' Called from System::update when the enumerated list of devices has changed. 
        DEVICELOST = &H2
        ' Called from System::update when an output device has been lost due to control panel parameter changes and FMOD cannot automatically recover. 
        MEMORYALLOCATIONFAILED = &H4
        ' Called directly when a memory allocation fails somewhere in FMOD.  (NOTE - 'system' will be NULL in this callback type.)
        THREADCREATED = &H8
        ' Called directly when a thread is created. (NOTE - 'system' will be NULL in this callback type.) 
        BADDSPCONNECTION = &H10
        ' Called when a bad connection was made with DSP::addInput. Usually called from mixer thread because that is where the connections are made.  
        PREMIX = &H20
        ' Called each tick before a mix update happens. 
        POSTMIX = &H40
        ' Called each tick after a mix update happens. 
        [ERROR] = &H80
        ' Called when each API function returns an error code, including delayed async functions. 
        MIDMIX = &H100
        ' Called each tick in mix update after clocks have been updated before the main mix occurs. 
        THREADDESTROYED = &H200
        ' Called directly when a thread is destroyed. 
        PREUPDATE = &H400
        ' Called at start of System::update function. 
        POSTUPDATE = &H800
        ' Called at end of System::update function. 
        RECORDLISTCHANGED = &H1000
        ' Called from System::update when the enumerated list of recording devices has changed. 
        ALL = &HFFFFFFFFUI
        ' Pass this mask to System::setCallback to receive all callback types.  
    End Enum

#Region "wrapperinternal"
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure StringWrapper
        Private nativeUtf8Ptr As IntPtr

        Public Shared Widening Operator CType(ByVal fstring As StringWrapper) As String
            If fstring.nativeUtf8Ptr = IntPtr.Zero Then
                Return ""
            End If

            Dim strlen As Integer = 0
            While Marshal.ReadByte(fstring.nativeUtf8Ptr, strlen) <> 0
                strlen += 1
            End While
            If strlen > 0 Then
                Dim bytes As Byte() = New Byte(strlen - 1) {}
                Marshal.Copy(fstring.nativeUtf8Ptr, bytes, 0, strlen)
                Return Encoding.UTF8.GetString(bytes, 0, strlen)
            Else
                Return ""
            End If
        End Operator
    End Structure
#End Region

    '
    '        FMOD Callbacks
    '    

    Public Delegate Function ASYNCREADINFO_DONE_CALLBACK(ByVal info As IntPtr, ByVal result As RESULT) As RESULT

    Public Delegate Function DEBUG_CALLBACK(ByVal flags As DEBUG_FLAGS, ByVal file As String, ByVal line As Integer, ByVal func As String, ByVal message As String) As RESULT

    Public Delegate Function SYSTEM_CALLBACK(ByVal systemraw As IntPtr, ByVal type As SYSTEM_CALLBACK_TYPE, ByVal commanddata1 As IntPtr, ByVal commanddata2 As IntPtr, ByVal userdata As IntPtr) As RESULT

    Public Delegate Function CHANNEL_CALLBACK(ByVal channelraw As IntPtr, ByVal controltype As CHANNELCONTROL_TYPE, ByVal type As CHANNELCONTROL_CALLBACK_TYPE, ByVal commanddata1 As IntPtr, ByVal commanddata2 As IntPtr) As RESULT

    Public Delegate Function SOUND_NONBLOCKCALLBACK(ByVal soundraw As IntPtr, ByVal result As RESULT) As RESULT
    Public Delegate Function SOUND_PCMREADCALLBACK(ByVal soundraw As IntPtr, ByVal data As IntPtr, ByVal datalen As UInteger) As RESULT
    Public Delegate Function SOUND_PCMSETPOSCALLBACK(ByVal soundraw As IntPtr, ByVal subsound As Integer, ByVal position As UInteger, ByVal postype As TIMEUNIT) As RESULT

    Public Delegate Function FILE_OPENCALLBACK(ByVal name As StringWrapper, ByRef filesize As UInteger, ByRef handle As IntPtr, ByVal userdata As IntPtr) As RESULT
    Public Delegate Function FILE_CLOSECALLBACK(ByVal handle As IntPtr, ByVal userdata As IntPtr) As RESULT
    Public Delegate Function FILE_READCALLBACK(ByVal handle As IntPtr, ByVal buffer As IntPtr, ByVal sizebytes As UInteger, ByRef bytesread As UInteger, ByVal userdata As IntPtr) As RESULT
    Public Delegate Function FILE_SEEKCALLBACK(ByVal handle As IntPtr, ByVal pos As UInteger, ByVal userdata As IntPtr) As RESULT
    Public Delegate Function FILE_ASYNCREADCALLBACK(ByVal handle As IntPtr, ByVal info As IntPtr, ByVal userdata As IntPtr) As RESULT
    Public Delegate Function FILE_ASYNCCANCELCALLBACK(ByVal handle As IntPtr, ByVal userdata As IntPtr) As RESULT

    Public Delegate Function MEMORY_ALLOC_CALLBACK(ByVal size As UInteger, ByVal type As MEMORY_TYPE, ByVal sourcestr As StringWrapper) As IntPtr
    Public Delegate Function MEMORY_REALLOC_CALLBACK(ByVal ptr As IntPtr, ByVal size As UInteger, ByVal type As MEMORY_TYPE, ByVal sourcestr As StringWrapper) As IntPtr
    Public Delegate Sub MEMORY_FREE_CALLBACK(ByVal ptr As IntPtr, ByVal type As MEMORY_TYPE, ByVal sourcestr As StringWrapper)

    Public Delegate Function CB_3D_ROLLOFFCALLBACK(ByVal channelraw As IntPtr, ByVal distance As Single) As Single

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        List of interpolation types that the FMOD Ex software mixer supports.
    '
    '        [REMARKS]
    '        The default resampler type is FMOD_DSP_RESAMPLER_LINEAR.<br>
    '        Use System::setSoftwareFormat to tell FMOD the resampling quality you require for FMOD_SOFTWARE based sounds.
    '
    '        [SEE_ALSO]
    '        System::setSoftwareFormat
    '        System::getSoftwareFormat
    '    ]
    '    

    Public Enum DSP_RESAMPLER As Integer
        [DEFAULT]
        ' Default interpolation method.  Currently equal to FMOD_DSP_RESAMPLER_LINEAR. 
        NOINTERP
        ' No interpolation.  High frequency aliasing hiss will be audible depending on the sample rate of the sound. 
        LINEAR
        ' Linear interpolation (default method).  Fast and good quality, causes very slight lowpass effect on low frequency sounds. 
        CUBIC
        ' Cubic interpolation.  Slower than linear interpolation but better quality. 
        SPLINE
        ' 5 point spline interpolation.  Slowest resampling method but best quality. 

        MAX
        ' Maximum number of resample methods supported. 
    End Enum

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        List of connection types between 2 DSP nodes.
    '
    '        [REMARKS]
    '        FMOD_DSP_CONNECTION_TYPE_STANDARD<br>
    '        ----------------------------------<br>
    '        Default DSPConnection type.  Audio is mixed from the input to the output DSP's audible buffer, meaning it will be part of the audible signal.  A standard connection will execute its input DSP if it has not been executed before.<br>
    '        <br>
    '        FMOD_DSP_CONNECTION_TYPE_SIDECHAIN<br>
    '        ----------------------------------<br>
    '        Sidechain DSPConnection type.  Audio is mixed from the input to the output DSP's sidechain buffer, meaning it will NOT be part of the audible signal.  A sidechain connection will execute its input DSP if it has not been executed before.<br>
    '        The purpose of the seperate sidechain buffer in a DSP, is so that the DSP effect can privately access for analysis purposes.  An example of use in this case, could be a compressor which analyzes the signal, to control its own effect parameters (ie a compression level or gain).<br>
    '        <br>
    '        For the effect developer, to accept sidechain data, the sidechain data will appear in the FMOD_DSP_STATE struct which is passed into the read callback of a DSP unit.<br>
    '        FMOD_DSP_STATE::sidechaindata and FMOD_DSP::sidechainchannels will hold the mixed result of any sidechain data flowing into it.<br>
    '        <br>
    '        FMOD_DSP_CONNECTION_TYPE_SEND<br>
    '        -----------------------------<br>
    '        Send DSPConnection type.  Audio is mixed from the input to the output DSP's audible buffer, meaning it will be part of the audible signal.  A send connection will NOT execute its input DSP if it has not been executed before.<br>
    '        A send connection will only read what exists at the input's buffer at the time of executing the output DSP unit (which can be considered the 'return')<br>
    '        <br>
    '        FMOD_DSP_CONNECTION_TYPE_SEND_SIDECHAIN<br>
    '        ---------------------------------------<br>
    '        Send sidechain DSPConnection type.  Audio is mixed from the input to the output DSP's sidechain buffer, meaning it will NOT be part of the audible signal.  A send sidechain connection will NOT execute its input DSP if it has not been executed before.<br>
    '        A send sidechain connection will only read what exists at the input's buffer at the time of executing the output DSP unit (which can be considered the 'sidechain return').
    '        <br>
    '        For the effect developer, to accept sidechain data, the sidechain data will appear in the FMOD_DSP_STATE struct which is passed into the read callback of a DSP unit.<br>
    '        FMOD_DSP_STATE::sidechaindata and FMOD_DSP::sidechainchannels will hold the mixed result of any sidechain data flowing into it.
    '
    '        [SEE_ALSO]
    '        DSP::addInput
    '        DSPConnection::getType
    '    ]
    '    

    Public Enum DSPCONNECTION_TYPE As Integer
        STANDARD
        ' Default connection type.         Audio is mixed from the input to the output DSP's audible buffer.  
        SIDECHAIN
        ' Sidechain connection type.       Audio is mixed from the input to the output DSP's sidechain buffer.  
        SEND
        ' Send connection type.            Audio is mixed from the input to the output DSP's audible buffer, but the input is NOT executed, only copied from.  A standard connection or sidechain needs to make an input execute to generate data. 
        SEND_SIDECHAIN
        ' Send sidechain connection type.  Audio is mixed from the input to the output DSP's sidechain buffer, but the input is NOT executed, only copied from.  A standard connection or sidechain needs to make an input execute to generate data. 

        MAX
        ' Maximum number of DSP connection types supported. 
    End Enum

    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        List of tag types that could be stored within a sound.  These include id3 tags, metadata from netstreams and vorbis/asf data.
    '
    '        [REMARKS]
    '
    '        [SEE_ALSO]
    '        Sound::getTag
    '    ]
    '    

    Public Enum TAGTYPE As Integer
        UNKNOWN = 0
        ID3V1
        ID3V2
        VORBISCOMMENT
        SHOUTCAST
        ICECAST
        ASF
        MIDI
        PLAYLIST
        FMOD
        USER

        MAX
        ' Maximum number of tag types supported. 
    End Enum


    '
    '    [ENUM]
    '    [
    '        [DESCRIPTION]
    '        List of data types that can be returned by Sound::getTag
    '
    '        [REMARKS]
    '
    '        [SEE_ALSO]
    '        Sound::getTag
    '    ]
    '    

    Public Enum TAGDATATYPE As Integer
        BINARY = 0
        INT
        FLOAT
        [STRING]
        STRING_UTF16
        STRING_UTF16BE
        STRING_UTF8
        CDTOC

        MAX
        ' Maximum number of tag datatypes supported. 
    End Enum

    '
    '    [STRUCTURE]
    '    [
    '        [DESCRIPTION]
    '        Structure describing a piece of tag data.
    '
    '        [REMARKS]
    '        Members marked with [w] mean the user sets the value before passing it to the function.
    '        Members marked with [r] mean FMOD sets the value to be used after the function exits.
    '
    '        [SEE_ALSO]
    '        Sound::getTag
    '        TAGTYPE
    '        TAGDATATYPE
    '    ]
    '    

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure TAG
        Public type As TAGTYPE
        ' [r] The type of this tag. 
        Public datatype As TAGDATATYPE
        ' [r] The type of data that this tag contains 
        Private name_internal As IntPtr
        ' [r] The name of this tag i.e. "TITLE", "ARTIST" etc. 
        Public data As IntPtr
        ' [r] Pointer to the tag data - its format is determined by the datatype member 
        Public datalen As UInteger
        ' [r] Length of the data contained in this tag 
        Public updated As Boolean
        ' [r] True if this tag has been updated since last being accessed with Sound::getTag 

        Public ReadOnly Property name() As String
            Get
                Return Marshal.PtrToStringAnsi(name_internal)
            End Get
        End Property
    End Structure


    '
    '    [DEFINE]
    '    [
    '        [NAME]
    '        FMOD_TIMEUNIT
    '
    '        [DESCRIPTION]
    '        List of time types that can be returned by Sound::getLength and used with Channel::setPosition or Channel::getPosition.
    '
    '        [REMARKS]
    '        Do not combine flags except FMOD_TIMEUNIT_BUFFERED.
    '
    '        [SEE_ALSO]
    '        Sound::getLength
    '        Channel::setPosition
    '        Channel::getPosition
    '    ]
    '    

    <Flags()> _
    Public Enum TIMEUNIT As UInteger
        MS = &H1
        ' Milliseconds. 
        PCM = &H2
        ' PCM Samples, related to milliseconds * samplerate / 1000. 
        PCMBYTES = &H4
        ' Bytes, related to PCM samples * channels * datawidth (ie 16bit = 2 bytes). 
        RAWBYTES = &H8
        ' Raw file bytes of (compressed) sound data (does not include headers).  Only used by Sound::getLength and Channel::getPosition. 
        PCMFRACTION = &H10
        ' Fractions of 1 PCM sample.  Unsigned int range 0 to 0xFFFFFFFF.  Used for sub-sample granularity for DSP purposes. 
        MODORDER = &H100
        ' MOD/S3M/XM/IT.  Order in a sequenced module format.  Use Sound::getFormat to determine the format. 
        MODROW = &H200
        ' MOD/S3M/XM/IT.  Current row in a sequenced module format.  Sound::getLength will return the number if rows in the currently playing or seeked to pattern. 
        MODPATTERN = &H400
        ' MOD/S3M/XM/IT.  Current pattern in a sequenced module format.  Sound::getLength will return the number of patterns in the song and Channel::getPosition will return the currently playing pattern. 
        BUFFERED = &H10000000
        ' Time value as seen by buffered stream.  This is always ahead of audible time, and is only used for processing. 
    End Enum

    '
    '    [DEFINE]
    '    [
    '        [NAME]
    '        FMOD_PORT_INDEX
    '
    '        [DESCRIPTION]
    '
    '        [REMARKS]
    '
    '        [SEE_ALSO]
    '        System::AttachChannelGroupToPort
    '    ]
    '    

    Public Structure PORT_INDEX
        Public Const NONE As ULong = &HFFFFFFFFFFFFFFFFUL
    End Structure

    '
    '    [STRUCTURE]
    '    [
    '        [DESCRIPTION]
    '        Use this structure with System::createSound when more control is needed over loading.
    '        The possible reasons to use this with System::createSound are:
    '
    '        - Loading a file from memory.
    '        - Loading a file from within another larger (possibly wad/pak) file, by giving the loader an offset and length.
    '        - To create a user created / non file based sound.
    '        - To specify a starting subsound to seek to within a multi-sample sounds (ie FSB/DLS) when created as a stream.
    '        - To specify which subsounds to load for multi-sample sounds (ie FSB/DLS) so that memory is saved and only a subset is actually loaded/read from disk.
    '        - To specify 'piggyback' read and seek callbacks for capture of sound data as fmod reads and decodes it.  Useful for ripping decoded PCM data from sounds as they are loaded / played.
    '        - To specify a MIDI DLS sample set file to load when opening a MIDI file.
    '
    '        See below on what members to fill for each of the above types of sound you want to create.
    '
    '        [REMARKS]
    '        This structure is optional!  Specify 0 or NULL in System::createSound if you don't need it!
    '
    '        <u>Loading a file from memory.</u>
    '
    '        - Create the sound using the FMOD_OPENMEMORY flag.
    '        - Mandatory.  Specify 'length' for the size of the memory block in bytes.
    '        - Other flags are optional.
    '
    '        <u>Loading a file from within another larger (possibly wad/pak) file, by giving the loader an offset and length.</u>
    '
    '        - Mandatory.  Specify 'fileoffset' and 'length'.
    '        - Other flags are optional.
    '
    '        <u>To create a user created / non file based sound.</u>
    '
    '        - Create the sound using the FMOD_OPENUSER flag.
    '        - Mandatory.  Specify 'defaultfrequency, 'numchannels' and 'format'.
    '        - Other flags are optional.
    '
    '        <u>To specify a starting subsound to seek to and flush with, within a multi-sample stream (ie FSB/DLS).</u>
    '
    '        - Mandatory.  Specify 'initialsubsound'.
    '
    '        <u>To specify which subsounds to load for multi-sample sounds (ie FSB/DLS) so that memory is saved and only a subset is actually loaded/read from disk.</u>
    '
    '        - Mandatory.  Specify 'inclusionlist' and 'inclusionlistnum'.
    '
    '        <u>To specify 'piggyback' read and seek callbacks for capture of sound data as fmod reads and decodes it.  Useful for ripping decoded PCM data from sounds as they are loaded / played.</u>
    '
    '        - Mandatory.  Specify 'pcmreadcallback' and 'pcmseekcallback'.
    '
    '        <u>To specify a MIDI DLS sample set file to load when opening a MIDI file.</u>
    '
    '        - Mandatory.  Specify 'dlsname'.
    '
    '        Setting the 'decodebuffersize' is for cpu intensive codecs that may be causing stuttering, not file intensive codecs (ie those from CD or netstreams) which are normally
    '        altered with System::setStreamBufferSize.  As an example of cpu intensive codecs, an mp3 file will take more cpu to decode than a PCM wav file.
    '
    '        If you have a stuttering effect, then it is using more cpu than the decode buffer playback rate can keep up with.  Increasing the decode buffersize will most likely solve this problem.
    '
    '        FSB codec.  If inclusionlist and numsubsounds are used together, this will trigger a special mode where subsounds are shuffled down to save memory.  (useful for large FSB
    '        files where you only want to load 1 sound).  There will be no gaps, ie no null subsounds.  As an example, if there are 10,000 subsounds and there is an inclusionlist with only 1 entry,
    '        and numsubsounds = 1, then subsound 0 will be that entry, and there will only be the memory allocated for 1 subsound.  Previously there would still be 10,000 subsound pointers and other
    '        associated codec entries allocated along with it multiplied by 10,000.
    '
    '        Members marked with [r] mean the variable is modified by FMOD and is for reading purposes only.  Do not change this value.<br>
    '        Members marked with [w] mean the variable can be written to.  The user can set the value.
    '
    '        [SEE_ALSO]
    '        System::createSound
    '        System::setStreamBufferSize
    '        FMOD_MODE
    '        FMOD_SOUND_FORMAT
    '        FMOD_SOUND_TYPE
    '        FMOD_CHANNELMASK
    '        FMOD_CHANNELORDER
    '    ]
    '    

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure CREATESOUNDEXINFO
        Public cbsize As Integer
        ' [w] Size of this structure.  This is used so the structure can be expanded in the future and still work on older versions of FMOD Ex. 
        Public length As UInteger
        ' [w] Optional. Specify 0 to ignore. Size in bytes of file to load, or sound to create (in this case only if FMOD_OPENUSER is used).  Required if loading from memory.  If 0 is specified, then it will use the size of the file (unless loading from memory then an error will be returned). 
        Public fileoffset As UInteger
        ' [w] Optional. Specify 0 to ignore. Offset from start of the file to start loading from.  This is useful for loading files from inside big data files. 
        Public numchannels As Integer
        ' [w] Optional. Specify 0 to ignore. Number of channels in a sound specified only if OPENUSER is used. 
        Public defaultfrequency As Integer
        ' [w] Optional. Specify 0 to ignore. Default frequency of sound in a sound specified only if OPENUSER is used.  Other formats use the frequency determined by the file format. 
        Public format As SOUND_FORMAT
        ' [w] Optional. Specify 0 or SOUND_FORMAT_NONE to ignore. Format of the sound specified only if OPENUSER is used.  Other formats use the format determined by the file format.   
        Public decodebuffersize As UInteger
        ' [w] Optional. Specify 0 to ignore. For streams.  This determines the size of the double buffer (in PCM samples) that a stream uses.  Use this for user created streams if you want to determine the size of the callback buffer passed to you.  Specify 0 to use FMOD's default size which is currently equivalent to 400ms of the sound format created/loaded. 
        Public initialsubsound As Integer
        ' [w] Optional. Specify 0 to ignore. In a multi-sample file format such as .FSB/.DLS/.SF2, specify the initial subsound to seek to, only if CREATESTREAM is used. 
        Public numsubsounds As Integer
        ' [w] Optional. Specify 0 to ignore or have no subsounds.  In a user created multi-sample sound, specify the number of subsounds within the sound that are accessable with Sound::getSubSound / SoundGetSubSound. 
        Public inclusionlist As IntPtr
        ' [w] Optional. Specify 0 to ignore. In a multi-sample format such as .FSB/.DLS/.SF2 it may be desirable to specify only a subset of sounds to be loaded out of the whole file.  This is an array of subsound indicies to load into memory when created. 
        Public inclusionlistnum As Integer
        ' [w] Optional. Specify 0 to ignore. This is the number of integers contained within the 
        Public pcmreadcallback As SOUND_PCMREADCALLBACK
        ' [w] Optional. Specify 0 to ignore. Callback to 'piggyback' on FMOD's read functions and accept or even write PCM data while FMOD is opening the sound.  Used for user sounds created with OPENUSER or for capturing decoded data as FMOD reads it. 
        Public pcmsetposcallback As SOUND_PCMSETPOSCALLBACK
        ' [w] Optional. Specify 0 to ignore. Callback for when the user calls a seeking function such as Channel::setPosition within a multi-sample sound, and for when it is opened.
        Public nonblockcallback As SOUND_NONBLOCKCALLBACK
        ' [w] Optional. Specify 0 to ignore. Callback for successful completion, or error while loading a sound that used the FMOD_NONBLOCKING flag.
        Public dlsname As IntPtr
        ' [w] Optional. Specify 0 to ignore. Filename for a DLS or SF2 sample set when loading a MIDI file.   If not specified, on windows it will attempt to open /windows/system32/drivers/gm.dls, otherwise the MIDI will fail to open.  
        Public encryptionkey As IntPtr
        ' [w] Optional. Specify 0 to ignore. Key for encrypted FSB file.  Without this key an encrypted FSB file will not load. 
        Public maxpolyphony As Integer
        ' [w] Optional. Specify 0 to ingore. For sequenced formats with dynamic channel allocation such as .MID and .IT, this specifies the maximum voice count allowed while playing.  .IT defaults to 64.  .MID defaults to 32. 
        Public userdata As IntPtr
        ' [w] Optional. Specify 0 to ignore. This is user data to be attached to the sound during creation.  Access via Sound::getUserData. 
        Public suggestedsoundtype As SOUND_TYPE
        ' [w] Optional. Specify 0 or FMOD_SOUND_TYPE_UNKNOWN to ignore.  Instead of scanning all codec types, use this to speed up loading by making it jump straight to this codec. 
        Public fileuseropen As FILE_OPENCALLBACK
        ' [w] Optional. Specify 0 to ignore. Callback for opening this file. 
        Public fileuserclose As FILE_CLOSECALLBACK
        ' [w] Optional. Specify 0 to ignore. Callback for closing this file. 
        Public fileuserread As FILE_READCALLBACK
        ' [w] Optional. Specify 0 to ignore. Callback for reading from this file. 
        Public fileuserseek As FILE_SEEKCALLBACK
        ' [w] Optional. Specify 0 to ignore. Callback for seeking within this file. 
        Public fileuserasyncread As FILE_ASYNCREADCALLBACK
        ' [w] Optional. Specify 0 to ignore. Callback for asyncronously reading from this file. 
        Public fileuserasynccancel As FILE_ASYNCCANCELCALLBACK
        ' [w] Optional. Specify 0 to ignore. Callback for cancelling an asyncronous read. 
        Public fileuserdata As IntPtr
        ' [w] Optional. Specify 0 to ignore. User data to be passed into the file callbacks. 
        Public channelorder As CHANNELORDER
        ' [w] Optional. Specify 0 to ignore. Use this to differ the way fmod maps multichannel sounds to speakers.  See FMOD_CHANNELORDER for more. 
        Public channelmask As CHANNELMASK
        ' [w] Optional. Specify 0 to ignore. Use this to differ the way fmod maps multichannel sounds to speakers.  See FMOD_CHANNELMASK for more. 
        Public initialsoundgroup As IntPtr
        ' [w] Optional. Specify 0 to ignore. Specify a sound group if required, to put sound in as it is created. 
        Public initialseekposition As UInteger
        ' [w] Optional. Specify 0 to ignore. For streams. Specify an initial position to seek the stream to. 
        Public initialseekpostype As TIMEUNIT
        ' [w] Optional. Specify 0 to ignore. For streams. Specify the time unit for the position set in initialseekposition. 
        Public ignoresetfilesystem As Integer
        ' [w] Optional. Specify 0 to ignore. Set to 1 to use fmod's built in file system. Ignores setFileSystem callbacks and also FMOD_CREATESOUNEXINFO file callbacks.  Useful for specific cases where you don't want to use your own file system but want to use fmod's file system (ie net streaming). 
        Public audioqueuepolicy As UInteger
        ' [w] Optional. Specify 0 or FMOD_AUDIOQUEUE_CODECPOLICY_DEFAULT to ignore. Policy used to determine whether hardware or software is used for decoding, see FMOD_AUDIOQUEUE_CODECPOLICY for options (iOS >= 3.0 required, otherwise only hardware is available) 
        Public minmidigranularity As UInteger
        ' [w] Optional. Specify 0 to ignore. Allows you to set a minimum desired MIDI mixer granularity. Values smaller than 512 give greater than default accuracy at the cost of more CPU and vise versa. Specify 0 for default (512 samples). 
        Public nonblockthreadid As Integer
        ' [w] Optional. Specify 0 to ignore. Specifies a thread index to execute non blocking load on.  Allows for up to 5 threads to be used for loading at once.  This is to avoid one load blocking another.  Maximum value = 4. 
    End Structure
    '
    '    [STRUCTURE]
    '    [
    '        [DESCRIPTION]
    '        Structure defining a reverb environment for FMOD_SOFTWARE based sounds only.<br>
    '
    '        [REMARKS]
    '        Note the default reverb properties are the same as the FMOD_PRESET_GENERIC preset.<br>
    '        Note that integer values that typically range from -10,000 to 1000 are represented in decibels,
    '        and are of a logarithmic scale, not linear, wheras float values are always linear.<br>
    '        <br>
    '        The numerical values listed below are the maximum, minimum and default values for each variable respectively.<br>
    '        <br>
    '        Hardware voice / Platform Specific reverb support.<br>
    '        WII   See FMODWII.H for hardware specific reverb functionality.<br>
    '        3DS   See FMOD3DS.H for hardware specific reverb functionality.<br>
    '        PSP   See FMODWII.H for hardware specific reverb functionality.<br>
    '        <br>
    '        Members marked with [r] mean the variable is modified by FMOD and is for reading purposes only.  Do not change this value.<br>
    '        Members marked with [w] mean the variable can be written to.  The user can set the value.<br>
    '        Members marked with [r/w] are either read or write depending on if you are using System::setReverbProperties (w) or System::getReverbProperties (r).
    '
    '        [SEE_ALSO]
    '        System::setReverbProperties
    '        System::getReverbProperties
    '        FMOD_REVERB_PRESETS
    '    ]
    '    

    '#Pragma warning disable 414
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure REVERB_PROPERTIES
        '        MIN     MAX    DEFAULT   DESCRIPTION 
        Public DecayTime As Single
        ' [r/w]  0.0    20000.0 1500.0  Reverberation decay time in ms                                        
        Public EarlyDelay As Single
        ' [r/w]  0.0    300.0   7.0     Initial reflection delay time                                         
        Public LateDelay As Single
        ' [r/w]  0.0    100     11.0    Late reverberation delay time relative to initial reflection          
        Public HFReference As Single
        ' [r/w]  20.0   20000.0 5000    Reference high frequency (hz)                                         
        Public HFDecayRatio As Single
        ' [r/w]  10.0   100.0   50.0    High-frequency to mid-frequency decay time ratio                      
        Public Diffusion As Single
        ' [r/w]  0.0    100.0   100.0   Value that controls the echo density in the late reverberation decay. 
        Public Density As Single
        ' [r/w]  0.0    100.0   100.0   Value that controls the modal density in the late reverberation decay 
        Public LowShelfFrequency As Single
        ' [r/w]  20.0   1000.0  250.0   Reference low frequency (hz)                                          
        Public LowShelfGain As Single
        ' [r/w]  -36.0  12.0    0.0     Relative room effect level at low frequencies                         
        Public HighCut As Single
        ' [r/w]  20.0   20000.0 20000.0 Relative room effect level at high frequencies                        
        Public EarlyLateMix As Single
        ' [r/w]  0.0    100.0   50.0    Early reflections level relative to room effect                       
        Public WetLevel As Single
        ' [r/w]  -80.0  20.0    -6.0    Room effect level (at mid frequencies)
        '                                  * 
#Region "wrapperinternal"
        Public Sub New(ByVal decayTime__1 As Single, ByVal earlyDelay__2 As Single, ByVal lateDelay__3 As Single, ByVal hfReference__4 As Single, ByVal hfDecayRatio__5 As Single, ByVal diffusion__6 As Single, _
         ByVal density__7 As Single, ByVal lowShelfFrequency__8 As Single, ByVal lowShelfGain__9 As Single, ByVal highCut__10 As Single, ByVal earlyLateMix__11 As Single, ByVal wetLevel__12 As Single)
            DecayTime = decayTime__1
            EarlyDelay = earlyDelay__2
            LateDelay = lateDelay__3
            HFReference = hfReference__4
            HFDecayRatio = hfDecayRatio__5
            Diffusion = diffusion__6
            Density = density__7
            LowShelfFrequency = lowShelfFrequency__8
            LowShelfGain = lowShelfGain__9
            HighCut = highCut__10
            EarlyLateMix = earlyLateMix__11
            WetLevel = wetLevel__12
        End Sub
#End Region
    End Structure
    '#Pragma warning restore 414

    '
    '    [DEFINE]
    '    [
    '    [NAME]
    '    FMOD_REVERB_PRESETS
    '
    '    [DESCRIPTION]
    '    A set of predefined environment PARAMETERS, created by Creative Labs
    '    These are used to initialize an FMOD_REVERB_PROPERTIES structure statically.
    '    ie
    '    FMOD_REVERB_PROPERTIES prop = FMOD_PRESET_GENERIC;
    '
    '    [SEE_ALSO]
    '    System::setReverbProperties
    '    ]
    '    

    Public Class PRESET
        '                                                                                  Instance  Env   Diffus  Room   RoomHF  RmLF DecTm   DecHF  DecLF   Refl  RefDel   Revb  RevDel  ModTm  ModDp   HFRef    LFRef   Diffus  Densty  FLAGS 

        Public Shared Function OFF() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(1000, 7, 11, 5000, 100, 100, _
             100, 250, 0, 20, 96, -80.0F)
        End Function
        Public Shared Function GENERIC() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(1500, 7, 11, 5000, 83, 100, _
             100, 250, 0, 14500, 96, -8.0F)
        End Function
        Public Shared Function PADDEDCELL() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(170, 1, 2, 5000, 10, 100, _
             100, 250, 0, 160, 84, -7.8F)
        End Function
        Public Shared Function ROOM() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(400, 2, 3, 5000, 83, 100, _
             100, 250, 0, 6050, 88, -9.4F)
        End Function
        Public Shared Function BATHROOM() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(1500, 7, 11, 5000, 54, 100, _
             60, 250, 0, 2900, 83, 0.5F)
        End Function
        Public Shared Function LIVINGROOM() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(500, 3, 4, 5000, 10, 100, _
             100, 250, 0, 160, 58, -19.0F)
        End Function
        Public Shared Function STONEROOM() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(2300, 12, 17, 5000, 64, 100, _
             100, 250, 0, 7800, 71, -8.5F)
        End Function
        Public Shared Function AUDITORIUM() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(4300, 20, 30, 5000, 59, 100, _
             100, 250, 0, 5850, 64, -11.7F)
        End Function
        Public Shared Function CONCERTHALL() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(3900, 20, 29, 5000, 70, 100, _
             100, 250, 0, 5650, 80, -9.8F)
        End Function
        Public Shared Function CAVE() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(2900, 15, 22, 5000, 100, 100, _
             100, 250, 0, 20000, 59, -11.3F)
        End Function
        Public Shared Function ARENA() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(7200, 20, 30, 5000, 33, 100, _
             100, 250, 0, 4500, 80, -9.6F)
        End Function
        Public Shared Function HANGAR() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(10000, 20, 30, 5000, 23, 100, _
             100, 250, 0, 3400, 72, -7.4F)
        End Function
        Public Shared Function CARPETTEDHALLWAY() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(300, 2, 30, 5000, 10, 100, _
             100, 250, 0, 500, 56, -24.0F)
        End Function
        Public Shared Function HALLWAY() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(1500, 7, 11, 5000, 59, 100, _
             100, 250, 0, 7800, 87, -5.5F)
        End Function
        Public Shared Function STONECORRIDOR() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(270, 13, 20, 5000, 79, 100, _
             100, 250, 0, 9000, 86, -6.0F)
        End Function
        Public Shared Function ALLEY() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(1500, 7, 11, 5000, 86, 100, _
             100, 250, 0, 8300, 80, -9.8F)
        End Function
        Public Shared Function FOREST() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(1500, 162, 88, 5000, 54, 79, _
             100, 250, 0, 760, 94, -12.3F)
        End Function
        Public Shared Function CITY() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(1500, 7, 11, 5000, 67, 50, _
             100, 250, 0, 4050, 66, -26.0F)
        End Function
        Public Shared Function MOUNTAINS() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(1500, 300, 100, 5000, 21, 27, _
             100, 250, 0, 1220, 82, -24.0F)
        End Function
        Public Shared Function QUARRY() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(1500, 61, 25, 5000, 83, 100, _
             100, 250, 0, 3400, 100, -5.0F)
        End Function
        Public Shared Function PLAIN() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(1500, 179, 100, 5000, 50, 21, _
             100, 250, 0, 1670, 65, -28.0F)
        End Function
        Public Shared Function PARKINGLOT() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(1700, 8, 12, 5000, 100, 100, _
             100, 250, 0, 20000, 56, -19.5F)
        End Function
        Public Shared Function SEWERPIPE() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(2800, 14, 21, 5000, 14, 80, _
             60, 250, 0, 3400, 66, 1.2F)
        End Function
        Public Shared Function UNDERWATER() As REVERB_PROPERTIES
            Return New REVERB_PROPERTIES(1500, 7, 11, 5000, 10, 100, _
             100, 250, 0, 500, 92, 7.0F)
        End Function
    End Class

    '
    '    [STRUCTURE]
    '    [
    '        [DESCRIPTION]
    '        Settings for advanced features like configuring memory and cpu usage for the FMOD_CREATECOMPRESSEDSAMPLE feature.
    '
    '        [REMARKS]
    '        maxMPEGCodecs / maxADPCMCodecs / maxXMACodecs will determine the maximum cpu usage of playing realtime samples.  Use this to lower potential excess cpu usage and also control memory usage.<br>
    '
    '        [SEE_ALSO]
    '        System::setAdvancedSettings
    '        System::getAdvancedSettings
    '    ]
    '    

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure ADVANCEDSETTINGS
        Public cbSize As Integer
        ' [w]   Size of this structure.  Use sizeof(FMOD_ADVANCEDSETTINGS) 
        Public maxMPEGCodecs As Integer
        ' [r/w] Optional. Specify 0 to ignore. For use with FMOD_CREATECOMPRESSEDSAMPLE only.  MPEG   codecs consume 30,528 bytes per instance and this number will determine how many MPEG   channels can be played simultaneously. Default = 32. 
        Public maxADPCMCodecs As Integer
        ' [r/w] Optional. Specify 0 to ignore. For use with FMOD_CREATECOMPRESSEDSAMPLE only.  ADPCM  codecs consume  3,128 bytes per instance and this number will determine how many ADPCM  channels can be played simultaneously. Default = 32. 
        Public maxXMACodecs As Integer
        ' [r/w] Optional. Specify 0 to ignore. For use with FMOD_CREATECOMPRESSEDSAMPLE only.  XMA    codecs consume 14,836 bytes per instance and this number will determine how many XMA    channels can be played simultaneously. Default = 32. 
        Public maxVorbisCodecs As Integer
        ' [r/w] Optional. Specify 0 to ignore. For use with FMOD_CREATECOMPRESSEDSAMPLE only.  Vorbis codecs consume 23,256 bytes per instance and this number will determine how many Vorbis channels can be played simultaneously. Default = 32. 
        Public maxAT9Codecs As Integer
        ' [r/w] Optional. Specify 0 to ignore. For use with FMOD_CREATECOMPRESSEDSAMPLE only.  AT9    codecs consume  8,720 bytes per instance and this number will determine how many AT9    channels can be played simultaneously. Default = 32. 
        Public maxFADPCMCodecs As Integer
        ' [r/w] Optional. Specify 0 to ignore. For use with FMOD_CREATECOMPRESSEDSAMPLE only.  This number will determine how many FADPCM channels can be played simultaneously. Default = 32. 
        Public maxPCMCodecs As Integer
        ' [r/w] Optional. Specify 0 to ignore. For use with PS3 only.                          PCM    codecs consume 12,672 bytes per instance and this number will determine how many streams and PCM voices can be played simultaneously. Default = 16. 
        Public ASIONumChannels As Integer
        ' [r/w] Optional. Specify 0 to ignore. Number of channels available on the ASIO device. 
        Public ASIOChannelList As IntPtr
        ' [r/w] Optional. Specify 0 to ignore. Pointer to an array of strings (number of entries defined by ASIONumChannels) with ASIO channel names. 
        Public ASIOSpeakerList As IntPtr
        ' [r/w] Optional. Specify 0 to ignore. Pointer to a list of speakers that the ASIO channels map to.  This can be called after System::init to remap ASIO output. 
        Public HRTFMinAngle As Single
        ' [r/w] Optional.                      For use with FMOD_INIT_HRTF_LOWPASS.  The angle range (0-360) of a 3D sound in relation to the listener, at which the HRTF function begins to have an effect. 0 = in front of the listener. 180 = from 90 degrees to the left of the listener to 90 degrees to the right. 360 = behind the listener. Default = 180.0. 
        Public HRTFMaxAngle As Single
        ' [r/w] Optional.                      For use with FMOD_INIT_HRTF_LOWPASS.  The angle range (0-360) of a 3D sound in relation to the listener, at which the HRTF function has maximum effect. 0 = front of the listener. 180 = from 90 degrees to the left of the listener to 90 degrees to the right. 360 = behind the listener. Default = 360.0. 
        Public HRTFFreq As Single
        ' [r/w] Optional. Specify 0 to ignore. For use with FMOD_INIT_HRTF_LOWPASS.  The cutoff frequency of the HRTF's lowpass filter function when at maximum effect. (i.e. at HRTFMaxAngle).  Default = 4000.0. 
        Public vol0virtualvol As Single
        ' [r/w] Optional. Specify 0 to ignore. For use with FMOD_INIT_VOL0_BECOMES_VIRTUAL.  If this flag is used, and the volume is below this, then the sound will become virtual.  Use this value to raise the threshold to a different point where a sound goes virtual. 
        Public defaultDecodeBufferSize As UInteger
        ' [r/w] Optional. Specify 0 to ignore. For streams. This determines the default size of the double buffer (in milliseconds) that a stream uses.  Default = 400ms 
        Public profilePort As UShort
        ' [r/w] Optional. Specify 0 to ignore. For use with FMOD_INIT_PROFILE_ENABLE.  Specify the port to listen on for connections by the profiler application. 
        Public geometryMaxFadeTime As UInteger
        ' [r/w] Optional. Specify 0 to ignore. The maximum time in miliseconds it takes for a channel to fade to the new level when its occlusion changes. 
        Public distanceFilterCenterFreq As Single
        ' [r/w] Optional. Specify 0 to ignore. For use with FMOD_INIT_DISTANCE_FILTERING.  The default center frequency in Hz for the distance filtering effect. Default = 1500.0. 
        Public reverb3Dinstance As Integer
        ' [r/w] Optional. Specify 0 to ignore. Out of 0 to 3, 3d reverb spheres will create a phyical reverb unit on this instance slot.  See FMOD_REVERB_PROPERTIES. 
        Public DSPBufferPoolSize As Integer
        ' [r/w] Optional. Specify 0 to ignore. Number of buffers in DSP buffer pool.  Each buffer will be DSPBlockSize * sizeof(float) * SpeakerModeChannelCount.  ie 7.1 @ 1024 DSP block size = 8 * 1024 * 4 = 32kb.  Default = 8. 
        Public stackSizeStream As UInteger
        ' [r/w] Optional. Specify 0 to ignore. Specify the stack size for the FMOD Stream thread in bytes.  Useful for custom codecs that use excess stack.  Default 49,152 (48kb) 
        Public stackSizeNonBlocking As UInteger
        ' [r/w] Optional. Specify 0 to ignore. Specify the stack size for the FMOD_NONBLOCKING loading thread.  Useful for custom codecs that use excess stack.  Default 65,536 (64kb) 
        Public stackSizeMixer As UInteger
        ' [r/w] Optional. Specify 0 to ignore. Specify the stack size for the FMOD mixer thread.  Useful for custom dsps that use excess stack.  Default 49,152 (48kb) 
        Public resamplerMethod As DSP_RESAMPLER
        ' [r/w] Optional. Specify 0 to ignore. Resampling method used with fmod's software mixer.  See FMOD_DSP_RESAMPLER for details on methods. 
        Public commandQueueSize As UInteger
        ' [r/w] Optional. Specify 0 to ignore. Specify the command queue size for thread safe processing.  Default 2048 (2kb) 
        Public randomSeed As UInteger
        ' [r/w] Optional. Specify 0 to ignore. Seed value that FMOD will use to initialize its internal random number generators. 
    End Structure

    '
    '    [DEFINE]
    '    [
    '        [NAME]
    '        FMOD_DRIVER_STATE
    '
    '        [DESCRIPTION]
    '        Flags that provide additional information about a particular driver.
    '
    '        [REMARKS]
    '
    '        [SEE_ALSO]
    '        System::getRecordDriverInfo
    '    ]
    '    

    <Flags()> _
    Public Enum DRIVER_STATE As UInteger
        CONNECTED = &H1
        ' Device is currently plugged in. 
        [DEFAULT] = &H2
        ' Device is the users preferred choice. 
    End Enum

    '
    '        FMOD System factory functions.  Use this to create an FMOD System Instance.  below you will see System init/close to get started.
    '    

    Public Class Factory
        Public Shared Function System_Create(ByRef system As System) As RESULT
            system = Nothing

            Dim result__1 As RESULT = RESULT.OK
            Dim rawPtr As New IntPtr()

            result__1 = FMOD_System_Create(rawPtr)
            If result__1 <> RESULT.OK Then
                Return result__1
            End If

            system = New System(rawPtr)

            Return result__1
        End Function


#Region "importfunctions"

        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_Create(ByRef system As IntPtr) As RESULT
        End Function

#End Region
    End Class

    Public Class Memory
        Public Shared Function Initialize(ByVal poolmem As IntPtr, ByVal poollen As Integer, ByVal useralloc As MEMORY_ALLOC_CALLBACK, ByVal userrealloc As MEMORY_REALLOC_CALLBACK, ByVal userfree As MEMORY_FREE_CALLBACK, ByVal memtypeflags As MEMORY_TYPE) As RESULT
            Return FMOD_Memory_Initialize(poolmem, poollen, useralloc, userrealloc, userfree, memtypeflags)
        End Function

        Public Shared Function GetStats(ByRef currentalloced As Integer, ByRef maxalloced As Integer) As RESULT
            Return GetStats(currentalloced, maxalloced, False)
        End Function

        Public Shared Function GetStats(ByRef currentalloced As Integer, ByRef maxalloced As Integer, ByVal blocking As Boolean) As RESULT
            Return FMOD_Memory_GetStats(currentalloced, maxalloced, blocking)
        End Function


#Region "importfunctions"

        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Memory_Initialize(ByVal poolmem As IntPtr, ByVal poollen As Integer, ByVal useralloc As MEMORY_ALLOC_CALLBACK, ByVal userrealloc As MEMORY_REALLOC_CALLBACK, ByVal userfree As MEMORY_FREE_CALLBACK, ByVal memtypeflags As MEMORY_TYPE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Memory_GetStats(ByRef currentalloced As Integer, ByRef maxalloced As Integer, ByVal blocking As Boolean) As RESULT
        End Function

#End Region
    End Class

    Public Class Debug
        Public Shared Function Initialize(ByVal flags As DEBUG_FLAGS, ByVal mode As DEBUG_MODE, ByVal callback As DEBUG_CALLBACK, ByVal filename As String) As RESULT
            Return FMOD_Debug_Initialize(flags, mode, callback, filename)
        End Function


#Region "importfunctions"

        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Debug_Initialize(ByVal flags As DEBUG_FLAGS, ByVal mode As DEBUG_MODE, ByVal callback As DEBUG_CALLBACK, ByVal filename As String) As RESULT
        End Function

#End Region
    End Class

    Public Class HandleBase
        Public Sub New(ByVal newPtr As IntPtr)
            rawPtr = newPtr
        End Sub

        Public Function isValid() As Boolean
            Return rawPtr <> IntPtr.Zero
        End Function

        Public Function getRaw() As IntPtr
            Return rawPtr
        End Function

        Protected rawPtr As IntPtr

#Region "equality"

        Public Overrides Function Equals(ByVal obj As [Object]) As Boolean
            Return Equals(TryCast(obj, HandleBase))
        End Function
        Public Overloads Function Equals(ByVal p As HandleBase) As Boolean
            ' Equals if p not null and handle is the same
            Return (DirectCast(p, Object) IsNot Nothing AndAlso rawPtr = p.rawPtr)
        End Function
        Public Overrides Function GetHashCode() As Integer
            Return rawPtr.ToInt32()
        End Function
        Public Shared Operator =(ByVal a As HandleBase, ByVal b As HandleBase) As Boolean
            ' If both are null, or both are same instance, return true.
            If [Object].ReferenceEquals(a, b) Then
                Return True
            End If
            ' If one is null, but not both, return false.
            If (DirectCast(a, Object) Is Nothing) OrElse (DirectCast(b, Object) Is Nothing) Then
                Return False
            End If
            ' Return true if the handle matches
            Return (a.rawPtr = b.rawPtr)
        End Operator
        Public Shared Operator <>(ByVal a As HandleBase, ByVal b As HandleBase) As Boolean
            Return Not (a = b)
        End Operator
#End Region

    End Class

    '
    '        'System' API.
    '    

    Public Class System
        Inherits HandleBase
        Public Function release() As RESULT
            Dim result__1 As RESULT = FMOD_System_Release(rawPtr)
            If result__1 = RESULT.OK Then
                rawPtr = IntPtr.Zero
            End If
            Return result__1
        End Function


        ' Pre-init functions.
        Public Function setOutput(ByVal output As OUTPUTTYPE) As RESULT
            Return FMOD_System_SetOutput(rawPtr, output)
        End Function
        Public Function getOutput(ByRef output As OUTPUTTYPE) As RESULT
            Return FMOD_System_GetOutput(rawPtr, output)
        End Function
        Public Function getNumDrivers(ByRef numdrivers As Integer) As RESULT
            Return FMOD_System_GetNumDrivers(rawPtr, numdrivers)
        End Function
        Public Function getDriverInfo(ByVal id As Integer, ByVal name As StringBuilder, ByVal namelen As Integer, ByRef guid As Guid, ByRef systemrate As Integer, ByRef speakermode As SPEAKERMODE, _
         ByRef speakermodechannels As Integer) As RESULT
            Dim stringMem As IntPtr = Marshal.AllocHGlobal(name.Capacity)

            Dim result As RESULT = FMOD_System_GetDriverInfo(rawPtr, id, stringMem, namelen, guid, systemrate, _
             speakermode, speakermodechannels)

            StringMarshalHelper.NativeToBuilder(name, stringMem)
            Marshal.FreeHGlobal(stringMem)

            Return result
        End Function
        Public Function setDriver(ByVal driver As Integer) As RESULT
            Return FMOD_System_SetDriver(rawPtr, driver)
        End Function
        Public Function getDriver(ByRef driver As Integer) As RESULT
            Return FMOD_System_GetDriver(rawPtr, driver)
        End Function
        Public Function setSoftwareChannels(ByVal numsoftwarechannels As Integer) As RESULT
            Return FMOD_System_SetSoftwareChannels(rawPtr, numsoftwarechannels)
        End Function
        Public Function getSoftwareChannels(ByRef numsoftwarechannels As Integer) As RESULT
            Return FMOD_System_GetSoftwareChannels(rawPtr, numsoftwarechannels)
        End Function
        Public Function setSoftwareFormat(ByVal samplerate As Integer, ByVal speakermode As SPEAKERMODE, ByVal numrawspeakers As Integer) As RESULT
            Return FMOD_System_SetSoftwareFormat(rawPtr, samplerate, speakermode, numrawspeakers)
        End Function
        Public Function getSoftwareFormat(ByRef samplerate As Integer, ByRef speakermode As SPEAKERMODE, ByRef numrawspeakers As Integer) As RESULT
            Return FMOD_System_GetSoftwareFormat(rawPtr, samplerate, speakermode, numrawspeakers)
        End Function
        Public Function setDSPBufferSize(ByVal bufferlength As UInteger, ByVal numbuffers As Integer) As RESULT
            Return FMOD_System_SetDSPBufferSize(rawPtr, bufferlength, numbuffers)
        End Function
        Public Function getDSPBufferSize(ByRef bufferlength As UInteger, ByRef numbuffers As Integer) As RESULT
            Return FMOD_System_GetDSPBufferSize(rawPtr, bufferlength, numbuffers)
        End Function
        Public Function setFileSystem(ByVal useropen As FILE_OPENCALLBACK, ByVal userclose As FILE_CLOSECALLBACK, ByVal userread As FILE_READCALLBACK, ByVal userseek As FILE_SEEKCALLBACK, ByVal userasyncread As FILE_ASYNCREADCALLBACK, ByVal userasynccancel As FILE_ASYNCCANCELCALLBACK, _
         ByVal blockalign As Integer) As RESULT
            Return FMOD_System_SetFileSystem(rawPtr, useropen, userclose, userread, userseek, userasyncread, _
             userasynccancel, blockalign)
        End Function
        Public Function attachFileSystem(ByVal useropen As FILE_OPENCALLBACK, ByVal userclose As FILE_CLOSECALLBACK, ByVal userread As FILE_READCALLBACK, ByVal userseek As FILE_SEEKCALLBACK) As RESULT
            Return FMOD_System_AttachFileSystem(rawPtr, useropen, userclose, userread, userseek)
        End Function
        Public Function setAdvancedSettings(ByRef settings As ADVANCEDSETTINGS) As RESULT
            settings.cbSize = Marshal.SizeOf(settings)
            Return FMOD_System_SetAdvancedSettings(rawPtr, settings)
        End Function
        Public Function getAdvancedSettings(ByRef settings As ADVANCEDSETTINGS) As RESULT
            settings.cbSize = Marshal.SizeOf(settings)
            Return FMOD_System_GetAdvancedSettings(rawPtr, settings)
        End Function
        Public Function setCallback(ByVal callback As SYSTEM_CALLBACK, ByVal callbackmask As SYSTEM_CALLBACK_TYPE) As RESULT
            Return FMOD_System_SetCallback(rawPtr, callback, callbackmask)
        End Function

        ' Plug-in support.
        Public Function setPluginPath(ByVal path As String) As RESULT
            Return FMOD_System_SetPluginPath(rawPtr, Encoding.UTF8.GetBytes(path + [Char].MinValue))
        End Function
        Public Function loadPlugin(ByVal filename As String, ByRef handle As UInteger, ByVal priority As UInteger) As RESULT
            Return FMOD_System_LoadPlugin(rawPtr, Encoding.UTF8.GetBytes(filename + [Char].MinValue), handle, priority)
        End Function
        Public Function loadPlugin(ByVal filename As String, ByRef handle As UInteger) As RESULT
            Return loadPlugin(filename, handle, 0)
        End Function
        Public Function unloadPlugin(ByVal handle As UInteger) As RESULT
            Return FMOD_System_UnloadPlugin(rawPtr, handle)
        End Function
        Public Function getNumPlugins(ByVal plugintype As PLUGINTYPE, ByRef numplugins As Integer) As RESULT
            Return FMOD_System_GetNumPlugins(rawPtr, plugintype, numplugins)
        End Function
        Public Function getPluginHandle(ByVal plugintype As PLUGINTYPE, ByVal index As Integer, ByRef handle As UInteger) As RESULT
            Return FMOD_System_GetPluginHandle(rawPtr, plugintype, index, handle)
        End Function
        Public Function getPluginInfo(ByVal handle As UInteger, ByRef plugintype As PLUGINTYPE, ByVal name As StringBuilder, ByVal namelen As Integer, ByRef version As UInteger) As RESULT
            Dim stringMem As IntPtr = Marshal.AllocHGlobal(name.Capacity)

            Dim result As RESULT = FMOD_System_GetPluginInfo(rawPtr, handle, plugintype, stringMem, namelen, version)

            StringMarshalHelper.NativeToBuilder(name, stringMem)
            Marshal.FreeHGlobal(stringMem)

            Return result
        End Function
        Public Function setOutputByPlugin(ByVal handle As UInteger) As RESULT
            Return FMOD_System_SetOutputByPlugin(rawPtr, handle)
        End Function
        Public Function getOutputByPlugin(ByRef handle As UInteger) As RESULT
            Return FMOD_System_GetOutputByPlugin(rawPtr, handle)
        End Function
        Public Function createDSPByPlugin(ByVal handle As UInteger, ByRef dsp As DSP) As RESULT
            dsp = Nothing

            Dim dspraw As IntPtr
            Dim result As RESULT = FMOD_System_CreateDSPByPlugin(rawPtr, handle, dspraw)
            dsp = New DSP(dspraw)

            Return result
        End Function
        Public Function getDSPInfoByPlugin(ByVal handle As UInteger, ByRef description As IntPtr) As RESULT
            Return FMOD_System_GetDSPInfoByPlugin(rawPtr, handle, description)
        End Function
        '
        '        public RESULT registerCodec(ref CODEC_DESCRIPTION description, out uint handle, uint priority)
        '        {
        '            return FMOD_System_RegisterCodec(rawPtr, ref description, out handle, priority);
        '        }
        '        

        Public Function registerDSP(ByRef description As DSP_DESCRIPTION, ByRef handle As UInteger) As RESULT
            Return FMOD_System_RegisterDSP(rawPtr, description, handle)
        End Function
        '
        '        public RESULT registerOutput(ref OUTPUT_DESCRIPTION description, out uint handle)
        '        {
        '            return FMOD_System_RegisterOutput(rawPtr, ref description, out handle);
        '        }
        '        


        ' Init/Close.
        Public Function init(ByVal maxchannels As Integer, ByVal flags As INITFLAGS, ByVal extradriverdata As IntPtr) As RESULT
            Return FMOD_System_Init(rawPtr, maxchannels, flags, extradriverdata)
        End Function
        Public Function close() As RESULT
            Return FMOD_System_Close(rawPtr)
        End Function


        ' General post-init system functions.
        Public Function update() As RESULT
            Return FMOD_System_Update(rawPtr)
        End Function

        Public Function setSpeakerPosition(ByVal speaker As SPEAKER, ByVal x As Single, ByVal y As Single, ByVal active As Boolean) As RESULT
            Return FMOD_System_SetSpeakerPosition(rawPtr, speaker, x, y, active)
        End Function
        Public Function getSpeakerPosition(ByVal speaker As SPEAKER, ByRef x As Single, ByRef y As Single, ByRef active As Boolean) As RESULT
            Return FMOD_System_GetSpeakerPosition(rawPtr, speaker, x, y, active)
        End Function
        Public Function setStreamBufferSize(ByVal filebuffersize As UInteger, ByVal filebuffersizetype As TIMEUNIT) As RESULT
            Return FMOD_System_SetStreamBufferSize(rawPtr, filebuffersize, filebuffersizetype)
        End Function
        Public Function getStreamBufferSize(ByRef filebuffersize As UInteger, ByRef filebuffersizetype As TIMEUNIT) As RESULT
            Return FMOD_System_GetStreamBufferSize(rawPtr, filebuffersize, filebuffersizetype)
        End Function
        Public Function set3DSettings(ByVal dopplerscale As Single, ByVal distancefactor As Single, ByVal rolloffscale As Single) As RESULT
            Return FMOD_System_Set3DSettings(rawPtr, dopplerscale, distancefactor, rolloffscale)
        End Function
        Public Function get3DSettings(ByRef dopplerscale As Single, ByRef distancefactor As Single, ByRef rolloffscale As Single) As RESULT
            Return FMOD_System_Get3DSettings(rawPtr, dopplerscale, distancefactor, rolloffscale)
        End Function
        Public Function set3DNumListeners(ByVal numlisteners As Integer) As RESULT
            Return FMOD_System_Set3DNumListeners(rawPtr, numlisteners)
        End Function
        Public Function get3DNumListeners(ByRef numlisteners As Integer) As RESULT
            Return FMOD_System_Get3DNumListeners(rawPtr, numlisteners)
        End Function
        Public Function set3DListenerAttributes(ByVal listener As Integer, ByRef pos As VECTOR, ByRef vel As VECTOR, ByRef forward As VECTOR, ByRef up As VECTOR) As RESULT
            Return FMOD_System_Set3DListenerAttributes(rawPtr, listener, pos, vel, forward, up)
        End Function
        Public Function get3DListenerAttributes(ByVal listener As Integer, ByRef pos As VECTOR, ByRef vel As VECTOR, ByRef forward As VECTOR, ByRef up As VECTOR) As RESULT
            Return FMOD_System_Get3DListenerAttributes(rawPtr, listener, pos, vel, forward, up)
        End Function
        Public Function set3DRolloffCallback(ByVal callback As CB_3D_ROLLOFFCALLBACK) As RESULT
            Return FMOD_System_Set3DRolloffCallback(rawPtr, callback)
        End Function
        Public Function mixerSuspend() As RESULT
            Return FMOD_System_MixerSuspend(rawPtr)
        End Function
        Public Function mixerResume() As RESULT
            Return FMOD_System_MixerResume(rawPtr)
        End Function
        Public Function getDefaultMixMatrix(ByVal sourcespeakermode As SPEAKERMODE, ByVal targetspeakermode As SPEAKERMODE, ByVal matrix As Single(), ByVal matrixhop As Integer) As RESULT
            Return FMOD_System_GetDefaultMixMatrix(rawPtr, sourcespeakermode, targetspeakermode, matrix, matrixhop)
        End Function
        Public Function getSpeakerModeChannels(ByVal mode As SPEAKERMODE, ByRef channels As Integer) As RESULT
            Return FMOD_System_GetSpeakerModeChannels(rawPtr, mode, channels)
        End Function

        ' System information functions.
        Public Function getVersion(ByRef version As UInteger) As RESULT
            Return FMOD_System_GetVersion(rawPtr, version)
        End Function
        Public Function getOutputHandle(ByRef handle As IntPtr) As RESULT
            Return FMOD_System_GetOutputHandle(rawPtr, handle)
        End Function
        Public Function getChannelsPlaying(ByRef channels As Integer) As RESULT
            Return FMOD_System_GetChannelsPlaying(rawPtr, channels)
        End Function
        Public Function getChannelsReal(ByRef channels As Integer) As RESULT
            Return FMOD_System_GetChannelsReal(rawPtr, channels)
        End Function
        Public Function getCPUUsage(ByRef dsp As Single, ByRef stream As Single, ByRef geometry As Single, ByRef update As Single, ByRef total As Single) As RESULT
            Return FMOD_System_GetCPUUsage(rawPtr, dsp, stream, geometry, update, total)
        End Function
        Public Function getSoundRAM(ByRef currentalloced As Integer, ByRef maxalloced As Integer, ByRef total As Integer) As RESULT
            Return FMOD_System_GetSoundRAM(rawPtr, currentalloced, maxalloced, total)
        End Function

        ' Sound/DSP/Channel/FX creation and retrieval.
        Public Function createSound(ByVal name As String, ByVal mode As MODE, ByRef exinfo As CREATESOUNDEXINFO, ByRef sound As Sound) As RESULT
            sound = Nothing

            Dim stringData As Byte()
            stringData = Encoding.UTF8.GetBytes(name + [Char].MinValue)

            exinfo.cbsize = Marshal.SizeOf(exinfo)

            Dim soundraw As IntPtr
            Dim result As RESULT = FMOD_System_CreateSound(rawPtr, stringData, mode, exinfo, soundraw)
            sound = New Sound(soundraw)

            Return result
        End Function
        Public Function createSound(ByVal data As Byte(), ByVal mode As MODE, ByRef exinfo As CREATESOUNDEXINFO, ByRef sound As Sound) As RESULT
            sound = Nothing

            exinfo.cbsize = Marshal.SizeOf(exinfo)

            Dim soundraw As IntPtr
            Dim result As RESULT = FMOD_System_CreateSound(rawPtr, data, mode, exinfo, soundraw)
            sound = New Sound(soundraw)

            Return result
        End Function
        Public Function createSound(ByVal name As String, ByVal mode As MODE, ByRef sound As Sound) As RESULT
            Dim exinfo As New CREATESOUNDEXINFO()
            exinfo.cbsize = Marshal.SizeOf(exinfo)

            Return createSound(name, mode, exinfo, sound)
        End Function
        Public Function createStream(ByVal name As String, ByVal mode As MODE, ByRef exinfo As CREATESOUNDEXINFO, ByRef sound As Sound) As RESULT
            sound = Nothing

            Dim stringData As Byte()
            stringData = Encoding.UTF8.GetBytes(name + [Char].MinValue)

            exinfo.cbsize = Marshal.SizeOf(exinfo)

            Dim soundraw As IntPtr
            Dim result As RESULT = FMOD_System_CreateStream(rawPtr, stringData, mode, exinfo, soundraw)
            sound = New Sound(soundraw)

            Return result
        End Function
        Public Function createStream(ByVal data As Byte(), ByVal mode As MODE, ByRef exinfo As CREATESOUNDEXINFO, ByRef sound As Sound) As RESULT
            sound = Nothing

            exinfo.cbsize = Marshal.SizeOf(exinfo)

            Dim soundraw As IntPtr
            Dim result As RESULT = FMOD_System_CreateStream(rawPtr, data, mode, exinfo, soundraw)
            sound = New Sound(soundraw)

            Return result
        End Function
        Public Function createStream(ByVal name As String, ByVal mode As MODE, ByRef sound As Sound) As RESULT
            Dim exinfo As New CREATESOUNDEXINFO()
            exinfo.cbsize = Marshal.SizeOf(exinfo)

            Return createStream(name, mode, exinfo, sound)
        End Function
        Public Function createDSP(ByRef description As DSP_DESCRIPTION, ByRef dsp As DSP) As RESULT
            dsp = Nothing

            Dim dspraw As IntPtr
            Dim result As RESULT = FMOD_System_CreateDSP(rawPtr, description, dspraw)
            dsp = New DSP(dspraw)

            Return result
        End Function
        Public Function createDSPByType(ByVal type As DSP_TYPE, ByRef dsp As DSP) As RESULT
            dsp = Nothing

            Dim dspraw As IntPtr
            Dim result As RESULT = FMOD_System_CreateDSPByType(rawPtr, type, dspraw)
            dsp = New DSP(dspraw)

            Return result
        End Function
        Public Function createChannelGroup(ByVal name As String, ByRef channelgroup As ChannelGroup) As RESULT
            channelgroup = Nothing

            Dim stringData As Byte() = Encoding.UTF8.GetBytes(name + [Char].MinValue)

            Dim channelgroupraw As IntPtr
            Dim result As RESULT = FMOD_System_CreateChannelGroup(rawPtr, stringData, channelgroupraw)
            channelgroup = New ChannelGroup(channelgroupraw)

            Return result
        End Function
        Public Function createSoundGroup(ByVal name As String, ByRef soundgroup As SoundGroup) As RESULT
            soundgroup = Nothing

            Dim stringData As Byte() = Encoding.UTF8.GetBytes(name + [Char].MinValue)

            Dim soundgroupraw As IntPtr
            Dim result As RESULT = FMOD_System_CreateSoundGroup(rawPtr, stringData, soundgroupraw)
            soundgroup = New SoundGroup(soundgroupraw)

            Return result
        End Function
        Public Function createReverb3D(ByRef reverb As Reverb3D) As RESULT
            Dim reverbraw As IntPtr
            Dim result As RESULT = FMOD_System_CreateReverb3D(rawPtr, reverbraw)
            reverb = New Reverb3D(reverbraw)

            Return result
        End Function
        Public Function playSound(ByVal sound As Sound, ByVal channelGroup As ChannelGroup, ByVal paused As Boolean, ByRef channel As Channel) As RESULT
            channel = Nothing

            Dim channelGroupRaw As IntPtr = If((channelGroup IsNot Nothing), channelGroup.getRaw(), IntPtr.Zero)

            Dim channelraw As IntPtr
            Dim result As RESULT = FMOD_System_PlaySound(rawPtr, sound.getRaw(), channelGroupRaw, paused, channelraw)
            channel = New Channel(channelraw)

            Return result
        End Function
        Public Function playDSP(ByVal dsp As DSP, ByVal channelGroup As ChannelGroup, ByVal paused As Boolean, ByRef channel As Channel) As RESULT
            channel = Nothing

            Dim channelGroupRaw As IntPtr = If((channelGroup IsNot Nothing), channelGroup.getRaw(), IntPtr.Zero)

            Dim channelraw As IntPtr
            Dim result As RESULT = FMOD_System_PlayDSP(rawPtr, dsp.getRaw(), channelGroupRaw, paused, channelraw)
            channel = New Channel(channelraw)

            Return result
        End Function
        Public Function getChannel(ByVal channelid As Integer, ByRef channel As Channel) As RESULT
            channel = Nothing

            Dim channelraw As IntPtr
            Dim result As RESULT = FMOD_System_GetChannel(rawPtr, channelid, channelraw)
            channel = New Channel(channelraw)

            Return result
        End Function
        Public Function getMasterChannelGroup(ByRef channelgroup As ChannelGroup) As RESULT
            channelgroup = Nothing

            Dim channelgroupraw As IntPtr
            Dim result As RESULT = FMOD_System_GetMasterChannelGroup(rawPtr, channelgroupraw)
            channelgroup = New ChannelGroup(channelgroupraw)

            Return result
        End Function
        Public Function getMasterSoundGroup(ByRef soundgroup As SoundGroup) As RESULT
            soundgroup = Nothing

            Dim soundgroupraw As IntPtr
            Dim result As RESULT = FMOD_System_GetMasterSoundGroup(rawPtr, soundgroupraw)
            soundgroup = New SoundGroup(soundgroupraw)

            Return result
        End Function

        ' Routing to ports.
        Public Function attachChannelGroupToPort(ByVal portType As UInteger, ByVal portIndex As ULong, ByVal channelgroup As ChannelGroup, Optional ByVal passThru As Boolean = False) As RESULT
            Return FMOD_System_AttachChannelGroupToPort(rawPtr, portType, portIndex, channelgroup.getRaw(), passThru)
        End Function
        Public Function detachChannelGroupFromPort(ByVal channelgroup As ChannelGroup) As RESULT
            Return FMOD_System_DetachChannelGroupFromPort(rawPtr, channelgroup.getRaw())
        End Function

        ' Reverb api.
        Public Function setReverbProperties(ByVal instance As Integer, ByRef prop As REVERB_PROPERTIES) As RESULT
            Return FMOD_System_SetReverbProperties(rawPtr, instance, prop)
        End Function
        Public Function getReverbProperties(ByVal instance As Integer, ByRef prop As REVERB_PROPERTIES) As RESULT
            Return FMOD_System_GetReverbProperties(rawPtr, instance, prop)
        End Function

        ' System level DSP functionality.
        Public Function lockDSP() As RESULT
            Return FMOD_System_LockDSP(rawPtr)
        End Function
        Public Function unlockDSP() As RESULT
            Return FMOD_System_UnlockDSP(rawPtr)
        End Function

        ' Recording api
        Public Function getRecordNumDrivers(ByRef numdrivers As Integer, ByRef numconnected As Integer) As RESULT
            Return FMOD_System_GetRecordNumDrivers(rawPtr, numdrivers, numconnected)
        End Function
        Public Function getRecordDriverInfo(ByVal id As Integer, ByVal name As StringBuilder, ByVal namelen As Integer, ByRef guid As Guid, ByRef systemrate As Integer, ByRef speakermode As SPEAKERMODE, _
         ByRef speakermodechannels As Integer, ByRef state As DRIVER_STATE) As RESULT
            Dim stringMem As IntPtr = Marshal.AllocHGlobal(name.Capacity)

            Dim result As RESULT = FMOD_System_GetRecordDriverInfo(rawPtr, id, stringMem, namelen, guid, systemrate, _
             speakermode, speakermodechannels, state)

            StringMarshalHelper.NativeToBuilder(name, stringMem)
            Marshal.FreeHGlobal(stringMem)

            Return result
        End Function
        Public Function getRecordPosition(ByVal id As Integer, ByRef position As UInteger) As RESULT
            Return FMOD_System_GetRecordPosition(rawPtr, id, position)
        End Function
        Public Function recordStart(ByVal id As Integer, ByVal sound As Sound, ByVal [loop] As Boolean) As RESULT
            Return FMOD_System_RecordStart(rawPtr, id, sound.getRaw(), [loop])
        End Function
        Public Function recordStop(ByVal id As Integer) As RESULT
            Return FMOD_System_RecordStop(rawPtr, id)
        End Function
        Public Function isRecording(ByVal id As Integer, ByRef recording As Boolean) As RESULT
            Return FMOD_System_IsRecording(rawPtr, id, recording)
        End Function

        ' Geometry api
        Public Function createGeometry(ByVal maxpolygons As Integer, ByVal maxvertices As Integer, ByRef geometry As Geometry) As RESULT
            geometry = Nothing

            Dim geometryraw As IntPtr
            Dim result As RESULT = FMOD_System_CreateGeometry(rawPtr, maxpolygons, maxvertices, geometryraw)
            geometry = New Geometry(geometryraw)

            Return result
        End Function
        Public Function setGeometrySettings(ByVal maxworldsize As Single) As RESULT
            Return FMOD_System_SetGeometrySettings(rawPtr, maxworldsize)
        End Function
        Public Function getGeometrySettings(ByRef maxworldsize As Single) As RESULT
            Return FMOD_System_GetGeometrySettings(rawPtr, maxworldsize)
        End Function
        Public Function loadGeometry(ByVal data As IntPtr, ByVal datasize As Integer, ByRef geometry As Geometry) As RESULT
            geometry = Nothing

            Dim geometryraw As IntPtr
            Dim result As RESULT = FMOD_System_LoadGeometry(rawPtr, data, datasize, geometryraw)
            geometry = New Geometry(geometryraw)

            Return result
        End Function
        Public Function getGeometryOcclusion(ByRef listener As VECTOR, ByRef source As VECTOR, ByRef direct As Single, ByRef reverb As Single) As RESULT
            Return FMOD_System_GetGeometryOcclusion(rawPtr, listener, source, direct, reverb)
        End Function

        ' Network functions
        Public Function setNetworkProxy(ByVal proxy As String) As RESULT
            Return FMOD_System_SetNetworkProxy(rawPtr, Encoding.UTF8.GetBytes(proxy + [Char].MinValue))
        End Function
        Public Function getNetworkProxy(ByVal proxy As StringBuilder, ByVal proxylen As Integer) As RESULT
            Dim stringMem As IntPtr = Marshal.AllocHGlobal(proxy.Capacity)

            Dim result As RESULT = FMOD_System_GetNetworkProxy(rawPtr, stringMem, proxylen)

            StringMarshalHelper.NativeToBuilder(proxy, stringMem)
            Marshal.FreeHGlobal(stringMem)

            Return result
        End Function
        Public Function setNetworkTimeout(ByVal timeout As Integer) As RESULT
            Return FMOD_System_SetNetworkTimeout(rawPtr, timeout)
        End Function
        Public Function getNetworkTimeout(ByRef timeout As Integer) As RESULT
            Return FMOD_System_GetNetworkTimeout(rawPtr, timeout)
        End Function

        ' Userdata set/get
        Public Function setUserData(ByVal userdata As IntPtr) As RESULT
            Return FMOD_System_SetUserData(rawPtr, userdata)
        End Function
        Public Function getUserData(ByRef userdata As IntPtr) As RESULT
            Return FMOD_System_GetUserData(rawPtr, userdata)
        End Function


#Region "importfunctions"
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_Release(ByVal system As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetOutput(ByVal system As IntPtr, ByVal output As OUTPUTTYPE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetOutput(ByVal system As IntPtr, ByRef output As OUTPUTTYPE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetNumDrivers(ByVal system As IntPtr, ByRef numdrivers As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetDriverInfo(ByVal system As IntPtr, ByVal id As Integer, ByVal name As IntPtr, ByVal namelen As Integer, ByRef guid As Guid, ByRef systemrate As Integer, _
   ByRef speakermode As SPEAKERMODE, ByRef speakermodechannels As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetDriver(ByVal system As IntPtr, ByVal driver As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetDriver(ByVal system As IntPtr, ByRef driver As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetSoftwareChannels(ByVal system As IntPtr, ByVal numsoftwarechannels As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetSoftwareChannels(ByVal system As IntPtr, ByRef numsoftwarechannels As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetSoftwareFormat(ByVal system As IntPtr, ByVal samplerate As Integer, ByVal speakermode As SPEAKERMODE, ByVal numrawspeakers As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetSoftwareFormat(ByVal system As IntPtr, ByRef samplerate As Integer, ByRef speakermode As SPEAKERMODE, ByRef numrawspeakers As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetDSPBufferSize(ByVal system As IntPtr, ByVal bufferlength As UInteger, ByVal numbuffers As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetDSPBufferSize(ByVal system As IntPtr, ByRef bufferlength As UInteger, ByRef numbuffers As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetFileSystem(ByVal system As IntPtr, ByVal useropen As FILE_OPENCALLBACK, ByVal userclose As FILE_CLOSECALLBACK, ByVal userread As FILE_READCALLBACK, ByVal userseek As FILE_SEEKCALLBACK, ByVal userasyncread As FILE_ASYNCREADCALLBACK, _
   ByVal userasynccancel As FILE_ASYNCCANCELCALLBACK, ByVal blockalign As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_AttachFileSystem(ByVal system As IntPtr, ByVal useropen As FILE_OPENCALLBACK, ByVal userclose As FILE_CLOSECALLBACK, ByVal userread As FILE_READCALLBACK, ByVal userseek As FILE_SEEKCALLBACK) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetPluginPath(ByVal system As IntPtr, ByVal path As Byte()) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_LoadPlugin(ByVal system As IntPtr, ByVal filename As Byte(), ByRef handle As UInteger, ByVal priority As UInteger) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_UnloadPlugin(ByVal system As IntPtr, ByVal handle As UInteger) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetNumPlugins(ByVal system As IntPtr, ByVal plugintype As PLUGINTYPE, ByRef numplugins As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetPluginHandle(ByVal system As IntPtr, ByVal plugintype As PLUGINTYPE, ByVal index As Integer, ByRef handle As UInteger) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetPluginInfo(ByVal system As IntPtr, ByVal handle As UInteger, ByRef plugintype As PLUGINTYPE, ByVal name As IntPtr, ByVal namelen As Integer, ByRef version__1 As UInteger) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_CreateDSPByPlugin(ByVal system As IntPtr, ByVal handle As UInteger, ByRef dsp As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetOutputByPlugin(ByVal system As IntPtr, ByVal handle As UInteger) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetOutputByPlugin(ByVal system As IntPtr, ByRef handle As UInteger) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetDSPInfoByPlugin(ByVal system As IntPtr, ByVal handle As UInteger, ByRef description As IntPtr) As RESULT
        End Function
        'private static extern RESULT FMOD_System_RegisterCodec          (IntPtr system, out CODEC_DESCRIPTION description, out uint handle, uint priority);
        '[DllImport(VERSION.dll)]
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_RegisterDSP(ByVal system As IntPtr, ByRef description As DSP_DESCRIPTION, ByRef handle As UInteger) As RESULT
        End Function
        'private static extern RESULT FMOD_System_RegisterOutput         (IntPtr system, ref OUTPUT_DESCRIPTION description, out uint handle);
        '[DllImport(VERSION.dll)]
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_Init(ByVal system As IntPtr, ByVal maxchannels As Integer, ByVal flags As INITFLAGS, ByVal extradriverdata As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_Close(ByVal system As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_Update(ByVal system As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetAdvancedSettings(ByVal system As IntPtr, ByRef settings As ADVANCEDSETTINGS) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetAdvancedSettings(ByVal system As IntPtr, ByRef settings As ADVANCEDSETTINGS) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_Set3DRolloffCallback(ByVal system As IntPtr, ByVal callback As CB_3D_ROLLOFFCALLBACK) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_MixerSuspend(ByVal system As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_MixerResume(ByVal system As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetDefaultMixMatrix(ByVal system As IntPtr, ByVal sourcespeakermode As SPEAKERMODE, ByVal targetspeakermode As SPEAKERMODE, ByVal matrix As Single(), ByVal matrixhop As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetSpeakerModeChannels(ByVal system As IntPtr, ByVal mode As SPEAKERMODE, ByRef channels As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetCallback(ByVal system As IntPtr, ByVal callback As SYSTEM_CALLBACK, ByVal callbackmask As SYSTEM_CALLBACK_TYPE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetSpeakerPosition(ByVal system As IntPtr, ByVal speaker As SPEAKER, ByVal x As Single, ByVal y As Single, ByVal active As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetSpeakerPosition(ByVal system As IntPtr, ByVal speaker As SPEAKER, ByRef x As Single, ByRef y As Single, ByRef active As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_Set3DSettings(ByVal system As IntPtr, ByVal dopplerscale As Single, ByVal distancefactor As Single, ByVal rolloffscale As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_Get3DSettings(ByVal system As IntPtr, ByRef dopplerscale As Single, ByRef distancefactor As Single, ByRef rolloffscale As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_Set3DNumListeners(ByVal system As IntPtr, ByVal numlisteners As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_Get3DNumListeners(ByVal system As IntPtr, ByRef numlisteners As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_Set3DListenerAttributes(ByVal system As IntPtr, ByVal listener As Integer, ByRef pos As VECTOR, ByRef vel As VECTOR, ByRef forward As VECTOR, ByRef up As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_Get3DListenerAttributes(ByVal system As IntPtr, ByVal listener As Integer, ByRef pos As VECTOR, ByRef vel As VECTOR, ByRef forward As VECTOR, ByRef up As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetStreamBufferSize(ByVal system As IntPtr, ByVal filebuffersize As UInteger, ByVal filebuffersizetype As TIMEUNIT) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetStreamBufferSize(ByVal system As IntPtr, ByRef filebuffersize As UInteger, ByRef filebuffersizetype As TIMEUNIT) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetVersion(ByVal system As IntPtr, ByRef version__1 As UInteger) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetOutputHandle(ByVal system As IntPtr, ByRef handle As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetChannelsPlaying(ByVal system As IntPtr, ByRef channels As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetChannelsReal(ByVal system As IntPtr, ByRef channels As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetCPUUsage(ByVal system As IntPtr, ByRef dsp As Single, ByRef stream As Single, ByRef geometry As Single, ByRef update As Single, ByRef total As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetSoundRAM(ByVal system As IntPtr, ByRef currentalloced As Integer, ByRef maxalloced As Integer, ByRef total As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_CreateSound(ByVal system As IntPtr, ByVal name_or_data As Byte(), ByVal mode As MODE, ByRef exinfo As CREATESOUNDEXINFO, ByRef sound As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_CreateStream(ByVal system As IntPtr, ByVal name_or_data As Byte(), ByVal mode As MODE, ByRef exinfo As CREATESOUNDEXINFO, ByRef sound As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_CreateDSP(ByVal system As IntPtr, ByRef description As DSP_DESCRIPTION, ByRef dsp As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_CreateDSPByType(ByVal system As IntPtr, ByVal type As DSP_TYPE, ByRef dsp As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_CreateChannelGroup(ByVal system As IntPtr, ByVal name As Byte(), ByRef channelgroup As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_CreateSoundGroup(ByVal system As IntPtr, ByVal name As Byte(), ByRef soundgroup As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_CreateReverb3D(ByVal system As IntPtr, ByRef reverb As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_PlaySound(ByVal system As IntPtr, ByVal sound As IntPtr, ByVal channelGroup As IntPtr, ByVal paused As Boolean, ByRef channel As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_PlayDSP(ByVal system As IntPtr, ByVal dsp As IntPtr, ByVal channelGroup As IntPtr, ByVal paused As Boolean, ByRef channel As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetChannel(ByVal system As IntPtr, ByVal channelid As Integer, ByRef channel As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetMasterChannelGroup(ByVal system As IntPtr, ByRef channelgroup As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetMasterSoundGroup(ByVal system As IntPtr, ByRef soundgroup As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_AttachChannelGroupToPort(ByVal system As IntPtr, ByVal portType As UInteger, ByVal portIndex As ULong, ByVal channelgroup As IntPtr, ByVal passThru As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_DetachChannelGroupFromPort(ByVal system As IntPtr, ByVal channelgroup As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetReverbProperties(ByVal system As IntPtr, ByVal instance As Integer, ByRef prop As REVERB_PROPERTIES) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetReverbProperties(ByVal system As IntPtr, ByVal instance As Integer, ByRef prop As REVERB_PROPERTIES) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_LockDSP(ByVal system As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_UnlockDSP(ByVal system As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetRecordNumDrivers(ByVal system As IntPtr, ByRef numdrivers As Integer, ByRef numconnected As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetRecordDriverInfo(ByVal system As IntPtr, ByVal id As Integer, ByVal name As IntPtr, ByVal namelen As Integer, ByRef guid As Guid, ByRef systemrate As Integer, _
   ByRef speakermode As SPEAKERMODE, ByRef speakermodechannels As Integer, ByRef state As DRIVER_STATE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetRecordPosition(ByVal system As IntPtr, ByVal id As Integer, ByRef position As UInteger) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_RecordStart(ByVal system As IntPtr, ByVal id As Integer, ByVal sound As IntPtr, ByVal [loop] As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_RecordStop(ByVal system As IntPtr, ByVal id As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_IsRecording(ByVal system As IntPtr, ByVal id As Integer, ByRef recording As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_CreateGeometry(ByVal system As IntPtr, ByVal maxpolygons As Integer, ByVal maxvertices As Integer, ByRef geometry As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetGeometrySettings(ByVal system As IntPtr, ByVal maxworldsize As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetGeometrySettings(ByVal system As IntPtr, ByRef maxworldsize As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_LoadGeometry(ByVal system As IntPtr, ByVal data As IntPtr, ByVal datasize As Integer, ByRef geometry As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetGeometryOcclusion(ByVal system As IntPtr, ByRef listener As VECTOR, ByRef source As VECTOR, ByRef direct As Single, ByRef reverb As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetNetworkProxy(ByVal system As IntPtr, ByVal proxy As Byte()) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetNetworkProxy(ByVal system As IntPtr, ByVal proxy As IntPtr, ByVal proxylen As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetNetworkTimeout(ByVal system As IntPtr, ByVal timeout As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetNetworkTimeout(ByVal system As IntPtr, ByRef timeout As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_SetUserData(ByVal system As IntPtr, ByVal userdata As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_System_GetUserData(ByVal system As IntPtr, ByRef userdata As IntPtr) As RESULT
        End Function
#End Region

#Region "wrapperinternal"

        Public Sub New(ByVal raw As IntPtr)
            MyBase.New(raw)
        End Sub

#End Region
    End Class


    '
    '        'Sound' API.
    '    

    Public Class Sound
        Inherits HandleBase
        Public Function release() As RESULT
            Dim result__1 As RESULT = FMOD_Sound_Release(rawPtr)
            If result__1 = RESULT.OK Then
                rawPtr = IntPtr.Zero
            End If
            Return result__1
        End Function
        Public Function getSystemObject(ByRef system As System) As RESULT
            system = Nothing

            Dim systemraw As IntPtr
            Dim result As RESULT = FMOD_Sound_GetSystemObject(rawPtr, systemraw)
            system = New System(systemraw)

            Return result
        End Function

        ' Standard sound manipulation functions.
        Public Function lock(ByVal offset As UInteger, ByVal length As UInteger, ByRef ptr1 As IntPtr, ByRef ptr2 As IntPtr, ByRef len1 As UInteger, ByRef len2 As UInteger) As RESULT
            Return FMOD_Sound_Lock(rawPtr, offset, length, ptr1, ptr2, len1, _
             len2)
        End Function
        Public Function unlock(ByVal ptr1 As IntPtr, ByVal ptr2 As IntPtr, ByVal len1 As UInteger, ByVal len2 As UInteger) As RESULT
            Return FMOD_Sound_Unlock(rawPtr, ptr1, ptr2, len1, len2)
        End Function
        Public Function setDefaults(ByVal frequency As Single, ByVal priority As Integer) As RESULT
            Return FMOD_Sound_SetDefaults(rawPtr, frequency, priority)
        End Function
        Public Function getDefaults(ByRef frequency As Single, ByRef priority As Integer) As RESULT
            Return FMOD_Sound_GetDefaults(rawPtr, frequency, priority)
        End Function
        Public Function set3DMinMaxDistance(ByVal min As Single, ByVal max As Single) As RESULT
            Return FMOD_Sound_Set3DMinMaxDistance(rawPtr, min, max)
        End Function
        Public Function get3DMinMaxDistance(ByRef min As Single, ByRef max As Single) As RESULT
            Return FMOD_Sound_Get3DMinMaxDistance(rawPtr, min, max)
        End Function
        Public Function set3DConeSettings(ByVal insideconeangle As Single, ByVal outsideconeangle As Single, ByVal outsidevolume As Single) As RESULT
            Return FMOD_Sound_Set3DConeSettings(rawPtr, insideconeangle, outsideconeangle, outsidevolume)
        End Function
        Public Function get3DConeSettings(ByRef insideconeangle As Single, ByRef outsideconeangle As Single, ByRef outsidevolume As Single) As RESULT
            Return FMOD_Sound_Get3DConeSettings(rawPtr, insideconeangle, outsideconeangle, outsidevolume)
        End Function
        Public Function set3DCustomRolloff(ByRef points As VECTOR, ByVal numpoints As Integer) As RESULT
            Return FMOD_Sound_Set3DCustomRolloff(rawPtr, points, numpoints)
        End Function
        Public Function get3DCustomRolloff(ByRef points As IntPtr, ByRef numpoints As Integer) As RESULT
            Return FMOD_Sound_Get3DCustomRolloff(rawPtr, points, numpoints)
        End Function
        Public Function getSubSound(ByVal index As Integer, ByRef subsound As Sound) As RESULT
            subsound = Nothing

            Dim subsoundraw As IntPtr
            Dim result As RESULT = FMOD_Sound_GetSubSound(rawPtr, index, subsoundraw)
            subsound = New Sound(subsoundraw)

            Return result
        End Function
        Public Function getSubSoundParent(ByRef parentsound As Sound) As RESULT
            parentsound = Nothing

            Dim subsoundraw As IntPtr
            Dim result As RESULT = FMOD_Sound_GetSubSoundParent(rawPtr, subsoundraw)
            parentsound = New Sound(subsoundraw)

            Return result
        End Function
        Public Function getName(ByVal name As StringBuilder, ByVal namelen As Integer) As RESULT
            Dim stringMem As IntPtr = Marshal.AllocHGlobal(name.Capacity)

            Dim result As RESULT = FMOD_Sound_GetName(rawPtr, stringMem, namelen)

            StringMarshalHelper.NativeToBuilder(name, stringMem)
            Marshal.FreeHGlobal(stringMem)

            Return result
        End Function
        Public Function getLength(ByRef length As UInteger, ByVal lengthtype As TIMEUNIT) As RESULT
            Return FMOD_Sound_GetLength(rawPtr, length, lengthtype)
        End Function
        Public Function getFormat(ByRef type As SOUND_TYPE, ByRef format As SOUND_FORMAT, ByRef channels As Integer, ByRef bits As Integer) As RESULT
            Return FMOD_Sound_GetFormat(rawPtr, type, format, channels, bits)
        End Function
        Public Function getNumSubSounds(ByRef numsubsounds As Integer) As RESULT
            Return FMOD_Sound_GetNumSubSounds(rawPtr, numsubsounds)
        End Function
        Public Function getNumTags(ByRef numtags As Integer, ByRef numtagsupdated As Integer) As RESULT
            Return FMOD_Sound_GetNumTags(rawPtr, numtags, numtagsupdated)
        End Function
        Public Function getTag(ByVal name As String, ByVal index As Integer, ByRef tag As TAG) As RESULT
            Return FMOD_Sound_GetTag(rawPtr, name, index, tag)
        End Function
        Public Function getOpenState(ByRef openstate As OPENSTATE, ByRef percentbuffered As UInteger, ByRef starving As Boolean, ByRef diskbusy As Boolean) As RESULT
            Return FMOD_Sound_GetOpenState(rawPtr, openstate, percentbuffered, starving, diskbusy)
        End Function
        Public Function readData(ByVal buffer As IntPtr, ByVal lenbytes As UInteger, ByRef read As UInteger) As RESULT
            Return FMOD_Sound_ReadData(rawPtr, buffer, lenbytes, read)
        End Function
        Public Function seekData(ByVal pcm As UInteger) As RESULT
            Return FMOD_Sound_SeekData(rawPtr, pcm)
        End Function
        Public Function setSoundGroup(ByVal soundgroup As SoundGroup) As RESULT
            Return FMOD_Sound_SetSoundGroup(rawPtr, soundgroup.getRaw())
        End Function
        Public Function getSoundGroup(ByRef soundgroup As SoundGroup) As RESULT
            soundgroup = Nothing

            Dim soundgroupraw As IntPtr
            Dim result As RESULT = FMOD_Sound_GetSoundGroup(rawPtr, soundgroupraw)
            soundgroup = New SoundGroup(soundgroupraw)

            Return result
        End Function

        ' Synchronization point API.  These points can come from markers embedded in wav files, and can also generate channel callbacks.
        Public Function getNumSyncPoints(ByRef numsyncpoints As Integer) As RESULT
            Return FMOD_Sound_GetNumSyncPoints(rawPtr, numsyncpoints)
        End Function
        Public Function getSyncPoint(ByVal index As Integer, ByRef point As IntPtr) As RESULT
            Return FMOD_Sound_GetSyncPoint(rawPtr, index, point)
        End Function
        Public Function getSyncPointInfo(ByVal point As IntPtr, ByVal name As StringBuilder, ByVal namelen As Integer, ByRef offset As UInteger, ByVal offsettype As TIMEUNIT) As RESULT
            Dim stringMem As IntPtr = Marshal.AllocHGlobal(name.Capacity)

            Dim result As RESULT = FMOD_Sound_GetSyncPointInfo(rawPtr, point, stringMem, namelen, offset, offsettype)

            StringMarshalHelper.NativeToBuilder(name, stringMem)
            Marshal.FreeHGlobal(stringMem)

            Return result
        End Function
        Public Function addSyncPoint(ByVal offset As UInteger, ByVal offsettype As TIMEUNIT, ByVal name As String, ByRef point As IntPtr) As RESULT
            Return FMOD_Sound_AddSyncPoint(rawPtr, offset, offsettype, name, point)
        End Function
        Public Function deleteSyncPoint(ByVal point As IntPtr) As RESULT
            Return FMOD_Sound_DeleteSyncPoint(rawPtr, point)
        End Function

        ' Functions also in Channel class but here they are the 'default' to save having to change it in Channel all the time.
        Public Function setMode(ByVal mode As MODE) As RESULT
            Return FMOD_Sound_SetMode(rawPtr, mode)
        End Function
        Public Function getMode(ByRef mode As MODE) As RESULT
            Return FMOD_Sound_GetMode(rawPtr, mode)
        End Function
        Public Function setLoopCount(ByVal loopcount As Integer) As RESULT
            Return FMOD_Sound_SetLoopCount(rawPtr, loopcount)
        End Function
        Public Function getLoopCount(ByRef loopcount As Integer) As RESULT
            Return FMOD_Sound_GetLoopCount(rawPtr, loopcount)
        End Function
        Public Function setLoopPoints(ByVal loopstart As UInteger, ByVal loopstarttype As TIMEUNIT, ByVal loopend As UInteger, ByVal loopendtype As TIMEUNIT) As RESULT
            Return FMOD_Sound_SetLoopPoints(rawPtr, loopstart, loopstarttype, loopend, loopendtype)
        End Function
        Public Function getLoopPoints(ByRef loopstart As UInteger, ByVal loopstarttype As TIMEUNIT, ByRef loopend As UInteger, ByVal loopendtype As TIMEUNIT) As RESULT
            Return FMOD_Sound_GetLoopPoints(rawPtr, loopstart, loopstarttype, loopend, loopendtype)
        End Function

        ' For MOD/S3M/XM/IT/MID sequenced formats only.
        Public Function getMusicNumChannels(ByRef numchannels As Integer) As RESULT
            Return FMOD_Sound_GetMusicNumChannels(rawPtr, numchannels)
        End Function
        Public Function setMusicChannelVolume(ByVal channel As Integer, ByVal volume As Single) As RESULT
            Return FMOD_Sound_SetMusicChannelVolume(rawPtr, channel, volume)
        End Function
        Public Function getMusicChannelVolume(ByVal channel As Integer, ByRef volume As Single) As RESULT
            Return FMOD_Sound_GetMusicChannelVolume(rawPtr, channel, volume)
        End Function
        Public Function setMusicSpeed(ByVal speed As Single) As RESULT
            Return FMOD_Sound_SetMusicSpeed(rawPtr, speed)
        End Function
        Public Function getMusicSpeed(ByRef speed As Single) As RESULT
            Return FMOD_Sound_GetMusicSpeed(rawPtr, speed)
        End Function

        ' Userdata set/get.
        Public Function setUserData(ByVal userdata As IntPtr) As RESULT
            Return FMOD_Sound_SetUserData(rawPtr, userdata)
        End Function
        Public Function getUserData(ByRef userdata As IntPtr) As RESULT
            Return FMOD_Sound_GetUserData(rawPtr, userdata)
        End Function


#Region "importfunctions"
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_Release(ByVal sound As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetSystemObject(ByVal sound As IntPtr, ByRef system As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_Lock(ByVal sound As IntPtr, ByVal offset As UInteger, ByVal length As UInteger, ByRef ptr1 As IntPtr, ByRef ptr2 As IntPtr, ByRef len1 As UInteger, _
   ByRef len2 As UInteger) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_Unlock(ByVal sound As IntPtr, ByVal ptr1 As IntPtr, ByVal ptr2 As IntPtr, ByVal len1 As UInteger, ByVal len2 As UInteger) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_SetDefaults(ByVal sound As IntPtr, ByVal frequency As Single, ByVal priority As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetDefaults(ByVal sound As IntPtr, ByRef frequency As Single, ByRef priority As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_Set3DMinMaxDistance(ByVal sound As IntPtr, ByVal min As Single, ByVal max As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_Get3DMinMaxDistance(ByVal sound As IntPtr, ByRef min As Single, ByRef max As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_Set3DConeSettings(ByVal sound As IntPtr, ByVal insideconeangle As Single, ByVal outsideconeangle As Single, ByVal outsidevolume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_Get3DConeSettings(ByVal sound As IntPtr, ByRef insideconeangle As Single, ByRef outsideconeangle As Single, ByRef outsidevolume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_Set3DCustomRolloff(ByVal sound As IntPtr, ByRef points As VECTOR, ByVal numpoints As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_Get3DCustomRolloff(ByVal sound As IntPtr, ByRef points As IntPtr, ByRef numpoints As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetSubSound(ByVal sound As IntPtr, ByVal index As Integer, ByRef subsound As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetSubSoundParent(ByVal sound As IntPtr, ByRef parentsound As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetName(ByVal sound As IntPtr, ByVal name As IntPtr, ByVal namelen As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetLength(ByVal sound As IntPtr, ByRef length As UInteger, ByVal lengthtype As TIMEUNIT) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetFormat(ByVal sound As IntPtr, ByRef type As SOUND_TYPE, ByRef format As SOUND_FORMAT, ByRef channels As Integer, ByRef bits As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetNumSubSounds(ByVal sound As IntPtr, ByRef numsubsounds As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetNumTags(ByVal sound As IntPtr, ByRef numtags As Integer, ByRef numtagsupdated As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetTag(ByVal sound As IntPtr, ByVal name As String, ByVal index As Integer, ByRef tag As TAG) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetOpenState(ByVal sound As IntPtr, ByRef openstate As OPENSTATE, ByRef percentbuffered As UInteger, ByRef starving As Boolean, ByRef diskbusy As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_ReadData(ByVal sound As IntPtr, ByVal buffer As IntPtr, ByVal lenbytes As UInteger, ByRef read As UInteger) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_SeekData(ByVal sound As IntPtr, ByVal pcm As UInteger) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_SetSoundGroup(ByVal sound As IntPtr, ByVal soundgroup As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetSoundGroup(ByVal sound As IntPtr, ByRef soundgroup As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetNumSyncPoints(ByVal sound As IntPtr, ByRef numsyncpoints As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetSyncPoint(ByVal sound As IntPtr, ByVal index As Integer, ByRef point As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetSyncPointInfo(ByVal sound As IntPtr, ByVal point As IntPtr, ByVal name As IntPtr, ByVal namelen As Integer, ByRef offset As UInteger, ByVal offsettype As TIMEUNIT) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_AddSyncPoint(ByVal sound As IntPtr, ByVal offset As UInteger, ByVal offsettype As TIMEUNIT, ByVal name As String, ByRef point As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_DeleteSyncPoint(ByVal sound As IntPtr, ByVal point As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_SetMode(ByVal sound As IntPtr, ByVal mode As MODE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetMode(ByVal sound As IntPtr, ByRef mode As MODE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_SetLoopCount(ByVal sound As IntPtr, ByVal loopcount As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetLoopCount(ByVal sound As IntPtr, ByRef loopcount As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_SetLoopPoints(ByVal sound As IntPtr, ByVal loopstart As UInteger, ByVal loopstarttype As TIMEUNIT, ByVal loopend As UInteger, ByVal loopendtype As TIMEUNIT) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetLoopPoints(ByVal sound As IntPtr, ByRef loopstart As UInteger, ByVal loopstarttype As TIMEUNIT, ByRef loopend As UInteger, ByVal loopendtype As TIMEUNIT) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetMusicNumChannels(ByVal sound As IntPtr, ByRef numchannels As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_SetMusicChannelVolume(ByVal sound As IntPtr, ByVal channel As Integer, ByVal volume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetMusicChannelVolume(ByVal sound As IntPtr, ByVal channel As Integer, ByRef volume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_SetMusicSpeed(ByVal sound As IntPtr, ByVal speed As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetMusicSpeed(ByVal sound As IntPtr, ByRef speed As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_SetUserData(ByVal sound As IntPtr, ByVal userdata As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Sound_GetUserData(ByVal sound As IntPtr, ByRef userdata As IntPtr) As RESULT
        End Function
#End Region

#Region "wrapperinternal"

        Public Sub New(ByVal raw As IntPtr)
            MyBase.New(raw)
        End Sub

#End Region
    End Class


    '
    '        'ChannelControl' API
    '    

    Public Class ChannelControl
        Inherits HandleBase
        Public Function getSystemObject(ByRef system As System) As RESULT
            system = Nothing

            Dim systemraw As IntPtr
            Dim result As RESULT = FMOD_ChannelGroup_GetSystemObject(rawPtr, systemraw)
            system = New System(systemraw)

            Return result
        End Function

        ' General control functionality for Channels and ChannelGroups.
        Public Function [stop]() As RESULT
            Return FMOD_ChannelGroup_Stop(rawPtr)
        End Function
        Public Function setPaused(ByVal paused As Boolean) As RESULT
            Return FMOD_ChannelGroup_SetPaused(rawPtr, paused)
        End Function
        Public Function getPaused(ByRef paused As Boolean) As RESULT
            Return FMOD_ChannelGroup_GetPaused(rawPtr, paused)
        End Function
        Public Function setVolume(ByVal volume As Single) As RESULT
            Return FMOD_ChannelGroup_SetVolume(rawPtr, volume)
        End Function
        Public Function getVolume(ByRef volume As Single) As RESULT
            Return FMOD_ChannelGroup_GetVolume(rawPtr, volume)
        End Function
        Public Function setVolumeRamp(ByVal ramp As Boolean) As RESULT
            Return FMOD_ChannelGroup_SetVolumeRamp(rawPtr, ramp)
        End Function
        Public Function getVolumeRamp(ByRef ramp As Boolean) As RESULT
            Return FMOD_ChannelGroup_GetVolumeRamp(rawPtr, ramp)
        End Function
        Public Function getAudibility(ByRef audibility As Single) As RESULT
            Return FMOD_ChannelGroup_GetAudibility(rawPtr, audibility)
        End Function
        Public Function setPitch(ByVal pitch As Single) As RESULT
            Return FMOD_ChannelGroup_SetPitch(rawPtr, pitch)
        End Function
        Public Function getPitch(ByRef pitch As Single) As RESULT
            Return FMOD_ChannelGroup_GetPitch(rawPtr, pitch)
        End Function
        Public Function setMute(ByVal mute As Boolean) As RESULT
            Return FMOD_ChannelGroup_SetMute(rawPtr, mute)
        End Function
        Public Function getMute(ByRef mute As Boolean) As RESULT
            Return FMOD_ChannelGroup_GetMute(rawPtr, mute)
        End Function
        Public Function setReverbProperties(ByVal instance As Integer, ByVal wet As Single) As RESULT
            Return FMOD_ChannelGroup_SetReverbProperties(rawPtr, instance, wet)
        End Function
        Public Function getReverbProperties(ByVal instance As Integer, ByRef wet As Single) As RESULT
            Return FMOD_ChannelGroup_GetReverbProperties(rawPtr, instance, wet)
        End Function
        Public Function setLowPassGain(ByVal gain As Single) As RESULT
            Return FMOD_ChannelGroup_SetLowPassGain(rawPtr, gain)
        End Function
        Public Function getLowPassGain(ByRef gain As Single) As RESULT
            Return FMOD_ChannelGroup_GetLowPassGain(rawPtr, gain)
        End Function
        Public Function setMode(ByVal mode As MODE) As RESULT
            Return FMOD_ChannelGroup_SetMode(rawPtr, mode)
        End Function
        Public Function getMode(ByRef mode As MODE) As RESULT
            Return FMOD_ChannelGroup_GetMode(rawPtr, mode)
        End Function
        Public Function setCallback(ByVal callback As CHANNEL_CALLBACK) As RESULT
            Return FMOD_ChannelGroup_SetCallback(rawPtr, callback)
        End Function
        Public Function isPlaying(ByRef isplaying__1 As Boolean) As RESULT
            Return FMOD_ChannelGroup_IsPlaying(rawPtr, isplaying__1)
        End Function

        ' Panning and level adjustment.
        Public Function setPan(ByVal pan As Single) As RESULT
            Return FMOD_ChannelGroup_SetPan(rawPtr, pan)
        End Function
        Public Function setMixLevelsOutput(ByVal frontleft As Single, ByVal frontright As Single, ByVal center As Single, ByVal lfe As Single, ByVal surroundleft As Single, ByVal surroundright As Single, _
         ByVal backleft As Single, ByVal backright As Single) As RESULT
            Return FMOD_ChannelGroup_SetMixLevelsOutput(rawPtr, frontleft, frontright, center, lfe, surroundleft, _
             surroundright, backleft, backright)
        End Function
        Public Function setMixLevelsInput(ByVal levels As Single(), ByVal numlevels As Integer) As RESULT
            Return FMOD_ChannelGroup_SetMixLevelsInput(rawPtr, levels, numlevels)
        End Function
        Public Function setMixMatrix(ByVal matrix As Single(), ByVal outchannels As Integer, ByVal inchannels As Integer, ByVal inchannel_hop As Integer) As RESULT
            Return FMOD_ChannelGroup_SetMixMatrix(rawPtr, matrix, outchannels, inchannels, inchannel_hop)
        End Function
        Public Function getMixMatrix(ByVal matrix As Single(), ByRef outchannels As Integer, ByRef inchannels As Integer, ByVal inchannel_hop As Integer) As RESULT
            Return FMOD_ChannelGroup_GetMixMatrix(rawPtr, matrix, outchannels, inchannels, inchannel_hop)
        End Function

        ' Clock based functionality.
        Public Function getDSPClock(ByRef dspclock As ULong, ByRef parentclock As ULong) As RESULT
            Return FMOD_ChannelGroup_GetDSPClock(rawPtr, dspclock, parentclock)
        End Function
        Public Function setDelay(ByVal dspclock_start As ULong, ByVal dspclock_end As ULong, ByVal stopchannels As Boolean) As RESULT
            Return FMOD_ChannelGroup_SetDelay(rawPtr, dspclock_start, dspclock_end, stopchannels)
        End Function
        Public Function getDelay(ByRef dspclock_start As ULong, ByRef dspclock_end As ULong, ByRef stopchannels As Boolean) As RESULT
            Return FMOD_ChannelGroup_GetDelay(rawPtr, dspclock_start, dspclock_end, stopchannels)
        End Function
        Public Function addFadePoint(ByVal dspclock As ULong, ByVal volume As Single) As RESULT
            Return FMOD_ChannelGroup_AddFadePoint(rawPtr, dspclock, volume)
        End Function
        Public Function setFadePointRamp(ByVal dspclock As ULong, ByVal volume As Single) As RESULT
            Return FMOD_ChannelGroup_SetFadePointRamp(rawPtr, dspclock, volume)
        End Function
        Public Function removeFadePoints(ByVal dspclock_start As ULong, ByVal dspclock_end As ULong) As RESULT
            Return FMOD_ChannelGroup_RemoveFadePoints(rawPtr, dspclock_start, dspclock_end)
        End Function
        Public Function getFadePoints(ByRef numpoints As UInteger, ByVal point_dspclock As ULong(), ByVal point_volume As Single()) As RESULT
            Return FMOD_ChannelGroup_GetFadePoints(rawPtr, numpoints, point_dspclock, point_volume)
        End Function

        ' DSP effects.
        Public Function getDSP(ByVal index As Integer, ByRef dsp As DSP) As RESULT
            dsp = Nothing

            Dim dspraw As IntPtr
            Dim result As RESULT = FMOD_ChannelGroup_GetDSP(rawPtr, index, dspraw)
            dsp = New DSP(dspraw)

            Return result
        End Function
        Public Function addDSP(ByVal index As Integer, ByVal dsp As DSP) As RESULT
            Return FMOD_ChannelGroup_AddDSP(rawPtr, index, dsp.getRaw())
        End Function
        Public Function removeDSP(ByVal dsp As DSP) As RESULT
            Return FMOD_ChannelGroup_RemoveDSP(rawPtr, dsp.getRaw())
        End Function
        Public Function getNumDSPs(ByRef numdsps As Integer) As RESULT
            Return FMOD_ChannelGroup_GetNumDSPs(rawPtr, numdsps)
        End Function
        Public Function setDSPIndex(ByVal dsp As DSP, ByVal index As Integer) As RESULT
            Return FMOD_ChannelGroup_SetDSPIndex(rawPtr, dsp.getRaw(), index)
        End Function
        Public Function getDSPIndex(ByVal dsp As DSP, ByRef index As Integer) As RESULT
            Return FMOD_ChannelGroup_GetDSPIndex(rawPtr, dsp.getRaw(), index)
        End Function
        Public Function overridePanDSP(ByVal pan As DSP) As RESULT
            Return FMOD_ChannelGroup_OverridePanDSP(rawPtr, pan.getRaw())
        End Function

        ' 3D functionality.
        Public Function set3DAttributes(ByRef pos As VECTOR, ByRef vel As VECTOR, ByRef alt_pan_pos As VECTOR) As RESULT
            Return FMOD_ChannelGroup_Set3DAttributes(rawPtr, pos, vel, alt_pan_pos)
        End Function
        Public Function get3DAttributes(ByRef pos As VECTOR, ByRef vel As VECTOR, ByRef alt_pan_pos As VECTOR) As RESULT
            Return FMOD_ChannelGroup_Get3DAttributes(rawPtr, pos, vel, alt_pan_pos)
        End Function
        Public Function set3DMinMaxDistance(ByVal mindistance As Single, ByVal maxdistance As Single) As RESULT
            Return FMOD_ChannelGroup_Set3DMinMaxDistance(rawPtr, mindistance, maxdistance)
        End Function
        Public Function get3DMinMaxDistance(ByRef mindistance As Single, ByRef maxdistance As Single) As RESULT
            Return FMOD_ChannelGroup_Get3DMinMaxDistance(rawPtr, mindistance, maxdistance)
        End Function
        Public Function set3DConeSettings(ByVal insideconeangle As Single, ByVal outsideconeangle As Single, ByVal outsidevolume As Single) As RESULT
            Return FMOD_ChannelGroup_Set3DConeSettings(rawPtr, insideconeangle, outsideconeangle, outsidevolume)
        End Function
        Public Function get3DConeSettings(ByRef insideconeangle As Single, ByRef outsideconeangle As Single, ByRef outsidevolume As Single) As RESULT
            Return FMOD_ChannelGroup_Get3DConeSettings(rawPtr, insideconeangle, outsideconeangle, outsidevolume)
        End Function
        Public Function set3DConeOrientation(ByRef orientation As VECTOR) As RESULT
            Return FMOD_ChannelGroup_Set3DConeOrientation(rawPtr, orientation)
        End Function
        Public Function get3DConeOrientation(ByRef orientation As VECTOR) As RESULT
            Return FMOD_ChannelGroup_Get3DConeOrientation(rawPtr, orientation)
        End Function
        Public Function set3DCustomRolloff(ByRef points As VECTOR, ByVal numpoints As Integer) As RESULT
            Return FMOD_ChannelGroup_Set3DCustomRolloff(rawPtr, points, numpoints)
        End Function
        Public Function get3DCustomRolloff(ByRef points As IntPtr, ByRef numpoints As Integer) As RESULT
            Return FMOD_ChannelGroup_Get3DCustomRolloff(rawPtr, points, numpoints)
        End Function
        Public Function set3DOcclusion(ByVal directocclusion As Single, ByVal reverbocclusion As Single) As RESULT
            Return FMOD_ChannelGroup_Set3DOcclusion(rawPtr, directocclusion, reverbocclusion)
        End Function
        Public Function get3DOcclusion(ByRef directocclusion As Single, ByRef reverbocclusion As Single) As RESULT
            Return FMOD_ChannelGroup_Get3DOcclusion(rawPtr, directocclusion, reverbocclusion)
        End Function
        Public Function set3DSpread(ByVal angle As Single) As RESULT
            Return FMOD_ChannelGroup_Set3DSpread(rawPtr, angle)
        End Function
        Public Function get3DSpread(ByRef angle As Single) As RESULT
            Return FMOD_ChannelGroup_Get3DSpread(rawPtr, angle)
        End Function
        Public Function set3DLevel(ByVal level As Single) As RESULT
            Return FMOD_ChannelGroup_Set3DLevel(rawPtr, level)
        End Function
        Public Function get3DLevel(ByRef level As Single) As RESULT
            Return FMOD_ChannelGroup_Get3DLevel(rawPtr, level)
        End Function
        Public Function set3DDopplerLevel(ByVal level As Single) As RESULT
            Return FMOD_ChannelGroup_Set3DDopplerLevel(rawPtr, level)
        End Function
        Public Function get3DDopplerLevel(ByRef level As Single) As RESULT
            Return FMOD_ChannelGroup_Get3DDopplerLevel(rawPtr, level)
        End Function
        Public Function set3DDistanceFilter(ByVal [custom] As Boolean, ByVal customLevel As Single, ByVal centerFreq As Single) As RESULT
            Return FMOD_ChannelGroup_Set3DDistanceFilter(rawPtr, [custom], customLevel, centerFreq)
        End Function
        Public Function get3DDistanceFilter(ByRef [custom] As Boolean, ByRef customLevel As Single, ByRef centerFreq As Single) As RESULT
            Return FMOD_ChannelGroup_Get3DDistanceFilter(rawPtr, [custom], customLevel, centerFreq)
        End Function

        ' Userdata set/get.
        Public Function setUserData(ByVal userdata As IntPtr) As RESULT
            Return FMOD_ChannelGroup_SetUserData(rawPtr, userdata)
        End Function
        Public Function getUserData(ByRef userdata As IntPtr) As RESULT
            Return FMOD_ChannelGroup_GetUserData(rawPtr, userdata)
        End Function

#Region "importfunctions"

        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Stop(ByVal channelgroup As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetPaused(ByVal channelgroup As IntPtr, ByVal paused As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetPaused(ByVal channelgroup As IntPtr, ByRef paused As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetVolume(ByVal channelgroup As IntPtr, ByRef volume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetVolumeRamp(ByVal channelgroup As IntPtr, ByVal ramp As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetVolumeRamp(ByVal channelgroup As IntPtr, ByRef ramp As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetAudibility(ByVal channelgroup As IntPtr, ByRef audibility As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetPitch(ByVal channelgroup As IntPtr, ByVal pitch As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetPitch(ByVal channelgroup As IntPtr, ByRef pitch As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetMute(ByVal channelgroup As IntPtr, ByVal mute As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetMute(ByVal channelgroup As IntPtr, ByRef mute As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetReverbProperties(ByVal channelgroup As IntPtr, ByVal instance As Integer, ByVal wet As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetReverbProperties(ByVal channelgroup As IntPtr, ByVal instance As Integer, ByRef wet As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetLowPassGain(ByVal channelgroup As IntPtr, ByVal gain As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetLowPassGain(ByVal channelgroup As IntPtr, ByRef gain As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetMode(ByVal channelgroup As IntPtr, ByVal mode As MODE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetMode(ByVal channelgroup As IntPtr, ByRef mode As MODE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetCallback(ByVal channelgroup As IntPtr, ByVal callback As CHANNEL_CALLBACK) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_IsPlaying(ByVal channelgroup As IntPtr, ByRef isplaying As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetPan(ByVal channelgroup As IntPtr, ByVal pan As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetMixLevelsOutput(ByVal channelgroup As IntPtr, ByVal frontleft As Single, ByVal frontright As Single, ByVal center As Single, ByVal lfe As Single, ByVal surroundleft As Single, _
   ByVal surroundright As Single, ByVal backleft As Single, ByVal backright As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetMixLevelsInput(ByVal channelgroup As IntPtr, ByVal levels As Single(), ByVal numlevels As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetMixMatrix(ByVal channelgroup As IntPtr, ByVal matrix As Single(), ByVal outchannels As Integer, ByVal inchannels As Integer, ByVal inchannel_hop As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetMixMatrix(ByVal channelgroup As IntPtr, ByVal matrix As Single(), ByRef outchannels As Integer, ByRef inchannels As Integer, ByVal inchannel_hop As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetDSPClock(ByVal channelgroup As IntPtr, ByRef dspclock As ULong, ByRef parentclock As ULong) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetDelay(ByVal channelgroup As IntPtr, ByVal dspclock_start As ULong, ByVal dspclock_end As ULong, ByVal stopchannels As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetDelay(ByVal channelgroup As IntPtr, ByRef dspclock_start As ULong, ByRef dspclock_end As ULong, ByRef stopchannels As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_AddFadePoint(ByVal channelgroup As IntPtr, ByVal dspclock As ULong, ByVal volume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetFadePointRamp(ByVal channelgroup As IntPtr, ByVal dspclock As ULong, ByVal volume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_RemoveFadePoints(ByVal channelgroup As IntPtr, ByVal dspclock_start As ULong, ByVal dspclock_end As ULong) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetFadePoints(ByVal channelgroup As IntPtr, ByRef numpoints As UInteger, ByVal point_dspclock As ULong(), ByVal point_volume As Single()) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Set3DAttributes(ByVal channelgroup As IntPtr, ByRef pos As VECTOR, ByRef vel As VECTOR, ByRef alt_pan_pos As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Get3DAttributes(ByVal channelgroup As IntPtr, ByRef pos As VECTOR, ByRef vel As VECTOR, ByRef alt_pan_pos As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Set3DMinMaxDistance(ByVal channelgroup As IntPtr, ByVal mindistance As Single, ByVal maxdistance As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Get3DMinMaxDistance(ByVal channelgroup As IntPtr, ByRef mindistance As Single, ByRef maxdistance As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Set3DConeSettings(ByVal channelgroup As IntPtr, ByVal insideconeangle As Single, ByVal outsideconeangle As Single, ByVal outsidevolume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Get3DConeSettings(ByVal channelgroup As IntPtr, ByRef insideconeangle As Single, ByRef outsideconeangle As Single, ByRef outsidevolume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Set3DConeOrientation(ByVal channelgroup As IntPtr, ByRef orientation As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Get3DConeOrientation(ByVal channelgroup As IntPtr, ByRef orientation As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Set3DCustomRolloff(ByVal channelgroup As IntPtr, ByRef points As VECTOR, ByVal numpoints As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Get3DCustomRolloff(ByVal channelgroup As IntPtr, ByRef points As IntPtr, ByRef numpoints As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Set3DOcclusion(ByVal channelgroup As IntPtr, ByVal directocclusion As Single, ByVal reverbocclusion As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Get3DOcclusion(ByVal channelgroup As IntPtr, ByRef directocclusion As Single, ByRef reverbocclusion As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Set3DSpread(ByVal channelgroup As IntPtr, ByVal angle As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Get3DSpread(ByVal channelgroup As IntPtr, ByRef angle As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Set3DLevel(ByVal channelgroup As IntPtr, ByVal level As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Get3DLevel(ByVal channelgroup As IntPtr, ByRef level As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Set3DDopplerLevel(ByVal channelgroup As IntPtr, ByVal level As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Get3DDopplerLevel(ByVal channelgroup As IntPtr, ByRef level As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Set3DDistanceFilter(ByVal channelgroup As IntPtr, ByVal [custom] As Boolean, ByVal customLevel As Single, ByVal centerFreq As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Get3DDistanceFilter(ByVal channelgroup As IntPtr, ByRef [custom] As Boolean, ByRef customLevel As Single, ByRef centerFreq As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetSystemObject(ByVal channelgroup As IntPtr, ByRef system As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetVolume(ByVal channelgroup As IntPtr, ByVal volume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetDSP(ByVal channelgroup As IntPtr, ByVal index As Integer, ByRef dsp As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_AddDSP(ByVal channelgroup As IntPtr, ByVal index As Integer, ByVal dsp As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_RemoveDSP(ByVal channelgroup As IntPtr, ByVal dsp As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetNumDSPs(ByVal channelgroup As IntPtr, ByRef numdsps As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetDSPIndex(ByVal channelgroup As IntPtr, ByVal dsp As IntPtr, ByVal index As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetDSPIndex(ByVal channelgroup As IntPtr, ByVal dsp As IntPtr, ByRef index As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_OverridePanDSP(ByVal channelgroup As IntPtr, ByVal pan As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_SetUserData(ByVal channelgroup As IntPtr, ByVal userdata As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetUserData(ByVal channelgroup As IntPtr, ByRef userdata As IntPtr) As RESULT
        End Function

#End Region

#Region "wrapperinternal"

        Protected Sub New(ByVal raw As IntPtr)
            MyBase.New(raw)
        End Sub

#End Region
    End Class


    '
    '        'Channel' API
    '    

    Public Class Channel
        Inherits ChannelControl
        ' Channel specific control functionality.
        Public Function setFrequency(ByVal frequency As Single) As RESULT
            Return FMOD_Channel_SetFrequency(getRaw(), frequency)
        End Function
        Public Function getFrequency(ByRef frequency As Single) As RESULT
            Return FMOD_Channel_GetFrequency(getRaw(), frequency)
        End Function
        Public Function setPriority(ByVal priority As Integer) As RESULT
            Return FMOD_Channel_SetPriority(getRaw(), priority)
        End Function
        Public Function getPriority(ByRef priority As Integer) As RESULT
            Return FMOD_Channel_GetPriority(getRaw(), priority)
        End Function
        Public Function setPosition(ByVal position As UInteger, ByVal postype As TIMEUNIT) As RESULT
            Return FMOD_Channel_SetPosition(getRaw(), position, postype)
        End Function
        Public Function getPosition(ByRef position As UInteger, ByVal postype As TIMEUNIT) As RESULT
            Return FMOD_Channel_GetPosition(getRaw(), position, postype)
        End Function
        Public Function setChannelGroup(ByVal channelgroup As ChannelGroup) As RESULT
            Return FMOD_Channel_SetChannelGroup(getRaw(), channelgroup.getRaw())
        End Function
        Public Function getChannelGroup(ByRef channelgroup As ChannelGroup) As RESULT
            channelgroup = Nothing

            Dim channelgroupraw As IntPtr
            Dim result As RESULT = FMOD_Channel_GetChannelGroup(getRaw(), channelgroupraw)
            channelgroup = New ChannelGroup(channelgroupraw)

            Return result
        End Function
        Public Function setLoopCount(ByVal loopcount As Integer) As RESULT
            Return FMOD_Channel_SetLoopCount(getRaw(), loopcount)
        End Function
        Public Function getLoopCount(ByRef loopcount As Integer) As RESULT
            Return FMOD_Channel_GetLoopCount(getRaw(), loopcount)
        End Function
        Public Function setLoopPoints(ByVal loopstart As UInteger, ByVal loopstarttype As TIMEUNIT, ByVal loopend As UInteger, ByVal loopendtype As TIMEUNIT) As RESULT
            Return FMOD_Channel_SetLoopPoints(getRaw(), loopstart, loopstarttype, loopend, loopendtype)
        End Function
        Public Function getLoopPoints(ByRef loopstart As UInteger, ByVal loopstarttype As TIMEUNIT, ByRef loopend As UInteger, ByVal loopendtype As TIMEUNIT) As RESULT
            Return FMOD_Channel_GetLoopPoints(getRaw(), loopstart, loopstarttype, loopend, loopendtype)
        End Function

        ' Information only functions.
        Public Function isVirtual(ByRef isvirtual__1 As Boolean) As RESULT
            Return FMOD_Channel_IsVirtual(getRaw(), isvirtual__1)
        End Function
        Public Function getCurrentSound(ByRef sound As Sound) As RESULT
            sound = Nothing

            Dim soundraw As IntPtr
            Dim result As RESULT = FMOD_Channel_GetCurrentSound(getRaw(), soundraw)
            sound = New Sound(soundraw)

            Return result
        End Function
        Public Function getIndex(ByRef index As Integer) As RESULT
            Return FMOD_Channel_GetIndex(getRaw(), index)
        End Function

#Region "importfunctions"

        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_SetFrequency(ByVal channel As IntPtr, ByVal frequency As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_GetFrequency(ByVal channel As IntPtr, ByRef frequency As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_SetPriority(ByVal channel As IntPtr, ByVal priority As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_GetPriority(ByVal channel As IntPtr, ByRef priority As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_SetChannelGroup(ByVal channel As IntPtr, ByVal channelgroup As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_GetChannelGroup(ByVal channel As IntPtr, ByRef channelgroup As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_IsVirtual(ByVal channel As IntPtr, ByRef isvirtual As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_GetCurrentSound(ByVal channel As IntPtr, ByRef sound As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_GetIndex(ByVal channel As IntPtr, ByRef index As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_SetPosition(ByVal channel As IntPtr, ByVal position As UInteger, ByVal postype As TIMEUNIT) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_GetPosition(ByVal channel As IntPtr, ByRef position As UInteger, ByVal postype As TIMEUNIT) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_SetMode(ByVal channel As IntPtr, ByVal mode As MODE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_GetMode(ByVal channel As IntPtr, ByRef mode As MODE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_SetLoopCount(ByVal channel As IntPtr, ByVal loopcount As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_GetLoopCount(ByVal channel As IntPtr, ByRef loopcount As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_SetLoopPoints(ByVal channel As IntPtr, ByVal loopstart As UInteger, ByVal loopstarttype As TIMEUNIT, ByVal loopend As UInteger, ByVal loopendtype As TIMEUNIT) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_GetLoopPoints(ByVal channel As IntPtr, ByRef loopstart As UInteger, ByVal loopstarttype As TIMEUNIT, ByRef loopend As UInteger, ByVal loopendtype As TIMEUNIT) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_SetUserData(ByVal channel As IntPtr, ByVal userdata As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Channel_GetUserData(ByVal channel As IntPtr, ByRef userdata As IntPtr) As RESULT
        End Function
#End Region

#Region "wrapperinternal"

        Public Sub New(ByVal raw As IntPtr)
            MyBase.New(raw)
        End Sub

#End Region
    End Class


    '
    '        'ChannelGroup' API
    '    

    Public Class ChannelGroup
        Inherits ChannelControl
        Public Function release() As RESULT
            Dim result__1 As RESULT = FMOD_ChannelGroup_Release(getRaw())
            If result__1 = RESULT.OK Then
                rawPtr = IntPtr.Zero
            End If
            Return result__1
        End Function

        ' Nested channel groups.
        Public Function addGroup(ByVal group As ChannelGroup) As RESULT
            Return FMOD_ChannelGroup_AddGroup(getRaw(), group.getRaw())
        End Function
        Public Function getNumGroups(ByRef numgroups As Integer) As RESULT
            Return FMOD_ChannelGroup_GetNumGroups(getRaw(), numgroups)
        End Function
        Public Function getGroup(ByVal index As Integer, ByRef group As ChannelGroup) As RESULT
            group = Nothing

            Dim groupraw As IntPtr
            Dim result As RESULT = FMOD_ChannelGroup_GetGroup(getRaw(), index, groupraw)
            group = New ChannelGroup(groupraw)

            Return result
        End Function
        Public Function getParentGroup(ByRef group As ChannelGroup) As RESULT
            group = Nothing

            Dim groupraw As IntPtr
            Dim result As RESULT = FMOD_ChannelGroup_GetParentGroup(getRaw(), groupraw)
            group = New ChannelGroup(groupraw)

            Return result
        End Function

        ' Information only functions.
        Public Function getName(ByVal name As StringBuilder, ByVal namelen As Integer) As RESULT
            Dim stringMem As IntPtr = Marshal.AllocHGlobal(name.Capacity)

            Dim result As RESULT = FMOD_ChannelGroup_GetName(getRaw(), stringMem, namelen)

            StringMarshalHelper.NativeToBuilder(name, stringMem)
            Marshal.FreeHGlobal(stringMem)

            Return result
        End Function
        Public Function getNumChannels(ByRef numchannels As Integer) As RESULT
            Return FMOD_ChannelGroup_GetNumChannels(getRaw(), numchannels)
        End Function
        Public Function getChannel(ByVal index As Integer, ByRef channel As Channel) As RESULT
            channel = Nothing

            Dim channelraw As IntPtr
            Dim result As RESULT = FMOD_ChannelGroup_GetChannel(getRaw(), index, channelraw)
            channel = New Channel(channelraw)

            Return result
        End Function

#Region "importfunctions"
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_Release(ByVal channelgroup As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_AddGroup(ByVal channelgroup As IntPtr, ByVal group As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetNumGroups(ByVal channelgroup As IntPtr, ByRef numgroups As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetGroup(ByVal channelgroup As IntPtr, ByVal index As Integer, ByRef group As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetParentGroup(ByVal channelgroup As IntPtr, ByRef group As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetName(ByVal channelgroup As IntPtr, ByVal name As IntPtr, ByVal namelen As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetNumChannels(ByVal channelgroup As IntPtr, ByRef numchannels As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_ChannelGroup_GetChannel(ByVal channelgroup As IntPtr, ByVal index As Integer, ByRef channel As IntPtr) As RESULT
        End Function
#End Region

#Region "wrapperinternal"

        Public Sub New(ByVal raw As IntPtr)
            MyBase.New(raw)
        End Sub

#End Region
    End Class


    '
    '        'SoundGroup' API
    '    

    Public Class SoundGroup
        Inherits HandleBase
        Public Function release() As RESULT
            Dim result__1 As RESULT = FMOD_SoundGroup_Release(getRaw())
            If result__1 = RESULT.OK Then
                rawPtr = IntPtr.Zero
            End If
            Return result__1
        End Function

        Public Function getSystemObject(ByRef system As System) As RESULT
            system = Nothing

            Dim systemraw As IntPtr
            Dim result As RESULT = FMOD_SoundGroup_GetSystemObject(rawPtr, systemraw)
            system = New System(systemraw)

            Return result
        End Function

        ' SoundGroup control functions.
        Public Function setMaxAudible(ByVal maxaudible As Integer) As RESULT
            Return FMOD_SoundGroup_SetMaxAudible(rawPtr, maxaudible)
        End Function
        Public Function getMaxAudible(ByRef maxaudible As Integer) As RESULT
            Return FMOD_SoundGroup_GetMaxAudible(rawPtr, maxaudible)
        End Function
        Public Function setMaxAudibleBehavior(ByVal behavior As SOUNDGROUP_BEHAVIOR) As RESULT
            Return FMOD_SoundGroup_SetMaxAudibleBehavior(rawPtr, behavior)
        End Function
        Public Function getMaxAudibleBehavior(ByRef behavior As SOUNDGROUP_BEHAVIOR) As RESULT
            Return FMOD_SoundGroup_GetMaxAudibleBehavior(rawPtr, behavior)
        End Function
        Public Function setMuteFadeSpeed(ByVal speed As Single) As RESULT
            Return FMOD_SoundGroup_SetMuteFadeSpeed(rawPtr, speed)
        End Function
        Public Function getMuteFadeSpeed(ByRef speed As Single) As RESULT
            Return FMOD_SoundGroup_GetMuteFadeSpeed(rawPtr, speed)
        End Function
        Public Function setVolume(ByVal volume As Single) As RESULT
            Return FMOD_SoundGroup_SetVolume(rawPtr, volume)
        End Function
        Public Function getVolume(ByRef volume As Single) As RESULT
            Return FMOD_SoundGroup_GetVolume(rawPtr, volume)
        End Function
        Public Function [stop]() As RESULT
            Return FMOD_SoundGroup_Stop(rawPtr)
        End Function

        ' Information only functions.
        Public Function getName(ByVal name As StringBuilder, ByVal namelen As Integer) As RESULT
            Dim stringMem As IntPtr = Marshal.AllocHGlobal(name.Capacity)

            Dim result As RESULT = FMOD_SoundGroup_GetName(rawPtr, stringMem, namelen)

            StringMarshalHelper.NativeToBuilder(name, stringMem)
            Marshal.FreeHGlobal(stringMem)

            Return result
        End Function
        Public Function getNumSounds(ByRef numsounds As Integer) As RESULT
            Return FMOD_SoundGroup_GetNumSounds(rawPtr, numsounds)
        End Function
        Public Function getSound(ByVal index As Integer, ByRef sound As Sound) As RESULT
            sound = Nothing

            Dim soundraw As IntPtr
            Dim result As RESULT = FMOD_SoundGroup_GetSound(rawPtr, index, soundraw)
            sound = New Sound(soundraw)

            Return result
        End Function
        Public Function getNumPlaying(ByRef numplaying As Integer) As RESULT
            Return FMOD_SoundGroup_GetNumPlaying(rawPtr, numplaying)
        End Function

        ' Userdata set/get.
        Public Function setUserData(ByVal userdata As IntPtr) As RESULT
            Return FMOD_SoundGroup_SetUserData(rawPtr, userdata)
        End Function
        Public Function getUserData(ByRef userdata As IntPtr) As RESULT
            Return FMOD_SoundGroup_GetUserData(rawPtr, userdata)
        End Function

#Region "importfunctions"
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_Release(ByVal soundgroup As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_GetSystemObject(ByVal soundgroup As IntPtr, ByRef system As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_SetMaxAudible(ByVal soundgroup As IntPtr, ByVal maxaudible As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_GetMaxAudible(ByVal soundgroup As IntPtr, ByRef maxaudible As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_SetMaxAudibleBehavior(ByVal soundgroup As IntPtr, ByVal behavior As SOUNDGROUP_BEHAVIOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_GetMaxAudibleBehavior(ByVal soundgroup As IntPtr, ByRef behavior As SOUNDGROUP_BEHAVIOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_SetMuteFadeSpeed(ByVal soundgroup As IntPtr, ByVal speed As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_GetMuteFadeSpeed(ByVal soundgroup As IntPtr, ByRef speed As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_SetVolume(ByVal soundgroup As IntPtr, ByVal volume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_GetVolume(ByVal soundgroup As IntPtr, ByRef volume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_Stop(ByVal soundgroup As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_GetName(ByVal soundgroup As IntPtr, ByVal name As IntPtr, ByVal namelen As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_GetNumSounds(ByVal soundgroup As IntPtr, ByRef numsounds As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_GetSound(ByVal soundgroup As IntPtr, ByVal index As Integer, ByRef sound As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_GetNumPlaying(ByVal soundgroup As IntPtr, ByRef numplaying As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_SetUserData(ByVal soundgroup As IntPtr, ByVal userdata As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_SoundGroup_GetUserData(ByVal soundgroup As IntPtr, ByRef userdata As IntPtr) As RESULT
        End Function
#End Region

#Region "wrapperinternal"

        Public Sub New(ByVal raw As IntPtr)
            MyBase.New(raw)
        End Sub

#End Region
    End Class


    '
    '        'DSP' API
    '    

    Public Class DSP
        Inherits HandleBase
        Public Function release() As RESULT
            Dim result__1 As RESULT = FMOD_DSP_Release(getRaw())
            If result__1 = RESULT.OK Then
                rawPtr = IntPtr.Zero
            End If
            Return result__1
        End Function
        Public Function getSystemObject(ByRef system As System) As RESULT
            system = Nothing

            Dim systemraw As IntPtr
            Dim result As RESULT = FMOD_DSP_GetSystemObject(rawPtr, systemraw)
            system = New System(systemraw)

            Return result
        End Function

        ' Connection / disconnection / input and output enumeration.
        Public Function addInput(ByVal target As DSP, ByRef connection As DSPConnection, ByVal type As DSPCONNECTION_TYPE) As RESULT
            connection = Nothing

            Dim dspconnectionraw As IntPtr
            Dim result As RESULT = FMOD_DSP_AddInput(rawPtr, target.getRaw(), dspconnectionraw, type)
            connection = New DSPConnection(dspconnectionraw)

            Return result
        End Function
        Public Function disconnectFrom(ByVal target As DSP, ByVal connection As DSPConnection) As RESULT
            Return FMOD_DSP_DisconnectFrom(rawPtr, target.getRaw(), connection.getRaw())
        End Function
        Public Function disconnectAll(ByVal inputs As Boolean, ByVal outputs As Boolean) As RESULT
            Return FMOD_DSP_DisconnectAll(rawPtr, inputs, outputs)
        End Function
        Public Function getNumInputs(ByRef numinputs As Integer) As RESULT
            Return FMOD_DSP_GetNumInputs(rawPtr, numinputs)
        End Function
        Public Function getNumOutputs(ByRef numoutputs As Integer) As RESULT
            Return FMOD_DSP_GetNumOutputs(rawPtr, numoutputs)
        End Function
        Public Function getInput(ByVal index As Integer, ByRef input As DSP, ByRef inputconnection As DSPConnection) As RESULT
            input = Nothing
            inputconnection = Nothing

            Dim dspinputraw As IntPtr
            Dim dspconnectionraw As IntPtr
            Dim result As RESULT = FMOD_DSP_GetInput(rawPtr, index, dspinputraw, dspconnectionraw)
            input = New DSP(dspinputraw)
            inputconnection = New DSPConnection(dspconnectionraw)

            Return result
        End Function
        Public Function getOutput(ByVal index As Integer, ByRef output As DSP, ByRef outputconnection As DSPConnection) As RESULT
            output = Nothing
            outputconnection = Nothing

            Dim dspoutputraw As IntPtr
            Dim dspconnectionraw As IntPtr
            Dim result As RESULT = FMOD_DSP_GetOutput(rawPtr, index, dspoutputraw, dspconnectionraw)
            output = New DSP(dspoutputraw)
            outputconnection = New DSPConnection(dspconnectionraw)

            Return result
        End Function

        ' DSP unit control.
        Public Function setActive(ByVal active As Boolean) As RESULT
            Return FMOD_DSP_SetActive(rawPtr, active)
        End Function
        Public Function getActive(ByRef active As Boolean) As RESULT
            Return FMOD_DSP_GetActive(rawPtr, active)
        End Function
        Public Function setBypass(ByVal bypass As Boolean) As RESULT
            Return FMOD_DSP_SetBypass(rawPtr, bypass)
        End Function
        Public Function getBypass(ByRef bypass As Boolean) As RESULT
            Return FMOD_DSP_GetBypass(rawPtr, bypass)
        End Function
        Public Function setWetDryMix(ByVal prewet As Single, ByVal postwet As Single, ByVal dry As Single) As RESULT
            Return FMOD_DSP_SetWetDryMix(rawPtr, prewet, postwet, dry)
        End Function
        Public Function getWetDryMix(ByRef prewet As Single, ByRef postwet As Single, ByRef dry As Single) As RESULT
            Return FMOD_DSP_GetWetDryMix(rawPtr, prewet, postwet, dry)
        End Function
        Public Function setChannelFormat(ByVal channelmask As CHANNELMASK, ByVal numchannels As Integer, ByVal source_speakermode As SPEAKERMODE) As RESULT
            Return FMOD_DSP_SetChannelFormat(rawPtr, channelmask, numchannels, source_speakermode)
        End Function
        Public Function getChannelFormat(ByRef channelmask As CHANNELMASK, ByRef numchannels As Integer, ByRef source_speakermode As SPEAKERMODE) As RESULT
            Return FMOD_DSP_GetChannelFormat(rawPtr, channelmask, numchannels, source_speakermode)
        End Function
        Public Function getOutputChannelFormat(ByVal inmask As CHANNELMASK, ByVal inchannels As Integer, ByVal inspeakermode As SPEAKERMODE, ByRef outmask As CHANNELMASK, ByRef outchannels As Integer, ByRef outspeakermode As SPEAKERMODE) As RESULT
            Return FMOD_DSP_GetOutputChannelFormat(rawPtr, inmask, inchannels, inspeakermode, outmask, outchannels, _
             outspeakermode)
        End Function
        Public Function reset() As RESULT
            Return FMOD_DSP_Reset(rawPtr)
        End Function

        ' DSP parameter control.
        Public Function setParameterFloat(ByVal index As Integer, ByVal value As Single) As RESULT
            Return FMOD_DSP_SetParameterFloat(rawPtr, index, value)
        End Function
        Public Function setParameterInt(ByVal index As Integer, ByVal value As Integer) As RESULT
            Return FMOD_DSP_SetParameterInt(rawPtr, index, value)
        End Function
        Public Function setParameterBool(ByVal index As Integer, ByVal value As Boolean) As RESULT
            Return FMOD_DSP_SetParameterBool(rawPtr, index, value)
        End Function
        Public Function setParameterData(ByVal index As Integer, ByVal data As Byte()) As RESULT
            Return FMOD_DSP_SetParameterData(rawPtr, index, Marshal.UnsafeAddrOfPinnedArrayElement(data, 0), CUInt(data.Length))
        End Function
        Public Function getParameterFloat(ByVal index As Integer, ByRef value As Single) As RESULT
            Dim valuestr As IntPtr = IntPtr.Zero
            Return FMOD_DSP_GetParameterFloat(rawPtr, index, value, valuestr, 0)
        End Function
        Public Function getParameterInt(ByVal index As Integer, ByRef value As Integer) As RESULT
            Dim valuestr As IntPtr = IntPtr.Zero
            Return FMOD_DSP_GetParameterInt(rawPtr, index, value, valuestr, 0)
        End Function
        Public Function getParameterBool(ByVal index As Integer, ByRef value As Boolean) As RESULT
            Return FMOD_DSP_GetParameterBool(rawPtr, index, value, IntPtr.Zero, 0)
        End Function
        Public Function getParameterData(ByVal index As Integer, ByRef data As IntPtr, ByRef length As UInteger) As RESULT
            Return FMOD_DSP_GetParameterData(rawPtr, index, data, length, IntPtr.Zero, 0)
        End Function
        Public Function getNumParameters(ByRef numparams As Integer) As RESULT
            Return FMOD_DSP_GetNumParameters(rawPtr, numparams)
        End Function
        Public Function getParameterInfo(ByVal index As Integer, ByRef desc As DSP_PARAMETER_DESC) As RESULT
            Dim descPtr As IntPtr
            Dim result__1 As RESULT = FMOD_DSP_GetParameterInfo(rawPtr, index, descPtr)
            If result__1 = RESULT.OK Then
                desc = DirectCast(Marshal.PtrToStructure(descPtr, GetType(DSP_PARAMETER_DESC)), DSP_PARAMETER_DESC)
            Else
                desc = New DSP_PARAMETER_DESC()
            End If
            Return result__1
        End Function
        Public Function getDataParameterIndex(ByVal datatype As Integer, ByRef index As Integer) As RESULT
            Return FMOD_DSP_GetDataParameterIndex(rawPtr, datatype, index)
        End Function
        Public Function showConfigDialog(ByVal hwnd As IntPtr, ByVal show As Boolean) As RESULT
            Return FMOD_DSP_ShowConfigDialog(rawPtr, hwnd, show)
        End Function

        '  DSP attributes.
        Public Function getInfo(ByVal name As StringBuilder, ByRef version As UInteger, ByRef channels As Integer, ByRef configwidth As Integer, ByRef configheight As Integer) As RESULT
            Dim nameMem As IntPtr = Marshal.AllocHGlobal(32)
            Dim result As RESULT = FMOD_DSP_GetInfo(rawPtr, nameMem, version, channels, configwidth, configheight)
            StringMarshalHelper.NativeToBuilder(name, nameMem)
            Marshal.FreeHGlobal(nameMem)
            Return result
        End Function
        Public Function [getType](ByRef type As DSP_TYPE) As RESULT
            Return FMOD_DSP_GetType(rawPtr, type)
        End Function
        Public Function getIdle(ByRef idle As Boolean) As RESULT
            Return FMOD_DSP_GetIdle(rawPtr, idle)
        End Function

        ' Userdata set/get.
        Public Function setUserData(ByVal userdata As IntPtr) As RESULT
            Return FMOD_DSP_SetUserData(rawPtr, userdata)
        End Function
        Public Function getUserData(ByRef userdata As IntPtr) As RESULT
            Return FMOD_DSP_GetUserData(rawPtr, userdata)
        End Function

        ' Metering.
        Public Function setMeteringEnabled(ByVal inputEnabled As Boolean, ByVal outputEnabled As Boolean) As RESULT
            Return FMOD_DSP_SetMeteringEnabled(rawPtr, inputEnabled, outputEnabled)
        End Function
        Public Function getMeteringEnabled(ByRef inputEnabled As Boolean, ByRef outputEnabled As Boolean) As RESULT
            Return FMOD_DSP_GetMeteringEnabled(rawPtr, inputEnabled, outputEnabled)
        End Function

        Public Function getMeteringInfo(ByVal inputInfo As DSP_METERING_INFO, ByVal outputInfo As DSP_METERING_INFO) As RESULT
            Return FMOD_DSP_GetMeteringInfo(rawPtr, inputInfo, outputInfo)
        End Function

#Region "importfunctions"

        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_Release(ByVal dsp As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetSystemObject(ByVal dsp As IntPtr, ByRef system As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_AddInput(ByVal dsp As IntPtr, ByVal target As IntPtr, ByRef connection As IntPtr, ByVal type As DSPCONNECTION_TYPE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_DisconnectFrom(ByVal dsp As IntPtr, ByVal target As IntPtr, ByVal connection As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_DisconnectAll(ByVal dsp As IntPtr, ByVal inputs As Boolean, ByVal outputs As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetNumInputs(ByVal dsp As IntPtr, ByRef numinputs As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetNumOutputs(ByVal dsp As IntPtr, ByRef numoutputs As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetInput(ByVal dsp As IntPtr, ByVal index As Integer, ByRef input As IntPtr, ByRef inputconnection As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetOutput(ByVal dsp As IntPtr, ByVal index As Integer, ByRef output As IntPtr, ByRef outputconnection As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_SetActive(ByVal dsp As IntPtr, ByVal active As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetActive(ByVal dsp As IntPtr, ByRef active As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_SetBypass(ByVal dsp As IntPtr, ByVal bypass As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetBypass(ByVal dsp As IntPtr, ByRef bypass As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_SetWetDryMix(ByVal dsp As IntPtr, ByVal prewet As Single, ByVal postwet As Single, ByVal dry As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetWetDryMix(ByVal dsp As IntPtr, ByRef prewet As Single, ByRef postwet As Single, ByRef dry As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_SetChannelFormat(ByVal dsp As IntPtr, ByVal channelmask As CHANNELMASK, ByVal numchannels As Integer, ByVal source_speakermode As SPEAKERMODE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetChannelFormat(ByVal dsp As IntPtr, ByRef channelmask As CHANNELMASK, ByRef numchannels As Integer, ByRef source_speakermode As SPEAKERMODE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetOutputChannelFormat(ByVal dsp As IntPtr, ByVal inmask As CHANNELMASK, ByVal inchannels As Integer, ByVal inspeakermode As SPEAKERMODE, ByRef outmask As CHANNELMASK, ByRef outchannels As Integer, _
   ByRef outspeakermode As SPEAKERMODE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_Reset(ByVal dsp As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_SetParameterFloat(ByVal dsp As IntPtr, ByVal index As Integer, ByVal value As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_SetParameterInt(ByVal dsp As IntPtr, ByVal index As Integer, ByVal value As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_SetParameterBool(ByVal dsp As IntPtr, ByVal index As Integer, ByVal value As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_SetParameterData(ByVal dsp As IntPtr, ByVal index As Integer, ByVal data As IntPtr, ByVal length As UInteger) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetParameterFloat(ByVal dsp As IntPtr, ByVal index As Integer, ByRef value As Single, ByVal valuestr As IntPtr, ByVal valuestrlen As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetParameterInt(ByVal dsp As IntPtr, ByVal index As Integer, ByRef value As Integer, ByVal valuestr As IntPtr, ByVal valuestrlen As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetParameterBool(ByVal dsp As IntPtr, ByVal index As Integer, ByRef value As Boolean, ByVal valuestr As IntPtr, ByVal valuestrlen As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetParameterData(ByVal dsp As IntPtr, ByVal index As Integer, ByRef data As IntPtr, ByRef length As UInteger, ByVal valuestr As IntPtr, ByVal valuestrlen As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetNumParameters(ByVal dsp As IntPtr, ByRef numparams As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetParameterInfo(ByVal dsp As IntPtr, ByVal index As Integer, ByRef desc As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetDataParameterIndex(ByVal dsp As IntPtr, ByVal datatype As Integer, ByRef index As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_ShowConfigDialog(ByVal dsp As IntPtr, ByVal hwnd As IntPtr, ByVal show As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetInfo(ByVal dsp As IntPtr, ByVal name As IntPtr, ByRef version__1 As UInteger, ByRef channels As Integer, ByRef configwidth As Integer, ByRef configheight As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetType(ByVal dsp As IntPtr, ByRef type As DSP_TYPE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetIdle(ByVal dsp As IntPtr, ByRef idle As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_SetUserData(ByVal dsp As IntPtr, ByVal userdata As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSP_GetUserData(ByVal dsp As IntPtr, ByRef userdata As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Public Shared Function FMOD_DSP_SetMeteringEnabled(ByVal dsp As IntPtr, ByVal inputEnabled As Boolean, ByVal outputEnabled As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Public Shared Function FMOD_DSP_GetMeteringEnabled(ByVal dsp As IntPtr, ByRef inputEnabled As Boolean, ByRef outputEnabled As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Public Shared Function FMOD_DSP_GetMeteringInfo(ByVal dsp As IntPtr, <Out()> ByVal inputInfo As DSP_METERING_INFO, <Out()> ByVal outputInfo As DSP_METERING_INFO) As RESULT
        End Function
#End Region

#Region "wrapperinternal"

        Public Sub New(ByVal raw As IntPtr)
            MyBase.New(raw)
        End Sub

#End Region
    End Class


    '
    '        'DSPConnection' API
    '    

    Public Class DSPConnection
        Inherits HandleBase
        Public Function getInput(ByRef input As DSP) As RESULT
            input = Nothing

            Dim dspraw As IntPtr
            Dim result As RESULT = FMOD_DSPConnection_GetInput(rawPtr, dspraw)
            input = New DSP(dspraw)

            Return result
        End Function
        Public Function getOutput(ByRef output As DSP) As RESULT
            output = Nothing

            Dim dspraw As IntPtr
            Dim result As RESULT = FMOD_DSPConnection_GetOutput(rawPtr, dspraw)
            output = New DSP(dspraw)

            Return result
        End Function
        Public Function setMix(ByVal volume As Single) As RESULT
            Return FMOD_DSPConnection_SetMix(rawPtr, volume)
        End Function
        Public Function getMix(ByRef volume As Single) As RESULT
            Return FMOD_DSPConnection_GetMix(rawPtr, volume)
        End Function
        Public Function setMixMatrix(ByVal matrix As Single(), ByVal outchannels As Integer, ByVal inchannels As Integer, ByVal inchannel_hop As Integer) As RESULT
            Return FMOD_DSPConnection_SetMixMatrix(rawPtr, matrix, outchannels, inchannels, inchannel_hop)
        End Function
        Public Function getMixMatrix(ByVal matrix As Single(), ByRef outchannels As Integer, ByRef inchannels As Integer, ByVal inchannel_hop As Integer) As RESULT
            Return FMOD_DSPConnection_GetMixMatrix(rawPtr, matrix, outchannels, inchannels, inchannel_hop)
        End Function
        Public Function [getType](ByRef type As DSPCONNECTION_TYPE) As RESULT
            Return FMOD_DSPConnection_GetType(rawPtr, type)
        End Function

        ' Userdata set/get.
        Public Function setUserData(ByVal userdata As IntPtr) As RESULT
            Return FMOD_DSPConnection_SetUserData(rawPtr, userdata)
        End Function
        Public Function getUserData(ByRef userdata As IntPtr) As RESULT
            Return FMOD_DSPConnection_GetUserData(rawPtr, userdata)
        End Function

#Region "importfunctions"
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSPConnection_GetInput(ByVal dspconnection As IntPtr, ByRef input As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSPConnection_GetOutput(ByVal dspconnection As IntPtr, ByRef output As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSPConnection_SetMix(ByVal dspconnection As IntPtr, ByVal volume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSPConnection_GetMix(ByVal dspconnection As IntPtr, ByRef volume As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSPConnection_SetMixMatrix(ByVal dspconnection As IntPtr, ByVal matrix As Single(), ByVal outchannels As Integer, ByVal inchannels As Integer, ByVal inchannel_hop As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSPConnection_GetMixMatrix(ByVal dspconnection As IntPtr, ByVal matrix As Single(), ByRef outchannels As Integer, ByRef inchannels As Integer, ByVal inchannel_hop As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSPConnection_GetType(ByVal dspconnection As IntPtr, ByRef type As DSPCONNECTION_TYPE) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSPConnection_SetUserData(ByVal dspconnection As IntPtr, ByVal userdata As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_DSPConnection_GetUserData(ByVal dspconnection As IntPtr, ByRef userdata As IntPtr) As RESULT
        End Function
#End Region

#Region "wrapperinternal"

        Public Sub New(ByVal raw As IntPtr)
            MyBase.New(raw)
        End Sub

#End Region
    End Class

    '
    '        'Geometry' API
    '    

    Public Class Geometry
        Inherits HandleBase
        Public Function release() As RESULT
            Dim result__1 As RESULT = FMOD_Geometry_Release(getRaw())
            If result__1 = RESULT.OK Then
                rawPtr = IntPtr.Zero
            End If
            Return result__1
        End Function

        ' Polygon manipulation.
        Public Function addPolygon(ByVal directocclusion As Single, ByVal reverbocclusion As Single, ByVal doublesided As Boolean, ByVal numvertices As Integer, ByVal vertices As VECTOR(), ByRef polygonindex As Integer) As RESULT
            Return FMOD_Geometry_AddPolygon(rawPtr, directocclusion, reverbocclusion, doublesided, numvertices, vertices, _
             polygonindex)
        End Function
        Public Function getNumPolygons(ByRef numpolygons As Integer) As RESULT
            Return FMOD_Geometry_GetNumPolygons(rawPtr, numpolygons)
        End Function
        Public Function getMaxPolygons(ByRef maxpolygons As Integer, ByRef maxvertices As Integer) As RESULT
            Return FMOD_Geometry_GetMaxPolygons(rawPtr, maxpolygons, maxvertices)
        End Function
        Public Function getPolygonNumVertices(ByVal index As Integer, ByRef numvertices As Integer) As RESULT
            Return FMOD_Geometry_GetPolygonNumVertices(rawPtr, index, numvertices)
        End Function
        Public Function setPolygonVertex(ByVal index As Integer, ByVal vertexindex As Integer, ByRef vertex As VECTOR) As RESULT
            Return FMOD_Geometry_SetPolygonVertex(rawPtr, index, vertexindex, vertex)
        End Function
        Public Function getPolygonVertex(ByVal index As Integer, ByVal vertexindex As Integer, ByRef vertex As VECTOR) As RESULT
            Return FMOD_Geometry_GetPolygonVertex(rawPtr, index, vertexindex, vertex)
        End Function
        Public Function setPolygonAttributes(ByVal index As Integer, ByVal directocclusion As Single, ByVal reverbocclusion As Single, ByVal doublesided As Boolean) As RESULT
            Return FMOD_Geometry_SetPolygonAttributes(rawPtr, index, directocclusion, reverbocclusion, doublesided)
        End Function
        Public Function getPolygonAttributes(ByVal index As Integer, ByRef directocclusion As Single, ByRef reverbocclusion As Single, ByRef doublesided As Boolean) As RESULT
            Return FMOD_Geometry_GetPolygonAttributes(rawPtr, index, directocclusion, reverbocclusion, doublesided)
        End Function

        ' Object manipulation.
        Public Function setActive(ByVal active As Boolean) As RESULT
            Return FMOD_Geometry_SetActive(rawPtr, active)
        End Function
        Public Function getActive(ByRef active As Boolean) As RESULT
            Return FMOD_Geometry_GetActive(rawPtr, active)
        End Function
        Public Function setRotation(ByRef forward As VECTOR, ByRef up As VECTOR) As RESULT
            Return FMOD_Geometry_SetRotation(rawPtr, forward, up)
        End Function
        Public Function getRotation(ByRef forward As VECTOR, ByRef up As VECTOR) As RESULT
            Return FMOD_Geometry_GetRotation(rawPtr, forward, up)
        End Function
        Public Function setPosition(ByRef position As VECTOR) As RESULT
            Return FMOD_Geometry_SetPosition(rawPtr, position)
        End Function
        Public Function getPosition(ByRef position As VECTOR) As RESULT
            Return FMOD_Geometry_GetPosition(rawPtr, position)
        End Function
        Public Function setScale(ByRef scale As VECTOR) As RESULT
            Return FMOD_Geometry_SetScale(rawPtr, scale)
        End Function
        Public Function getScale(ByRef scale As VECTOR) As RESULT
            Return FMOD_Geometry_GetScale(rawPtr, scale)
        End Function
        Public Function save(ByVal data As IntPtr, ByRef datasize As Integer) As RESULT
            Return FMOD_Geometry_Save(rawPtr, data, datasize)
        End Function

        ' Userdata set/get.
        Public Function setUserData(ByVal userdata As IntPtr) As RESULT
            Return FMOD_Geometry_SetUserData(rawPtr, userdata)
        End Function
        Public Function getUserData(ByRef userdata As IntPtr) As RESULT
            Return FMOD_Geometry_GetUserData(rawPtr, userdata)
        End Function

#Region "importfunctions"
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_Release(ByVal geometry As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_AddPolygon(ByVal geometry As IntPtr, ByVal directocclusion As Single, ByVal reverbocclusion As Single, ByVal doublesided As Boolean, ByVal numvertices As Integer, ByVal vertices As VECTOR(), _
   ByRef polygonindex As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_GetNumPolygons(ByVal geometry As IntPtr, ByRef numpolygons As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_GetMaxPolygons(ByVal geometry As IntPtr, ByRef maxpolygons As Integer, ByRef maxvertices As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_GetPolygonNumVertices(ByVal geometry As IntPtr, ByVal index As Integer, ByRef numvertices As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_SetPolygonVertex(ByVal geometry As IntPtr, ByVal index As Integer, ByVal vertexindex As Integer, ByRef vertex As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_GetPolygonVertex(ByVal geometry As IntPtr, ByVal index As Integer, ByVal vertexindex As Integer, ByRef vertex As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_SetPolygonAttributes(ByVal geometry As IntPtr, ByVal index As Integer, ByVal directocclusion As Single, ByVal reverbocclusion As Single, ByVal doublesided As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_GetPolygonAttributes(ByVal geometry As IntPtr, ByVal index As Integer, ByRef directocclusion As Single, ByRef reverbocclusion As Single, ByRef doublesided As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_SetActive(ByVal geometry As IntPtr, ByVal active As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_GetActive(ByVal geometry As IntPtr, ByRef active As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_SetRotation(ByVal geometry As IntPtr, ByRef forward As VECTOR, ByRef up As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_GetRotation(ByVal geometry As IntPtr, ByRef forward As VECTOR, ByRef up As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_SetPosition(ByVal geometry As IntPtr, ByRef position As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_GetPosition(ByVal geometry As IntPtr, ByRef position As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_SetScale(ByVal geometry As IntPtr, ByRef scale As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_GetScale(ByVal geometry As IntPtr, ByRef scale As VECTOR) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_Save(ByVal geometry As IntPtr, ByVal data As IntPtr, ByRef datasize As Integer) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_SetUserData(ByVal geometry As IntPtr, ByVal userdata As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Geometry_GetUserData(ByVal geometry As IntPtr, ByRef userdata As IntPtr) As RESULT
        End Function
#End Region

#Region "wrapperinternal"

        Public Sub New(ByVal raw As IntPtr)
            MyBase.New(raw)
        End Sub

#End Region
    End Class


    '
    '        'Reverb3D' API
    '    

    Public Class Reverb3D
        Inherits HandleBase
        Public Function release() As RESULT
            Dim result__1 As RESULT = FMOD_Reverb3D_Release(getRaw())
            If result__1 = RESULT.OK Then
                rawPtr = IntPtr.Zero
            End If
            Return result__1
        End Function

        ' Reverb manipulation.
        Public Function set3DAttributes(ByRef position As VECTOR, ByVal mindistance As Single, ByVal maxdistance As Single) As RESULT
            Return FMOD_Reverb3D_Set3DAttributes(rawPtr, position, mindistance, maxdistance)
        End Function
        Public Function get3DAttributes(ByRef position As VECTOR, ByRef mindistance As Single, ByRef maxdistance As Single) As RESULT
            Return FMOD_Reverb3D_Get3DAttributes(rawPtr, position, mindistance, maxdistance)
        End Function
        Public Function setProperties(ByRef properties As REVERB_PROPERTIES) As RESULT
            Return FMOD_Reverb3D_SetProperties(rawPtr, properties)
        End Function
        Public Function getProperties(ByRef properties As REVERB_PROPERTIES) As RESULT
            Return FMOD_Reverb3D_GetProperties(rawPtr, properties)
        End Function
        Public Function setActive(ByVal active As Boolean) As RESULT
            Return FMOD_Reverb3D_SetActive(rawPtr, active)
        End Function
        Public Function getActive(ByRef active As Boolean) As RESULT
            Return FMOD_Reverb3D_GetActive(rawPtr, active)
        End Function

        ' Userdata set/get.
        Public Function setUserData(ByVal userdata As IntPtr) As RESULT
            Return FMOD_Reverb3D_SetUserData(rawPtr, userdata)
        End Function
        Public Function getUserData(ByRef userdata As IntPtr) As RESULT
            Return FMOD_Reverb3D_GetUserData(rawPtr, userdata)
        End Function

#Region "importfunctions"
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Reverb3D_Release(ByVal reverb As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Reverb3D_Set3DAttributes(ByVal reverb As IntPtr, ByRef position As VECTOR, ByVal mindistance As Single, ByVal maxdistance As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Reverb3D_Get3DAttributes(ByVal reverb As IntPtr, ByRef position As VECTOR, ByRef mindistance As Single, ByRef maxdistance As Single) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Reverb3D_SetProperties(ByVal reverb As IntPtr, ByRef properties As REVERB_PROPERTIES) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Reverb3D_GetProperties(ByVal reverb As IntPtr, ByRef properties As REVERB_PROPERTIES) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Reverb3D_SetActive(ByVal reverb As IntPtr, ByVal active As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Reverb3D_GetActive(ByVal reverb As IntPtr, ByRef active As Boolean) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Reverb3D_SetUserData(ByVal reverb As IntPtr, ByVal userdata As IntPtr) As RESULT
        End Function
        <DllImport(VERSION.dll)> _
        Private Shared Function FMOD_Reverb3D_GetUserData(ByVal reverb As IntPtr, ByRef userdata As IntPtr) As RESULT
        End Function
#End Region

#Region "wrapperinternal"

        Public Sub New(ByVal raw As IntPtr)
            MyBase.New(raw)
        End Sub

#End Region
    End Class

    Class StringMarshalHelper
        Friend Shared Sub NativeToBuilder(ByVal builder As StringBuilder, ByVal nativeMem As IntPtr)
            Dim bytes As Byte() = New Byte(builder.Capacity - 1) {}
            Marshal.Copy(nativeMem, bytes, 0, builder.Capacity)
            Dim strlen As Integer = Array.IndexOf(bytes, CByte(0))
            If strlen > 0 Then
                Dim str As [String] = Encoding.UTF8.GetString(bytes, 0, strlen)
                builder.Append(str)
            End If
        End Sub
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================