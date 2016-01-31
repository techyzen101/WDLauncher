
' =================================================================================================== 

' FMOD Studio - Error string header file. Copyright (c), Firelight Technologies Pty, Ltd. 2004-2016.  

'                                                                                                     

' Use this header if you want to store or display a string version / english explanation of           

' the FMOD error codes.                                                                               

'                                                                                                     

' =================================================================================================== 


Namespace FMOD
    Public Class [Error]
        Public Shared Function [String](ByVal errcode As FMOD.RESULT) As String
            Select Case errcode
                Case FMOD.RESULT.OK
                    Return "No errors."
                Case FMOD.RESULT.ERR_BADCOMMAND
                    Return "Tried to call a function on a data type that does not allow this type of functionality (ie calling Sound::lock on a streaming sound)."
                Case FMOD.RESULT.ERR_CHANNEL_ALLOC
                    Return "Error trying to allocate a channel."
                Case FMOD.RESULT.ERR_CHANNEL_STOLEN
                    Return "The specified channel has been reused to play another sound."
                Case FMOD.RESULT.ERR_DMA
                    Return "DMA Failure.  See debug output for more information."
                Case FMOD.RESULT.ERR_DSP_CONNECTION
                    Return "DSP connection error.  Connection possibly caused a cyclic dependency or connected dsps with incompatible buffer counts."
                Case FMOD.RESULT.ERR_DSP_DONTPROCESS
                    Return "DSP return code from a DSP process query callback.  Tells mixer not to call the process callback and therefore not consume CPU.  Use this to optimize the DSP graph."
                Case FMOD.RESULT.ERR_DSP_FORMAT
                    Return "DSP Format error.  A DSP unit may have attempted to connect to this network with the wrong format, or a matrix may have been set with the wrong size if the target unit has a specified channel map."
                Case FMOD.RESULT.ERR_DSP_INUSE
                    Return "DSP is already in the mixer's DSP network. It must be removed before being reinserted or released."
                Case FMOD.RESULT.ERR_DSP_NOTFOUND
                    Return "DSP connection error.  Couldn't find the DSP unit specified."
                Case FMOD.RESULT.ERR_DSP_RESERVED
                    Return "DSP operation error.  Cannot perform operation on this DSP as it is reserved by the system."
                Case FMOD.RESULT.ERR_DSP_SILENCE
                    Return "DSP return code from a DSP process query callback.  Tells mixer silence would be produced from read, so go idle and not consume CPU.  Use this to optimize the DSP graph."
                Case FMOD.RESULT.ERR_DSP_TYPE
                    Return "DSP operation cannot be performed on a DSP of this type."
                Case FMOD.RESULT.ERR_FILE_BAD
                    Return "Error loading file."
                Case FMOD.RESULT.ERR_FILE_COULDNOTSEEK
                    Return "Couldn't perform seek operation.  This is a limitation of the medium (ie netstreams) or the file format."
                Case FMOD.RESULT.ERR_FILE_DISKEJECTED
                    Return "Media was ejected while reading."
                Case FMOD.RESULT.ERR_FILE_EOF
                    Return "End of file unexpectedly reached while trying to read essential data (truncated?)."
                Case FMOD.RESULT.ERR_FILE_ENDOFDATA
                    Return "End of current chunk reached while trying to read data."
                Case FMOD.RESULT.ERR_FILE_NOTFOUND
                    Return "File not found."
                Case FMOD.RESULT.ERR_FORMAT
                    Return "Unsupported file or audio format."
                Case FMOD.RESULT.ERR_HEADER_MISMATCH
                    Return "There is a version mismatch between the FMOD header and either the FMOD Studio library or the FMOD Low Level library."
                Case FMOD.RESULT.ERR_HTTP
                    Return "A HTTP error occurred. This is a catch-all for HTTP errors not listed elsewhere."
                Case FMOD.RESULT.ERR_HTTP_ACCESS
                    Return "The specified resource requires authentication or is forbidden."
                Case FMOD.RESULT.ERR_HTTP_PROXY_AUTH
                    Return "Proxy authentication is required to access the specified resource."
                Case FMOD.RESULT.ERR_HTTP_SERVER_ERROR
                    Return "A HTTP server error occurred."
                Case FMOD.RESULT.ERR_HTTP_TIMEOUT
                    Return "The HTTP request timed out."
                Case FMOD.RESULT.ERR_INITIALIZATION
                    Return "FMOD was not initialized correctly to support this function."
                Case FMOD.RESULT.ERR_INITIALIZED
                    Return "Cannot call this command after System::init."
                Case FMOD.RESULT.ERR_INTERNAL
                    Return "An error occurred that wasn't supposed to.  Contact support."
                Case FMOD.RESULT.ERR_INVALID_FLOAT
                    Return "Value passed in was a NaN, Inf or denormalized float."
                Case FMOD.RESULT.ERR_INVALID_HANDLE
                    Return "An invalid object handle was used."
                Case FMOD.RESULT.ERR_INVALID_PARAM
                    Return "An invalid parameter was passed to this function."
                Case FMOD.RESULT.ERR_INVALID_POSITION
                    Return "An invalid seek position was passed to this function."
                Case FMOD.RESULT.ERR_INVALID_SPEAKER
                    Return "An invalid speaker was passed to this function based on the current speaker mode."
                Case FMOD.RESULT.ERR_INVALID_SYNCPOINT
                    Return "The syncpoint did not come from this sound handle."
                Case FMOD.RESULT.ERR_INVALID_THREAD
                    Return "Tried to call a function on a thread that is not supported."
                Case FMOD.RESULT.ERR_INVALID_VECTOR
                    Return "The vectors passed in are not unit length, or perpendicular."
                Case FMOD.RESULT.ERR_MAXAUDIBLE
                    Return "Reached maximum audible playback count for this sound's soundgroup."
                Case FMOD.RESULT.ERR_MEMORY
                    Return "Not enough memory or resources."
                Case FMOD.RESULT.ERR_MEMORY_CANTPOINT
                    Return "Can't use FMOD_OPENMEMORY_POINT on non PCM source data, or non mp3/xma/adpcm data if FMOD_CREATECOMPRESSEDSAMPLE was used."
                Case FMOD.RESULT.ERR_NEEDS3D
                    Return "Tried to call a command on a 2d sound when the command was meant for 3d sound."
                Case FMOD.RESULT.ERR_NEEDSHARDWARE
                    Return "Tried to use a feature that requires hardware support."
                Case FMOD.RESULT.ERR_NET_CONNECT
                    Return "Couldn't connect to the specified host."
                Case FMOD.RESULT.ERR_NET_SOCKET_ERROR
                    Return "A socket error occurred.  This is a catch-all for socket-related errors not listed elsewhere."
                Case FMOD.RESULT.ERR_NET_URL
                    Return "The specified URL couldn't be resolved."
                Case FMOD.RESULT.ERR_NET_WOULD_BLOCK
                    Return "Operation on a non-blocking socket could not complete immediately."
                Case FMOD.RESULT.ERR_NOTREADY
                    Return "Operation could not be performed because specified sound/DSP connection is not ready."
                Case FMOD.RESULT.ERR_OUTPUT_ALLOCATED
                    Return "Error initializing output device, but more specifically, the output device is already in use and cannot be reused."
                Case FMOD.RESULT.ERR_OUTPUT_CREATEBUFFER
                    Return "Error creating hardware sound buffer."
                Case FMOD.RESULT.ERR_OUTPUT_DRIVERCALL
                    Return "A call to a standard soundcard driver failed, which could possibly mean a bug in the driver or resources were missing or exhausted."
                Case FMOD.RESULT.ERR_OUTPUT_FORMAT
                    Return "Soundcard does not support the specified format."
                Case FMOD.RESULT.ERR_OUTPUT_INIT
                    Return "Error initializing output device."
                Case FMOD.RESULT.ERR_OUTPUT_NODRIVERS
                    Return "The output device has no drivers installed.  If pre-init, FMOD_OUTPUT_NOSOUND is selected as the output mode.  If post-init, the function just fails."
                Case FMOD.RESULT.ERR_PLUGIN
                    Return "An unspecified error has been returned from a plugin."
                Case FMOD.RESULT.ERR_PLUGIN_MISSING
                    Return "A requested output, dsp unit type or codec was not available."
                Case FMOD.RESULT.ERR_PLUGIN_RESOURCE
                    Return "A resource that the plugin requires cannot be found. (ie the DLS file for MIDI playback)"
                Case FMOD.RESULT.ERR_PLUGIN_VERSION
                    Return "A plugin was built with an unsupported SDK version."
                Case FMOD.RESULT.ERR_RECORD
                    Return "An error occurred trying to initialize the recording device."
                Case FMOD.RESULT.ERR_REVERB_CHANNELGROUP
                    Return "Reverb properties cannot be set on this channel because a parent channelgroup owns the reverb connection."
                Case FMOD.RESULT.ERR_REVERB_INSTANCE
                    Return "Specified instance in FMOD_REVERB_PROPERTIES couldn't be set. Most likely because it is an invalid instance number or the reverb doesn't exist."
                Case FMOD.RESULT.ERR_SUBSOUNDS
                    Return "The error occurred because the sound referenced contains subsounds when it shouldn't have, or it doesn't contain subsounds when it should have.  The operation may also not be able to be performed on a parent sound."
                Case FMOD.RESULT.ERR_SUBSOUND_ALLOCATED
                    Return "This subsound is already being used by another sound, you cannot have more than one parent to a sound.  Null out the other parent's entry first."
                Case FMOD.RESULT.ERR_SUBSOUND_CANTMOVE
                    Return "Shared subsounds cannot be replaced or moved from their parent stream, such as when the parent stream is an FSB file."
                Case FMOD.RESULT.ERR_TAGNOTFOUND
                    Return "The specified tag could not be found or there are no tags."
                Case FMOD.RESULT.ERR_TOOMANYCHANNELS
                    Return "The sound created exceeds the allowable input channel count.  This can be increased using the 'maxinputchannels' parameter in System::setSoftwareFormat."
                Case FMOD.RESULT.ERR_TRUNCATED
                    Return "The retrieved string is too long to fit in the supplied buffer and has been truncated."
                Case FMOD.RESULT.ERR_UNIMPLEMENTED
                    Return "Something in FMOD hasn't been implemented when it should be! contact support!"
                Case FMOD.RESULT.ERR_UNINITIALIZED
                    Return "This command failed because System::init or System::setDriver was not called."
                Case FMOD.RESULT.ERR_UNSUPPORTED
                    Return "A command issued was not supported by this object.  Possibly a plugin without certain callbacks specified."
                Case FMOD.RESULT.ERR_VERSION
                    Return "The version number of this file format is not supported."
                Case FMOD.RESULT.ERR_EVENT_ALREADY_LOADED
                    Return "The specified bank has already been loaded."
                Case FMOD.RESULT.ERR_EVENT_LIVEUPDATE_BUSY
                    Return "The live update connection failed due to the game already being connected."
                Case FMOD.RESULT.ERR_EVENT_LIVEUPDATE_MISMATCH
                    Return "The live update connection failed due to the game data being out of sync with the tool."
                Case FMOD.RESULT.ERR_EVENT_LIVEUPDATE_TIMEOUT
                    Return "The live update connection timed out."
                Case FMOD.RESULT.ERR_EVENT_NOTFOUND
                    Return "The requested event, bus or vca could not be found."
                Case FMOD.RESULT.ERR_STUDIO_UNINITIALIZED
                    Return "The Studio::System object is not yet initialized."
                Case FMOD.RESULT.ERR_STUDIO_NOT_LOADED
                    Return "The specified resource is not loaded, so it can't be unloaded."
                Case FMOD.RESULT.ERR_INVALID_STRING
                    Return "An invalid string was passed to this function."
                Case FMOD.RESULT.ERR_ALREADY_LOCKED
                    Return "The specified resource is already locked."
                Case FMOD.RESULT.ERR_NOT_LOCKED
                    Return "The specified resource is not locked, so it can't be unlocked."
                Case FMOD.RESULT.ERR_RECORD_DISCONNECTED
                    Return "The specified recording driver has been disconnected."
                Case FMOD.RESULT.ERR_TOOMANYSAMPLES
                    Return "The length provided exceed the allowable limit."
                Case Else
                    Return "Unknown error."
            End Select
        End Function
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================