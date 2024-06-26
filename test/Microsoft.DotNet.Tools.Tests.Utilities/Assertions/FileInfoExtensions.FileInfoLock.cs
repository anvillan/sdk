﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DotNet.Tools.Test.Utilities
{
    public static partial class FileInfoExtensions
    {
        private class FileInfoLock : IDisposable
        {
            private FileStream _fileStream;

            public FileInfoLock(FileInfo fileInfo)
            {
                _fileStream = fileInfo.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }

            public void Dispose() => _fileStream.Dispose();
        }
    }
}
