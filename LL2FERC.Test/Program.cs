namespace LL2FERC.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ff = new LL2FERC.FromFile("namelist_ja.csv");
            Console.WriteLine(ff.GetName_File(35.5, 136.5));
            var ff2 = new LL2FERC.FromFile("namelist_en-US.csv");
            Console.WriteLine(ff2.GetName_File(295));

            /*
            //create csv
            string csv1 = "code,name\n";
            string csv2 = "code,name\n";
            string csv3 = "code,name\n";
            for (int i = 1; i <= 757; i++)
            {
                csv1 += $"{i},\n";
                csv2 += $"{i},{LL2FERC.GetName_ja(i)}\n";
                csv3 += $"{i},{LL2FERC.GetName_enUS(i)}\n";
            }
            File.WriteAllText("namelist_file.csv", csv1);
            File.WriteAllText("namelist_ja.csv", csv2);
            File.WriteAllText("namelist_en-US.csv", csv3);
            */
        }
    }
}
