namespace Kogane
{
    public static class GenericStructExtensionMethods
    {
        public static void Swap<T>( ref this T a, ref T b ) where T : struct
        {
            ( a, b ) = ( b, a );
        }
    }
}