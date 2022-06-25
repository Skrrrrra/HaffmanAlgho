using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HaffmanAlgho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputpath = "D:\\solutionsForSpaceApp\\2044\\input.txt";
            string outputpath = "D:\\solutionsForSpaceApp\\2044\\output.txt";

            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();


            int n;
            using (StreamReader read = new StreamReader(inputpath))
            {
                n = Convert.ToInt32(read.ReadLine());
            }
            


            string[] words = new string[n];
            string[] nums = new string[n];

            using (StreamReader reader = new StreamReader(inputpath))
            {
                reader.ReadLine();
                for (int i = 0; i < n; i++)
                {
                    string[] cr = reader.ReadLine().Split(' ');
                    words[i] = cr[0];
                    nums[i] = cr[1];
                }
            }

            string s;

            using (StreamReader reader = new StreamReader(inputpath))
            {
                reader.ReadLine();
                for(int i = 0; i < n; i++)
                {
                    reader.ReadLine();
                }
                s = reader.ReadLine();
            }
            List<string> strings = new List<string>();
            string num = "";
            for (int i = 0; i < s.Length; i++)
            {
                num += s[i];
                int index = Array.IndexOf(nums, num);
                if (index != -1)
                {
                    strings.Add(words[index]);
                    num = "";
                }
                
            }
            using (StreamWriter writer = new StreamWriter(outputpath))
            {
                for (int i = 0; i < strings.Count; i++)
                {
                    writer.Write(strings[i]);
                }
            }
            
        }
    }
}
