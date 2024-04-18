using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        void Swap(int x, int y, int[] tab)
        {
            int temp = tab[x];
            tab[x] = tab[y];
            tab[y] = temp;
        }

        int minIndex(int i, int[] tab)
        {
            int maks = tab[i];
            int maks_index = i;
            for (int j = i + 1; j < tab.Length; j++)
            {
                if (tab[j] > maks)
                {
                    maks = tab[j];
                    maks_index = j;
                }

            }
            return maks_index;
        }

        void zamiana(int[] tab)
        { 
            for (int i = 0; i < tab.Length; i++) 
            {
                Swap(i, minIndex(i,tab), tab);
            
            
            
            }
            foreach (var item in tab)
            {
                Console.WriteLine(item+ "   ");
            }
        
        }

        void Sortowanie(int[] tab)
        {
            for(int i=0; i<tab.Length; i++)
            {
                for(int j=0; j < tab.Length-1; j++)
                {
                    if (tab[j+1] > tab[j])
                    {
                        Swap(j,j+1,tab);
                    }
                }
                
            }
            foreach (var item in tab)
            {
                Console.WriteLine(item + "  ");
            }
        }
        void SortowaniePrzezWstawianie(int[] tab)
        {
            for (int i =1; i<tab.Length;i++)
            {
                int key = tab[i];
                int j = i - 1;
                while (j >= 0 && key < tab[j]) 
                {
                    tab[j+1] = tab[j];
                    
                    j--;

                
                }
                tab[j + 1] = key;
            }

            foreach (var item in tab)
            {
                Console.WriteLine(item + "  ");
            }
        }



    
        static void Main(string[] args)
        {
            
            int[] tab = [4, 2, 1, 55,55];
            Program program= new Program();
            program.SortowaniePrzezWstawianie(tab);

        }
    }
}
