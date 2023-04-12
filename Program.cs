namespace Visual_Studio_Warning_Not_Shown_In_Error_List
{
    internal class Program
    {
        static string? Fn() => null;

        static void Main()
        {
            _ = Fn().Length;
        }
    }
}
