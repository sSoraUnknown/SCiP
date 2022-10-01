using System.IO;

namespace SCiP
{
    static public class Var
    {
        static public string SERVER_PATH, ID, MP, CP, CC, OP, BP, HDD, COM = null;
        static public bool LASTPAGE = false;
        static public string LOCAL_PATH = "LOCAL_DB/";
        static public string LDBPATH = "Path.abc";

        static public void Init()
        {
            Directory.CreateDirectory(LOCAL_PATH);

            if (File.Exists(LOCAL_PATH + LDBPATH))
            {
                SERVER_PATH = File.ReadAllText(LOCAL_PATH + LDBPATH);
            }
            else
            {
                SERVER_PATH = "SERVER_DB/";

                StreamWriter file = new StreamWriter(LOCAL_PATH + LDBPATH);
                file.Write(SERVER_PATH);
                file.Close();
            }
        }

        static public DirectoryInfo[] dir;

        static public void SetConfig()
        { 
            dir = new DirectoryInfo(SERVER_PATH).GetDirectories(); 
        }
    }
}
