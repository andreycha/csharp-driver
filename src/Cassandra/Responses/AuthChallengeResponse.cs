﻿//
//      Copyright (C) 2012-2014 DataStax Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//

namespace Cassandra.Responses
{
    internal class AuthChallengeResponse : Response
    {
        public const byte OpCode = 0x0E;

        public byte[] Token;

        internal AuthChallengeResponse(Frame frame)
            : base(frame)
        {
            Token = Reader.ReadBytes();
        }

        internal static AuthChallengeResponse Create(Frame frame)
        {
            return new AuthChallengeResponse(frame);
        }
    }
}
