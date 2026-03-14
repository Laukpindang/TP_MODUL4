namespace TP_MODUL4_103022400053
{
    internal class KodePos
    {
        public static string getKodePos(string kelurahan) 
        {
            string[] listKelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer" };
            string[] kodepos = { "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274" };
            for (int i = 0; i < listKelurahan.Length; i++)
            {
                if (listKelurahan[i] == kelurahan)
                {
                    return kodepos[i];
                }
            }
            return "tidak ditemukan";
        }
    }
}
