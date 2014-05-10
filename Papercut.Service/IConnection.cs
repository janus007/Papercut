﻿/*  
 * Papercut
 *
 *  Copyright © 2008 - 2012 Ken Robertson
 *  Copyright © 2013 - 2014 Jaben Cargman
 *  
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *  
 *  http://www.apache.org/licenses/LICENSE-2.0
 *  
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *  
 */

namespace Papercut.Service
{
    using System;
    using System.Net.Sockets;

    public interface IClient
    {
        int Id { get; }

        Socket Client { get; }

        bool Connected { get; }
    }

    public interface IConnection : IClient
    {
        DateTime LastActivity { get; set; }

        event EventHandler ConnectionClosed;

        void Close(bool triggerEvent = true);
    }
}