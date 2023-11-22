namespace BE.Const
{
    public static class Const
    {
        public const string UtcDateTimeFormat = "yyyy-MM-dd'T'HH:mm:ssZ";
        public const string YyyymmddHhmmssFormat = "yyyy-MM-dd HH:mm:ss";

#if DEBUG
        public const string HASH_SECURE_PASSWORD = "C879559B6A9230494BEBC4BB9AF8DCBFE8B55EE807E6F4F3EF78CD11A71C49E5";      // 12345678
#else
        public const string HASH_SECURE_PASSWORD = "468D178C07FF84A8E34D087EC81878336935F73C3899D69BD7B23720A582F75F";      // Ronnie
        // public const string HASH_SECURE_PASSWORD = "B668E826BAC765C8D668D184AA81D01E39B5EF16531474CCF801E44AFBF4A5F0";   // Shira
#endif
    }
}