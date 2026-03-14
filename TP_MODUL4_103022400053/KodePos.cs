namespace TP_MODUL4_103022400053
{
    internal class KodePos
    {
        public static string getKodePos(string kelurahan) 
        {
            string[] listKelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer" };
            string[] kodepos = { "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274" };
            int maxIdx = kodepos.Length - 1;

            string current = "40274";
            int level = 0;

            while ((current == "40274") && (level <= maxIdx))
            {
                if (kelurahan == kodepos[level])
                {
                    current = kodepos[level];
                }
                else
                {
                    level++;
                }
            }
            return current;
        }
    }
}
