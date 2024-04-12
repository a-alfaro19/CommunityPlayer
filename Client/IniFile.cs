using System.Runtime.InteropServices;
using System.Text;

namespace CommunityClient
{
    public class IniFile {
    private string path;

    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

    public IniFile(string path) {
        this.path = path;
    }

    public string Read(string section, string key, string defaultValue = "") {
        try {
            StringBuilder sb = new StringBuilder(255);
            GetPrivateProfileString(section, key, defaultValue, sb, 255, path);
            return sb.ToString();

        } catch(Exception e) {
            Console.WriteLine("Error al leer archivo config: " + e.Message);
            return defaultValue;
        }
    }

}
}
