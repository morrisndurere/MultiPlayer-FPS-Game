//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

// These probably do not work currently,
// they are intended to be used with fmod, not the default sound system
// #cleanup

singleton SFXAmbience( AudioAmbienceDefault )
{
   environment = AudioEnvOff;
};

singleton SFXAmbience( AudioAmbienceOutside )
{
   environment = AudioEnvPlain;
   states[ 0 ] = AudioLocationOutside;
};

singleton SFXAmbience( AudioAmbienceInside )
{
   environment = AudioEnvRoom;
   states[ 0 ] = AudioLocationInside;
};

singleton SFXAmbience( AudioAmbienceUnderwater )
{
   environment = AudioEnvUnderwater;
   states[ 0 ] = AudioLocationUnderwater;
};

singleton SFXAmbience( AudioAmbienceForest )
{
   environment = AudioEnvForest;
   states[ 0 ] = AudioLocationOutside;
};

singleton SFXAmbience( AudioAmbienceCave )
{
   environment = AudioEnvCave;
   states[ 0 ] = AudioLocationInside;
};
