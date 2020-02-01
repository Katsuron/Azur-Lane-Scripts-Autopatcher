﻿namespace Azurlane
{
    internal static class LuaMgr
    {
        internal static State CheckLuaState(string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);
            return bytes[3] == 0x80 ? State.Encrypted : bytes[3] == 0x02 ? State.Decrypted : State.None;
        }

        internal enum State
        {
            None,
            Encrypted,
            Decrypted
        }
    }
}