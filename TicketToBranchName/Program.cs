using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TicketToBranchName
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Console.WriteLine("Doing the thing...");

            string text = Clipboard.GetText();

            // All non alphanumeric characters except a dash and space.
            Regex regex = new Regex("[^a-zA-Z0-9 -]");

            // Place dashes where whitespace characters are.
            string result = regex.Replace(text, "").Replace(" ", "-");

            Clipboard.SetText(result);
            Console.WriteLine($"Result: {result}");
        }
    }
}
